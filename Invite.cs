using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Runtime.InteropServices;
using MimeKit;
using MimeKit.Text;
using MimeKit.Utils;
using MailKit.Net.Smtp;
using Application = System.Windows.Forms.Application;
using System.Web;
using Lab04Bai7;
using System.IO;



namespace Lab04Bai7
{
    public partial class Invite : Form
    {
        public Invite(Control selectedControl)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(selectedControl);
        }



        private void sendBtn_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = EmailSetting.username;
            to = receiverTxt.Text.Trim();
            pass = EmailSetting.password;
            //content = txtContent.Text;

            // Get the selected control from the flowLayoutPanel1
            Hienthimonan selectedControl = (Hienthimonan)flowLayoutPanel1.Controls[0];

            // Get the name of the dish from the selected control
            string monAn = selectedControl.MonAnName;
            //Image hinhAnh = selectedControl.MonAnImage;

            // Xây dựng html cho email body
            System.Drawing.Image image = selectedControl.MonAnImage;
            string Name = selectedControl.MonAnName;
            string Gia = selectedControl.GiaMonAn;
            string DiaChi = selectedControl.DiaChi;
            //Lư ảnh vào thư mục tạm
            string tempFilePath = Path.Combine(Path.GetTempPath(), "AnhMonAn.png");
            image.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Png);

            BodyBuilder builder = new BodyBuilder();
            // Thêm tệp tạm thời vào MimeEntity
            MimeEntity mimeEntity = builder.LinkedResources.Add(tempFilePath);
            mimeEntity.ContentId = MimeUtils.GenerateMessageId();

            builder.HtmlBody = string.Format(
                "<!DOCTYPE html>\n" +
                "<html lang=\"en\">\n" +
                "<head>\n" +
                "<meta charset=\"UTF-8\">\n" +
                "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n" +
                "<title>UIT - NT106 Lab 6 - Hôm nay ăn gì ?</title>\n" +
                "<meta name=\"description\" content=\"Lab4\" />\n" +
                "<meta name=\"keywords\" content=\"Lab4\" />\n" +
                "</head>\n" +
                "<body class='pushmenu-push' id=\"page\">\n" +
                "<div class=\"dialog\" style=\"width:60%;margin:10% auto;text-align:center;\">\n" +
                "<div class=\"dialogBox\">\n" +
                "<h4>Bạn có một lời mời đi ăn!</h4>\n" +
                "<h3>NT106 Lab 6 - Bạn muốn ăn gì ?</h3>\n" +
                "<img src=\"cid:{0}\" alt=\"Trường Đại học Công nghệ Thông tin\" role=\"presentation\" style=\"max-width:50%; height:fit-content;\">\n" +
                "<div style=\"color:blue;\">Tên món: {1}</div>\n" +
                "<div style=\"color:blue;\">Giá: {2}</div>\n" +
                "<div style=\"color:blue;\">Địa chi: {3}</div>\n" +
                "<br/>\n" +
                "<i>Chúc bạn ăn ngon miệng</i>\n" +
                "</div>\n" +
                "</div>\n" +
                "</body>",
                mimeEntity.ContentId, Name, Gia, DiaChi);
            MimeMessage mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("", from));
            mail.To.Add(new MailboxAddress("", to));
            mail.Subject = "Homnayangi";

            mail.Body = builder.ToMessageBody();


            SmtpClient smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate(from, pass);
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email sent successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void receiverTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
