namespace Lab04Bai7
{
    partial class EmailForm
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
            this.lblSender = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.txtReply = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(12, 9);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(95, 36);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "label1";
            // 
            // btnReply
            // 
            this.btnReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReply.Location = new System.Drawing.Point(629, 371);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(159, 53);
            this.btnReply.TabIndex = 2;
            this.btnReply.Text = "Phản hồi";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(18, 350);
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(605, 102);
            this.txtReply.TabIndex = 3;
            this.txtReply.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(419, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(369, 285);
            this.webBrowser1.TabIndex = 4;
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(18, 48);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(382, 285);
            this.flowLayoutPanelImages.TabIndex = 5;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.flowLayoutPanelImages);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.lblSender);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.RichTextBox txtReply;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
    }
}