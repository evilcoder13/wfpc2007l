using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT2
{
    public partial class frmLyThuyet : Form
    {
        public frmLyThuyet()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(numericUpDown1.Value<numericUpDown1.Maximum) numericUpDown1.Value += 1;

            if (progressBar1.Value <= progressBar1.Maximum - 10) progressBar1.Value += 10;
        }
    }
}
