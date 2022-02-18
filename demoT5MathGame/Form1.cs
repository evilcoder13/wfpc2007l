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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinhPhepToan();
        }
        Random rnd = new Random();
        bool ketqua = true;
        int diem = 0;
        int level = 0;
        void SinhPhepToan() {
            int so1 = rnd.Next(0-5*level,10+ int.Parse(Math.Pow(2,level).ToString()));
            int so2 = rnd.Next(0 - 5 * level, 10 + int.Parse(Math.Pow(2, level).ToString()));
            string dau = "+-*";
            char dauduocchon = dau[rnd.Next(0, 2)];
            int ketquadung = 0;
            switch (dauduocchon) {
                case '+':
                    ketquadung = so1 + so2;
                    break;
                case '-':
                    ketquadung = so1 - so2;
                    break;
                case '*':
                    ketquadung = so1 * so2;
                    break;
            }
            ketqua = rnd.Next(0, 10) > 5;
            if (!ketqua) {
                //Sinh ra phep toan sai.
                int saiso = 0;
                while (saiso == 0) saiso = rnd.Next(-10, 10);
                ketquadung = ketquadung + saiso;
            }
            txtPhepToan.Text = string.Format("{0} {1} {2} = {3}", so1, dauduocchon, so2, ketquadung);
            lblPoint.Text = string.Format("Point: {0}", diem);
        }

        void GameOver() {
            MessageBox.Show("Sai roi!");
        }
        

        private void btn_Click(object sender, EventArgs e)
        {
            Button nutduocbam = (Button)sender;
            if ((ketqua && nutduocbam.Text == "O") || (!ketqua && nutduocbam.Text == "X"))
            {
                diem++;
                if (diem % 5 == 0) level++;
                SinhPhepToan();
            }
            else GameOver();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C) btnTrue.PerformClick();
            else if (e.KeyCode == Keys.V) btnFalse.PerformClick();
        }
    }
}
