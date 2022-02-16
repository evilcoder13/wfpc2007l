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
    public partial class BaiTap2 : Form
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //Button -> btn
            //Label -> lbl
            //Textbox -> txt
            //DropDownList -> ddl
            //ListBox -> lst 
            //GridView -> grd

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lbWord.Visible)
            {
                lbWord.Visible = false;
                lbMean.Visible = true;
            }
            else
            {
                lbWord.Visible = true;
                lbMean.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWord.Text) && !string.IsNullOrEmpty(txtMean.Text)) {
                lbWord.Items.Add(txtWord.Text);
                lbMean.Items.Add(txtMean.Text);
            }
        }

        private void lbMean_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMean.SelectedIndex < 0) return;
            int vitri = lbMean.SelectedIndex;
            string word = lbWord.Items[vitri].ToString();
            txtDataMean.Text = word;
        }

        private void lbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWord.SelectedIndex < 0) return;
            int vitri = lbWord.SelectedIndex;
            string mean = lbMean.Items[vitri].ToString();
            txtDataMean.Text = mean;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) return;
            ListBox lb;
            if (lbMean.Visible) lb = lbMean;
            else lb = lbWord;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                if (lb.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower())) {
                    lb.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListBox lb;
            if (lbMean.Visible) lb = lbMean;
            else lb = lbWord;

            if (lb.SelectedIndex >= 0 && MessageBox.Show("Ban co chac chan muon xoa tu nay khong?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                int vitrixoa = lb.SelectedIndex;
                lbWord.Items.RemoveAt(vitrixoa);
                lbMean.Items.RemoveAt(vitrixoa);

                MessageBox.Show("Xoa thanh cong!");
            }
        }

        private void BaiTap2_Load(object sender, EventArgs e)
        {

            lbWord.Visible = true;
            lbMean.Visible = false;
        }
    }
}
