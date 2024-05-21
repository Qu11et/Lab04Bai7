using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab04Bai7.LoiMoiDiAn;
using MailKit.Net.Smtp;
using System.IO;


namespace Lab04Bai7
{
    public partial class EmailForm : Form
    {
        private Email email;
        public EmailForm()
        {
            InitializeComponent();
        }

        public void DisplayEmail(Email email)
        {
            this.email = email;
            // lblSender and txtBody are controls on the form
            lblSender.Text = email.Sender;
            //txtBody.Text = email.Body;
            webBrowser1.DocumentText = email.Body;

            // Clear any existing images
            flowLayoutPanelImages.Controls.Clear();

            // Add each image to the FlowLayoutPanel
            string imagesDirectory = @"D:\repositories\Lab04Bai7\Lab04Bai7\obj"; // Replace with your directory
            foreach (var imageFile in Directory.GetFiles(imagesDirectory))
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imageFile),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 100
                };
                flowLayoutPanelImages.Controls.Add(pictureBox);
            }

        }

        private async void btnReply_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(EmailSetting.nickname, EmailSetting.username));
            message.To.Add(new MailboxAddress("", email.Sender));
            message.Subject = "Re: ";
            message.Body = new TextPart("plain") { Text = txtReply.Text };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync(EmailSetting.username, EmailSetting.password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

            MessageBox.Show("Reply sent!");

        }
    }
}
