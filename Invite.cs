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
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Runtime.InteropServices;
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
            string from, to, pass;
            from = EmailSetting.username;
            to = receiverTxt.Text.Trim();
            pass = "ibeppdtnqthusekh";

            // Get the selected control from the flowLayoutPanel1
            Hienthimonan selectedControl = (Hienthimonan)flowLayoutPanel1.Controls[0];

            // Get the name of the dish from the selected control
            string monAn = selectedControl.MonAnName;
            System.Drawing.Image hinhAnh = selectedControl.MonAnImage;

            // Convert the image to a base64 string
            string base64Image = "";
            using (MemoryStream ms = new MemoryStream())
            {
                hinhAnh.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                base64Image = Convert.ToBase64String(imageBytes);
            }

            // Create the HTML content
            string htmlContent = $@"
    <!DOCTYPE html>
<html>

<head>
    <meta charset=""utf-8"">
    <title>TechMath</title>
    <style>
        header {{
            background-color: cyan;
            text-align: center;
            border-style: solid;
            border-width: 20px;
            border-radius: 25px;
            border-color: blue;
        }}

        #pagebody {{
            width: calc(100% / 2);
            height: fit-content;
            background-color: rgb(253, 253, 218);
            border-style: solid;
            border-color: black;
            border-width: 1px;
            border-radius: 25px;
            box-shadow: rgb(165, 165, 165) -5px 5px;
            margin: 10px auto 10px auto;
            padding: 20px;
            text-align: center;
        }}

        #one_third_box {{
            width: calc(100% / 3 - 25px);
            height: fit-content;
            /*border-style: solid;*/
            margin-left: 25px;
        }}

        footer {{
            background-color: rgb(212, 212, 212);
            text-align: center;
            padding: 5px;
            font-family: serif;
            box-shadow: rgb(165, 165, 165) -5px 5px;
            border-radius: 5px;
        }}
    </style>
</head>

<body>
    <header>
        <p style=""color:rgb(255, 0, 0); font-size: 50px; text-shadow: 4px 4px yellow;""><b>NT106.O22.2</b></p>
        <p style=""font-size: 25px;"">Thực hành lập trình mạng căn bản</p>
        <p style=""font-size: 25px;"">Lab 5: Gửi và Nhận Mail trong C#</p>
    </header>

    <div id=""pagebody"">
        <h1>LỜI MỜI ĂN CÙNG</h1>
        <img src='data:image/jpeg;base64,{base64Image}' alt='{monAn}' />
        <h2>Tên món ăn: </h2>
        <h3>Giá món ăn: </h3>
        <h3>Địa chỉ: </h3>
        <h3>Người đóng góp: </h3>
        <h3>Mô tả: </h3>
    </div>

    <footer>
        <p style=""font-size: 25px;"">Thông tin chi tiết xin liên hệ 22521081@gm.uit.edu.vn</p>
    </footer>
</body>

</html>";

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Homnayangi";
            mail.Body = htmlContent;
            mail.IsBodyHtml = true; // Set to true to indicate that the body is HTML

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass); // from: gmail of sender, pass: password gmail of sender

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

    }
}
