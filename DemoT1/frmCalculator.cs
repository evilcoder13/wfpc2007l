using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoT1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string nutduocbam = ((Button)sender).Text;
            if (nutduocbam != "=")
                textBox1.Text += nutduocbam;
            else {
                //Tinh ra ket qua
                try { 
                Jace.CalculationEngine ce = new Jace.CalculationEngine();
                string ketqua = ce.Calculate(textBox1.Text.Replace("x","*")).ToString();
                textBox1.Text += "=" + ketqua;
                MessageBox.Show(textBox1.Text);
                textBox1.Text = "";
                } catch(Exception ex)
                {
                    MessageBox.Show("Bieu thuc \"" + textBox1.Text + "\" khong hop le!");
                    textBox1.Text = "";
                }
            }
        }
    }
}
