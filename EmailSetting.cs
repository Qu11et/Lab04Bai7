using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Bai7
{
    public partial class EmailSetting : Form
    {
        public EmailSetting()
        {
            InitializeComponent();
        }

        public static string username;
        public static string password;
        public static string nickname;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            password = passwordTxt.Text;
            nickname = nicknameTxt.Text;
            this.Close();
        }
    }


}
