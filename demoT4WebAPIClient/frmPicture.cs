using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoT4WebAPIClient
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }
        public void HienThiAnh(string location) {
            pictureBox1.ImageLocation = location;
        }
        private void frmPicture_Load(object sender, EventArgs e)
        {

        }
    }
}
