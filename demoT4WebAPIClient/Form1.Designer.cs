
namespace demoT4WebAPIClient
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbSPoster = new System.Windows.Forms.PictureBox();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDetailMovie = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewWeather);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWeather);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            // 
            // btnViewWeather
            // 
            this.btnViewWeather.Location = new System.Drawing.Point(165, 32);
            this.btnViewWeather.Name = "btnViewWeather";
            this.btnViewWeather.Size = new System.Drawing.Size(42, 23);
            this.btnViewWeather.TabIndex = 3;
            this.btnViewWeather.Text = "Xem";
            this.btnViewWeather.UseVisualStyleBackColor = true;
            this.btnViewWeather.Click += new System.EventHandler(this.btnViewWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khu vuc";
            // 
            // txtWeather
            // 
            this.txtWeather.Location = new System.Drawing.Point(7, 68);
            this.txtWeather.Multiline = true;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(200, 330);
            this.txtWeather.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(58, 36);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbSPoster);
            this.groupBox2.Controls.Add(this.dgvMovies);
            this.groupBox2.Controls.Add(this.lbMovies);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(233, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 404);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Movies";
            // 
            // pbSPoster
            // 
            this.pbSPoster.Location = new System.Drawing.Point(9, 302);
            this.pbSPoster.Name = "pbSPoster";
            this.pbSPoster.Size = new System.Drawing.Size(198, 96);
            this.pbSPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSPoster.TabIndex = 6;
            this.pbSPoster.TabStop = false;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Year,
            this.Poster});
            this.dgvMovies.Location = new System.Drawing.Point(9, 164);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMovies.Size = new System.Drawing.Size(198, 131);
            this.dgvMovies.TabIndex = 5;
            this.dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.Location = new System.Drawing.Point(9, 62);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(198, 95);
            this.lbMovies.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(165, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tim";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDetailMovie);
            this.groupBox3.Location = new System.Drawing.Point(452, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 404);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail Movie";
            // 
            // txtDetailMovie
            // 
            this.txtDetailMovie.Location = new System.Drawing.Point(7, 32);
            this.txtDetailMovie.Multiline = true;
            this.txtDetailMovie.Name = "txtDetailMovie";
            this.txtDetailMovie.Size = new System.Drawing.Size(200, 366);
            this.txtDetailMovie.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Tieu De";
            this.Title.Name = "Title";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Nam";
            this.Year.Name = "Year";
            // 
            // Poster
            // 
            this.Poster.DataPropertyName = "Poster";
            this.Poster.HeaderText = "Hinh Anh";
            this.Poster.Name = "Poster";
            this.Poster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Poster.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDetailMovie;
        private System.Windows.Forms.PictureBox pbSPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poster;
    }
}

