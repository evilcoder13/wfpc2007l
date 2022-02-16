
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewWeather = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(58, 36);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 0;
            // 
            // txtWeather
            // 
            this.txtWeather.Location = new System.Drawing.Point(7, 68);
            this.txtWeather.Multiline = true;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(200, 292);
            this.txtWeather.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.TextBox txtArea;
    }
}

