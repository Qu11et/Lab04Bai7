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
        private void saveBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text;
            this.Close();
        }
    }


}
