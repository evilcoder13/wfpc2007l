using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoT5MathGame
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            multiPlayer = false;
            this.Close();
        }
        public bool multiPlayer = false;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            multiPlayer = true;
            this.Close();
        }
    }
}
