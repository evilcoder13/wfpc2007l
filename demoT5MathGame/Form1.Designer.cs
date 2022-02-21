
namespace demoT5MathGame
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtPhepToan = new System.Windows.Forms.TextBox();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 90;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblPoint
            // 
            this.lblPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPoint.Location = new System.Drawing.Point(698, 38);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(90, 20);
            this.lblPoint.TabIndex = 1;
            this.lblPoint.Text = "Point: 000";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhepToan
            // 
            this.txtPhepToan.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhepToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhepToan.Enabled = false;
            this.txtPhepToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhepToan.Location = new System.Drawing.Point(12, 76);
            this.txtPhepToan.Name = "txtPhepToan";
            this.txtPhepToan.Size = new System.Drawing.Size(776, 121);
            this.txtPhepToan.TabIndex = 2;
            this.txtPhepToan.Text = "1 + 1 = 2";
            this.txtPhepToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTrue
            // 
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrue.ForeColor = System.Drawing.Color.Lime;
            this.btnTrue.Location = new System.Drawing.Point(178, 244);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(182, 180);
            this.btnTrue.TabIndex = 3;
            this.btnTrue.Text = "O";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btn_Click);
            this.btnTrue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // btnFalse
            // 
            this.btnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFalse.ForeColor = System.Drawing.Color.Red;
            this.btnFalse.Location = new System.Drawing.Point(450, 244);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(182, 180);
            this.btnFalse.TabIndex = 4;
            this.btnFalse.Text = "X";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btn_Click);
            this.btnFalse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // lblPoint2
            // 
            this.lblPoint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPoint2.Location = new System.Drawing.Point(698, 76);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(90, 20);
            this.lblPoint2.TabIndex = 5;
            this.lblPoint2.Text = "Point: 000";
            this.lblPoint2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPoint2);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.txtPhepToan);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "MATH GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtPhepToan;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Label lblPoint2;
    }
}

