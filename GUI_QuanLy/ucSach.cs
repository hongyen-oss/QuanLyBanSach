using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                // Khi bấm vào con, nó sẽ tự động kích hoạt sự kiện Click của cha (thẻ ucSach)
                c.Click += (s, e) => { this.OnClick(e); };
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void DoDuLieu(string maSach, string tenSach, string gia, string tenFileAnh)

        {
            this.Tag = maSach;

            lblTenSach.Text = tenSach;

            lblGiaBan.Text = gia + " VNĐ";



            string path = Path.Combine(Application.StartupPath, "Images", tenFileAnh);

            if (File.Exists(path))

            {

                picAnhSach.Image = Image.FromFile(path);

                picAnhSach.SizeMode = PictureBoxSizeMode.Zoom;

            }

        }

        private void lblTenSach_Click(object sender, EventArgs e)
        {

        }

        private void picAnhSach_Click(object sender, EventArgs e)
        {

        }

        private void ucSach_Load(object sender, EventArgs e)
        {

        }
    }
}
