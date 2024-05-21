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

            public List<System.Drawing.Image> Images { get; set; }
        }

        private void LoiMoiDiAn_Load(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();

            foreach (var message in Form1.invitations)
            {
                var body = message.HtmlBody; // Extract the HTML body of the email
                var emailSender = message.From.Mailboxes.First().Address; // Extract the sender of the email

                // Extract images
                var images = new List<System.Drawing.Image>();
                foreach (var attachment in message.BodyParts.OfType<MimePart>())
                {
                    if (attachment.IsAttachment && attachment.ContentType.MediaType == "image")
                    {
                        using (var stream = new MemoryStream())
                        {
                            attachment.Content.DecodeTo(stream);
                            var image = System.Drawing.Image.FromStream(stream);
                            images.Add(image);
                        }
                    }
                }

                emails.Add(new Email { Sender = emailSender, Body = body, Images = images });
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
