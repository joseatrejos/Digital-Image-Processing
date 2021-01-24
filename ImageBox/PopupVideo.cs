using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ImageBox
{
    public partial class PopupVideo : Form
    {
        Form1 form;

        VideoCapture video;
        bool pausa = false;

        public PopupVideo(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        // Load Video
        private void loadVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                video = new Emgu.CV.VideoCapture(ofd.FileName);
                Mat m = new Mat();
                video.Read(m);
                pictureBox1.Image = m.Bitmap;
            }
        }

        // Close Popup Window
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Play Video
        private async void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pausa = false;
            try
            {
                while (!pausa)
                {
                    Mat m = new Mat();
                    video.Read(m);
                    if (!m.IsEmpty)
                    {
                        pictureBox2.Image = m.Bitmap;
                        DetectText(m.ToImage<Bgr, byte>());
                        double fps = video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Pause Video
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pausa = true;
        }

        // Text Recognition Algorithm
        private void DetectText(Image<Bgr, byte> img)
        {
            // Detección de Bordes con Sobel
            Image<Gray, byte> sobel = img.Convert<Gray, byte>().Sobel(1, 0, 3).AbsDiff(new Gray(0.0)).Convert<Gray, byte>().ThresholdBinary(new Gray(200), new Gray(255));
            Mat SE = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(10, 2), new Point(-1, -1)) ;

            // Dilation
            sobel = sobel.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Dilate, SE, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, new MCvScalar(255)) ;
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();

            // Find Contours
            Mat m = new Mat();
            CvInvoke.FindContours(sobel, contours, m, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            // Geometrical Constraints
            List<Rectangle> list = new List<Rectangle>();

            for(int i = 0; i < contours.Size; i++)
            {
                Rectangle brect = CvInvoke.BoundingRectangle(contours[i]);
                double ar = brect.Width / brect.Height;

                if(ar > 2 && brect.Width > 25 && brect.Height > 8 && brect.Height < 100)
                {
                    list.Add(brect);
                }
            }

            Image<Bgr, byte> imgout = img.CopyBlank();
            foreach(var r in list)
            {
                CvInvoke.Rectangle(img, r, new MCvScalar(0, 0, 255), 2);
                CvInvoke.Rectangle(imgout, r, new MCvScalar(0, 255, 255), -1);
            }

            imgout._And(img);
            pictureBox1.Image = img.Bitmap;
            pictureBox2.Image = imgout.Bitmap;
        }
    }
}
