using System;
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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            SplashScreen frm = new SplashScreen();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhom.Text)) {
                MessageBox.Show("Khong duoc de trong ten nhom!");
                txtTenNhom.Focus();
                return;
            }

            if (tvNhomQuyen.SelectedNode == null)
                tvNhomQuyen.Nodes.Add(txtTenNhom.Text);
            else {
                tvNhomQuyen.SelectedNode.Nodes.Add(txtTenNhom.Text);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpPhanQuyen) {
                lblThongTinNguoiDung.Text = string.Format("Ten: {0} / Username: {1}", txtNguoiDung.Text, txtTenDangNhap.Text);
            }

            tvDsQuyen.Nodes.Clear();
            foreach (TreeNode tn in tvNhomQuyen.Nodes)
                tvDsQuyen.Nodes.Add((TreeNode)tn.Clone());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tvDsChon.Nodes.Add((TreeNode)tvDsQuyen.SelectedNode.Clone());
            //tvDsQuyen.Nodes.Remove(tvDsQuyen.SelectedNode);

            // 2 viec xu ly chinh:
            // 1. Tao 1 tree ao chua toan bo tu goc cho den nhanh dang duoc chon de add
            // 2. So sanh tree ao nay voi tree dang co o tvDsChon de xem nhung goc / nhanh nao trung thi khong add sang nua, chi add nhanh moi khac nhanh dang co o tvDsChon

            TreeNode nodeDaChon = tvDsQuyen.SelectedNode;
            string fpath = nodeDaChon.FullPath;
            string[] pathArr = fpath.Split('\\');
            TreeView tempTree = new TreeView();
            foreach (TreeNode node in tvDsQuyen.Nodes) {
                if (node.FullPath == pathArr[0]) {
                    TreeNode foundNode = (TreeNode)node.Clone();
                    tempTree.Nodes.Add(foundNode);
                    AddTree(pathArr,1,foundNode);
                    CheckTree(tempTree.Nodes[0], tvDsChon.Nodes, null);
                    tvDsQuyen.Nodes.Remove(tvDsQuyen.SelectedNode);
                    //tvDsChon.Nodes.Add((TreeNode)foundNode.Clone());
                    break;
                }
            }
        }

        void CheckTree(TreeNode node, TreeNodeCollection nodeArr, TreeNode nodecha) {
            int i = 0;
            for (; i < nodeArr.Count; i++) {
                if (nodeArr[i].FullPath == node.FullPath) {
                    if (node.Nodes.Count > 0)
                    {
                        CheckTree(node.Nodes[0], nodeArr[i].Nodes, nodeArr[i]);
                        break;
                    }
                    else break;
                }
            }
            if (i >= nodeArr.Count) {
                if (nodecha == null) tvDsChon.Nodes.Add((TreeNode)node.Clone());
                else { nodecha.Nodes.Add((TreeNode)node.Clone()); }
            }
        }

        void AddTree(string[] pathArr, int level, TreeNode node) {
            if (level >= pathArr.Length) return;
            string[] pathArrHienTai = new string[level + 1];
            Array.Copy(pathArr, pathArrHienTai, level + 1);
            string pathHienTai = string.Join("\\", pathArrHienTai);
            while (true) {
                int i = 0;
                for (; i < node.Nodes.Count; i++) {
                    if (node.Nodes[i].FullPath != pathHienTai)
                    {
                        node.Nodes.RemoveAt(i);
                        break;
                    }
                    else {
                        AddTree(pathArr, level + 1, node.Nodes[i]);
                    }
                }
                if(i >= node.Nodes.Count)
                {
                    break;
                }
            }
        }

        StringBuilder sb = new StringBuilder();
        private void btnSave_Click(object sender, EventArgs e)
        {
            sb.Clear();
            foreach(TreeNode tn in tvDsChon.Nodes)
                BuildPath(tn);
            MessageBox.Show("Cac quyen da chon la: \n" + sb.ToString());
        }

        void BuildPath(TreeNode tn) {
            if (tn.Nodes.Count > 0)
                foreach (TreeNode t in tn.Nodes) BuildPath(t);
            else sb.AppendLine(tn.FullPath);
            
        }
    }
}
