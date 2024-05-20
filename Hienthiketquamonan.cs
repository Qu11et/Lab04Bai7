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
    public partial class Hienthiketquamonan : Form
    {
        private Control _selectedControl;
        public Hienthiketquamonan(Control selectedControl)
        {
            InitializeComponent();
            _selectedControl = selectedControl;
            flowLayoutPanel1.Controls.Add(selectedControl);
        }

        //send an email to the user            
        private void inviteBtn_Click(object sender, EventArgs e)
        {
            if (EmailSetting.username == null)
            {
                MessageBox.Show("Please set up your email first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Invite invite = new Invite(_selectedControl);
                invite.ShowDialog();
                this.Close();
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            EmailSetting emailSetting = new EmailSetting();
            emailSetting.ShowDialog();
            this.Close();
        }
    }
}
