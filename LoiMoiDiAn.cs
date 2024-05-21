using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Bai7
{
    public partial class LoiMoiDiAn : Form
    {
        public LoiMoiDiAn()
        {
            InitializeComponent();
        }

        public class Email
        {
            public string Sender { get; set; }
            public string Body { get; set; }
            public string ImageDirectory { get; set; }
            public List<System.Drawing.Image> Images { get; set; }
        }

        private void LoiMoiDiAn_Load(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();
            string baseDirectory = @"C:\path\to\your\directory"; // Replace with your directory

            foreach (var message in Form1.invitations)
            {
                var body = message.HtmlBody; // Extract the HTML body of the email
                var emailSender = message.From.Mailboxes.First().Address; // Extract the sender of the email

                // Create a unique directory for this email
                string emailDirectory = Path.Combine(baseDirectory, message.MessageId);
                Directory.CreateDirectory(emailDirectory);

                // Parse the HTML body into a HtmlDocument
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(body);

                // Find the <img> tag
                var imgTag = htmlDocument.DocumentNode.SelectSingleNode("//img");
                if (imgTag != null)
                {
                    // Extract the cid from the src attribute
                    string src = imgTag.GetAttributeValue("src", "");
                    string cid = src.Substring(4); // Remove the "cid:" prefix

                    // Find the MIME part with the matching Content-ID
                    var imagePart = message.BodyParts.OfType<MimePart>().FirstOrDefault(part => part.ContentId == cid);
                    if (imagePart != null)
                    {
                        // Decode the image
                        using (var stream = new MemoryStream())
                        {
                            imagePart.Content.DecodeTo(stream);
                            var image = System.Drawing.Image.FromStream(stream);
                            // Now you have the image!

                            // Save the image to a file
                            string imagePath = Path.Combine(emailDirectory, imagePart.ContentId + Path.GetExtension(imagePart.FileName));
                            image.Save(imagePath);
                        }
                    }
                }

                emails.Add(new Email { Sender = emailSender, Body = body, ImageDirectory = emailDirectory });
            }

            dataGridView1.DataSource = emails;
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the clicked row is not the header
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                var email = (Email)selectedRow.DataBoundItem;

                EmailForm emailForm = new EmailForm();
                emailForm.DisplayEmail(email);
                emailForm.Show();
            }

        }

        private void Addprogressbar(string monan, string gia, string diachi, string nguoidonggop, PictureBox pictureBox)
        {
            Hienthimonan hienthi = new Hienthimonan();
            hienthi.Settenmonan(monan);
            hienthi.Setgiamonan(gia);
            hienthi.Setdiachi(diachi);
            hienthi.Setnguoidonggop(nguoidonggop);
            hienthi.SetPictureBox(pictureBox);
            flowLayoutPanel1.Controls.Add(hienthi);
        }
    }
}
