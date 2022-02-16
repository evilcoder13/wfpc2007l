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
    public partial class frmCach2 : Form
    {
        public frmCach2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWord.Text)) {
                MessageBox.Show("Phai nhap word!");
                txtWord.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMean.Text))
            {
                MessageBox.Show("Phai nhap mean!");
                txtMean.Focus();
                return;
            }
            lbWord.Items.Add(new TuDien() { Word=txtWord.Text,Mean=txtMean.Text });
            txtWord.Text = "";
            txtMean.Text = "";
            txtWord.Focus();
        }

        private void lbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWord.SelectedIndex < 0) return;
            TuDien tuduocchon = (TuDien)lbWord.SelectedItem;//lbWord.Items[lbWord.SelectedIndex];
            //MessageBox.Show("Da chon: " + tuduocchon.Word + " co doi tuong string la: " + tuduocchon.ToString());
            txtDataMean.Text = tuduocchon.Mean;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbWord.SelectedIndex >= 0 && MessageBox.Show(string.Format("Ban co chac chan muon xoa tu {0} khong?", ((TuDien)lbWord.SelectedItem).Word), "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                lbWord.Items.RemoveAt(lbWord.SelectedIndex);
                MessageBox.Show("Xoa thanh cong!");
                txtWord.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) return;
            var dsTimDuoc = lbWord.Items.Cast<TuDien>().Where(x => x.Word.Contains(txtSearch.Text));
            if (dsTimDuoc.Count() <= 0) { lbWord.SelectedIndex = -1; txtDataMean.Text = "";  return; }
            TuDien t = dsTimDuoc.First();
            lbWord.SelectedItem = t;
        }
    }
}
