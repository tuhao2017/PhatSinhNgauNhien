namespace PhatSinhNgauNhien
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
            this.txtSoNgauNhien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhatSinhNgauNhien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoNgauNhien
            // 
            this.txtSoNgauNhien.Location = new System.Drawing.Point(105, 79);
            this.txtSoNgauNhien.Name = "txtSoNgauNhien";
            this.txtSoNgauNhien.Size = new System.Drawing.Size(171, 20);
            this.txtSoNgauNhien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phát sinh";
            // 
            // btnPhatSinhNgauNhien
            // 
            this.btnPhatSinhNgauNhien.Location = new System.Drawing.Point(105, 138);
            this.btnPhatSinhNgauNhien.Name = "btnPhatSinhNgauNhien";
            this.btnPhatSinhNgauNhien.Size = new System.Drawing.Size(171, 23);
            this.btnPhatSinhNgauNhien.TabIndex = 2;
            this.btnPhatSinhNgauNhien.Text = "Phát sinh số ngẫu nhiên";
            this.btnPhatSinhNgauNhien.UseVisualStyleBackColor = true;
            this.btnPhatSinhNgauNhien.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phát sinh số ngẫu nhiên âm tăng, bài 2. Nhân với -1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhatSinhNgauNhien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoNgauNhien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoNgauNhien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhatSinhNgauNhien;
        private System.Windows.Forms.Label label2;
    }
}

