using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBox
{
    public partial class ParametrosOverlay : Form
    {
        Form1 form;
        public ParametrosOverlay(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        // Apply Changes to Filter
        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.AplicarOverlay(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
        }
        
        // Close Popup Window
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
