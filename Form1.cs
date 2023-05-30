using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (dOpen.ShowDialog() == DialogResult.OK)
            {
                pbSource.Image = new Bitmap(dOpen.OpenFile());
                btPerform.Enabled = true;
            }
        }

        private void btPerform_Click(object sender, EventArgs e)
        {
            pbRes.Image = GraphicsUtils.FloydSteinbergDithering(pbSource.Image);
        }
    }
}
