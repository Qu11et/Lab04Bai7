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
            pass = "ibeppdtnqthusekh";
            //content = txtContent.Text;

            // Get the selected control from the flowLayoutPanel1
            Hienthimonan selectedControl = (Hienthimonan)flowLayoutPanel1.Controls[0];
            
            // Get the name of the dish from the selected control
            string monAn = selectedControl.MonAnName;
            //Image hinhAnh = selectedControl.MonAnImage;
            

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Homnayangi";
            mail.Body = monAn;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;                                                          
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass); //from: gmail of sender, pass: password gmail of sender
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
