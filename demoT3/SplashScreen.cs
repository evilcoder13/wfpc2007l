﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoT3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 2;
            }
            else {
                timer1.Stop();
                // Chuyen form
                //frmMainForm frm = new frmMainForm();
                //this.Hide();
                //frm.ShowDialog();
                //Application.Exit();
                //Dong form
                this.Close();
            }
        }
    }
}
