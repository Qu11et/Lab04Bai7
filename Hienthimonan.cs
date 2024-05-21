﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Bai7
{
    public partial class Hienthimonan : UserControl
    {
        public Hienthimonan()
        {
            InitializeComponent();
        }

        public string MonAnName
        {
            get { return label1.Text; }
        }

        public Image MonAnImage
        {
            get { return pictureBox1.Image; }
        }
        public string GiaMonAn
        {
            get { return label5.Text; }
        }
        public string DiaChi
        {
            get { return label6.Text; }
        }

        public void Settenmonan(string s)
        {
            label1.Text = s;
        }
        public void Setgiamonan(string s)
        {
            label5.Text = s;
        }
        public void Setdiachi(string s)
        {
            label6.Text = s;
        }
        public void Setnguoidonggop(string s)
        {
            label7.Text = s;
        }
        public void SetPictureBox(PictureBox picturebox)
        {
            if (picturebox.Image != null)
            {
                pictureBox1.Image = (Image)picturebox.Image.Clone();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true; // Đảm bảo PictureBox được hiển thị
            }
        }
    }
}
