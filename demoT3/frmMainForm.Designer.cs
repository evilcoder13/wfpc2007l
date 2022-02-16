
namespace demoT3
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Quyen 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quyen 2.1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quyen 2.2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quyen 2", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quyen 3.1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quyen 3.2.1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quyen 3.2.2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quyen 3.2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Quyen 3.3");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Quyen 3", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node0");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhomQuyen = new System.Windows.Forms.TabPage();
            this.tvNhomQuyen = new System.Windows.Forms.TreeView();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpThongTinChung = new System.Windows.Forms.TabPage();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPhanQuyen = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tvDsChon = new System.Windows.Forms.TreeView();
            this.tvDsQuyen = new System.Windows.Forms.TreeView();
            this.lblThongTinNguoiDung = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tpNhomQuyen.SuspendLayout();
            this.tpThongTinChung.SuspendLayout();
            this.tpPhanQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpNhomQuyen);
            this.tabControl1.Controls.Add(this.tpThongTinChung);
            this.tabControl1.Controls.Add(this.tpPhanQuyen);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpNhomQuyen
            // 
            this.tpNhomQuyen.Controls.Add(this.tvNhomQuyen);
            this.tpNhomQuyen.Controls.Add(this.btnThemNhom);
            this.tpNhomQuyen.Controls.Add(this.txtTenNhom);
            this.tpNhomQuyen.Controls.Add(this.label1);
            this.tpNhomQuyen.Location = new System.Drawing.Point(4, 22);
            this.tpNhomQuyen.Name = "tpNhomQuyen";
            this.tpNhomQuyen.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhomQuyen.Size = new System.Drawing.Size(551, 337);
            this.tpNhomQuyen.TabIndex = 0;
            this.tpNhomQuyen.Text = "Nhom Quyen";
            this.tpNhomQuyen.UseVisualStyleBackColor = true;
            // 
            // tvNhomQuyen
            // 
            this.tvNhomQuyen.Dock = System.Windows.Forms.DockStyle.Right;
            this.tvNhomQuyen.Location = new System.Drawing.Point(195, 3);
            this.tvNhomQuyen.Name = "tvNhomQuyen";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Quyen 1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Quyen 2.1";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Quyen 2.2";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Quyen 2";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Quyen 3.1";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Quyen 3.2.1";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Quyen 3.2.2";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Quyen 3.2";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Quyen 3.3";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Quyen 3";
            this.tvNhomQuyen.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode10});
            this.tvNhomQuyen.Size = new System.Drawing.Size(353, 331);
            this.tvNhomQuyen.TabIndex = 4;
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Location = new System.Drawing.Point(33, 50);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(75, 23);
            this.btnThemNhom.TabIndex = 3;
            this.btnThemNhom.Text = "Them Nhom";
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(33, 24);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(152, 20);
            this.txtTenNhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Nhom";
            // 
            // tpThongTinChung
            // 
            this.tpThongTinChung.Controls.Add(this.txtMatKhau);
            this.tpThongTinChung.Controls.Add(this.label4);
            this.tpThongTinChung.Controls.Add(this.txtTenDangNhap);
            this.tpThongTinChung.Controls.Add(this.label3);
            this.tpThongTinChung.Controls.Add(this.txtNguoiDung);
            this.tpThongTinChung.Controls.Add(this.label2);
            this.tpThongTinChung.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinChung.Name = "tpThongTinChung";
            this.tpThongTinChung.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinChung.Size = new System.Drawing.Size(551, 337);
            this.tpThongTinChung.TabIndex = 1;
            this.tpThongTinChung.Text = "Thong tin chung";
            this.tpThongTinChung.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(207, 156);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '-';
            this.txtMatKhau.Size = new System.Drawing.Size(152, 20);
            this.txtMatKhau.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mat Khau";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(207, 123);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(152, 20);
            this.txtTenDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ten Dang Nhap";
            // 
            // txtNguoiDung
            // 
            this.txtNguoiDung.Location = new System.Drawing.Point(207, 90);
            this.txtNguoiDung.Name = "txtNguoiDung";
            this.txtNguoiDung.Size = new System.Drawing.Size(152, 20);
            this.txtNguoiDung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nguoi Dung";
            // 
            // tpPhanQuyen
            // 
            this.tpPhanQuyen.Controls.Add(this.btnSave);
            this.tpPhanQuyen.Controls.Add(this.btnRemove);
            this.tpPhanQuyen.Controls.Add(this.btnAdd);
            this.tpPhanQuyen.Controls.Add(this.tvDsChon);
            this.tpPhanQuyen.Controls.Add(this.tvDsQuyen);
            this.tpPhanQuyen.Controls.Add(this.lblThongTinNguoiDung);
            this.tpPhanQuyen.Controls.Add(this.label5);
            this.tpPhanQuyen.Location = new System.Drawing.Point(4, 22);
            this.tpPhanQuyen.Name = "tpPhanQuyen";
            this.tpPhanQuyen.Size = new System.Drawing.Size(551, 337);
            this.tpPhanQuyen.TabIndex = 2;
            this.tpPhanQuyen.Text = "Phan quyen";
            this.tpPhanQuyen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(238, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(238, 148);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(238, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tvDsChon
            // 
            this.tvDsChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDsChon.Location = new System.Drawing.Point(323, 52);
            this.tvDsChon.Name = "tvDsChon";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Node0";
            this.tvDsChon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.tvDsChon.Size = new System.Drawing.Size(213, 269);
            this.tvDsChon.TabIndex = 6;
            // 
            // tvDsQuyen
            // 
            this.tvDsQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDsQuyen.Location = new System.Drawing.Point(14, 52);
            this.tvDsQuyen.Name = "tvDsQuyen";
            this.tvDsQuyen.Size = new System.Drawing.Size(213, 269);
            this.tvDsQuyen.TabIndex = 5;
            // 
            // lblThongTinNguoiDung
            // 
            this.lblThongTinNguoiDung.AutoSize = true;
            this.lblThongTinNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinNguoiDung.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblThongTinNguoiDung.Location = new System.Drawing.Point(87, 12);
            this.lblThongTinNguoiDung.Name = "lblThongTinNguoiDung";
            this.lblThongTinNguoiDung.Size = new System.Drawing.Size(0, 17);
            this.lblThongTinNguoiDung.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nguoi Dung: ";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(17, 383);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Gioi Thieu";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(98, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Tat Chuong Trinh";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btnThemNhom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMainForm";
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNhomQuyen.ResumeLayout(false);
            this.tpNhomQuyen.PerformLayout();
            this.tpThongTinChung.ResumeLayout(false);
            this.tpThongTinChung.PerformLayout();
            this.tpPhanQuyen.ResumeLayout(false);
            this.tpPhanQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhomQuyen;
        private System.Windows.Forms.TabPage tpThongTinChung;
        private System.Windows.Forms.TabPage tpPhanQuyen;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvNhomQuyen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongTinNguoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView tvDsChon;
        private System.Windows.Forms.TreeView tvDsQuyen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}