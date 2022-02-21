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

        Timer timer = new Timer();
        bool multiPlayer = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowStart();
            SinhPhepToan();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            
        }
        void ShowStart() {
            this.Hide();
            frmStartScreen frm = new frmStartScreen();
            frm.ShowDialog();
            multiPlayer = frm.multiPlayer;
            if(!this.IsDisposed) this.Show();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) progressBar1.Value += 3;
            if (progressBar1.Value >= progressBar1.Maximum) {
                GameOver();
            }
        }

        Random rnd = new Random();
        bool ketqua = true;
        int diem = 0;
        int diem2 = 0;
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
            if (!multiPlayer) lblPoint2.Text = "";
            else lblPoint2.Text = string.Format("Point 2: {0}", diem2);
            progressBar1.Value = 0;
            timer.Start();
        }

        void GameOver() {
            timer.Stop();
            if(!multiPlayer)
                MessageBox.Show("GAME OVER!\nYOUR CURRENT POINT: " + diem.ToString(),"GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else MessageBox.Show("GAME OVER!\n"+(diem>diem2?"PLAYER 1":"PLAYER 2")+" WIN!\nPLAYER 1 POINT: " + diem.ToString()+"\nPLAYER 2 POINT: "+diem2.ToString(), "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ShowStart();
            diem = 0;
            level = 0;
            SinhPhepToan();
        }

        int nguoichoi = 1;

        private void btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            nguoichoi1_matluot = false;
            nguoichoi2_matluot = false;
            Button nutduocbam = (Button)sender;
            if ((ketqua && nutduocbam.Text == "O") || (!ketqua && nutduocbam.Text == "X"))
            {
                if (!multiPlayer)
                {
                    diem++;
                    if (diem % 5 == 0) level++;
                    SinhPhepToan();
                }
                else
                {
                    if (nguoichoi == 1) diem++;
                    else diem2++;
                    if ((diem + diem2) % 5 == 0) level++;
                    if (Math.Abs(diem - diem2) > 10) { GameOver(); return; }
                    SinhPhepToan();
                }
            }
            else
            {
                if (!multiPlayer)
                    GameOver();
                else {
                    if (nguoichoi == 1) nguoichoi1_matluot = true;
                    else nguoichoi2_matluot = true;
                    SinhPhepToan();
                }
            }
        }

        bool nguoichoi1_matluot = false;
        bool nguoichoi2_matluot = false;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C) { if (nguoichoi1_matluot) return; nguoichoi = 1; btnTrue.PerformClick(); }
            else if (e.KeyCode == Keys.V) { if (nguoichoi1_matluot) return; nguoichoi = 1; btnFalse.PerformClick(); }
            else if (e.KeyCode == Keys.O) { if (nguoichoi2_matluot) return; nguoichoi = 2; btnTrue.PerformClick(); }
            else if (e.KeyCode == Keys.P) { if (nguoichoi2_matluot) return; nguoichoi = 2; btnFalse.PerformClick(); }
        }
    }
}
