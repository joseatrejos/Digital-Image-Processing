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
    public partial class ParametrosRange : Form
    {
        Form1 form;
        public ParametrosRange(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        // Apply Changes to Filter
        private void Button1_Click(object sender, EventArgs e)
        {
            if(form != null)
            {
                form.AplicarRangeFilter(trackBar1.Value, trackBar2.Value);
            }
        }

        // Close Popup Window
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
