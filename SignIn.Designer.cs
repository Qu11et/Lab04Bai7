﻿namespace Lab04Bai7
{
    partial class SignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Show_Password = new System.Windows.Forms.Button();
            this.chb_SSL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IMAP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Show_Password);
            this.panel1.Controls.Add(this.chb_SSL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_IMAP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Port);
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Location = new System.Drawing.Point(27, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 193);
            this.panel1.TabIndex = 0;
            // 
            // btn_Show_Password
            // 
            this.btn_Show_Password.BackColor = System.Drawing.Color.White;
            this.btn_Show_Password.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Show_Password.FlatAppearance.BorderSize = 0;
            this.btn_Show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show_Password.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Show_Password.ForeColor = System.Drawing.Color.Black;
            this.btn_Show_Password.Location = new System.Drawing.Point(403, 103);
            this.btn_Show_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Show_Password.Name = "btn_Show_Password";
            this.btn_Show_Password.Size = new System.Drawing.Size(33, 27);
            this.btn_Show_Password.TabIndex = 25;
            this.btn_Show_Password.TabStop = false;
            this.btn_Show_Password.Text = "👁";
            this.btn_Show_Password.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Show_Password.UseVisualStyleBackColor = false;
            // 
            // chb_SSL
            // 
            this.chb_SSL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_SSL.AutoSize = true;
            this.chb_SSL.Checked = true;
            this.chb_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_SSL.Location = new System.Drawing.Point(225, 159);
            this.chb_SSL.Margin = new System.Windows.Forms.Padding(4);
            this.chb_SSL.Name = "chb_SSL";
            this.chb_SSL.Size = new System.Drawing.Size(54, 20);
            this.chb_SSL.TabIndex = 24;
            this.chb_SSL.Text = "SSL";
            this.chb_SSL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "IMAP Server:";
            // 
            // txt_IMAP
            // 
            this.txt_IMAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IMAP.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_IMAP.Location = new System.Drawing.Point(120, 16);
            this.txt_IMAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IMAP.Name = "txt_IMAP";
            this.txt_IMAP.Size = new System.Drawing.Size(187, 28);
            this.txt_IMAP.TabIndex = 13;
            this.txt_IMAP.Text = "imap.gmail.com";
            this.txt_IMAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(325, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port:";
            // 
            // txt_Port
            // 
            this.txt_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Port.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Port.Location = new System.Drawing.Point(379, 16);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(57, 28);
            this.txt_Port.TabIndex = 12;
            this.txt_Port.Text = "993";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignIn.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_SignIn.Location = new System.Drawing.Point(285, 149);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(155, 37);
            this.btn_SignIn.TabIndex = 9;
            this.btn_SignIn.Text = "Đăng Nhập";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Email.Location = new System.Drawing.Point(120, 59);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(316, 28);
            this.txt_Email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật khẩu:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Password.Location = new System.Drawing.Point(120, 102);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(316, 28);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IMAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.CheckBox chb_SSL;
        private System.Windows.Forms.Button btn_Show_Password;
    }
}