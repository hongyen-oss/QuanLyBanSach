using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace GUI_QuanLy
{
    public partial class UC_Trahang : UserControl
    {
        int maHD;

        DAL_TraHang dalTra =
            new DAL_TraHang();

        public UC_Trahang(int mahd)
        {
            InitializeComponent();

            maHD = mahd;

            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            DataTable dt = dalTra.LayCTHoaDon(maHD);

            dgvSach.DataSource = dt;

            lblMaHD.Text =
                "Mã hóa đơn: " + maHD;

            decimal tong = 0;

            foreach (DataRow row in dt.Rows)
            {
                tong +=
                    Convert.ToDecimal(
                        row["ThanhTien"]
                    );
            }

            lblTongTien.Text =
                "Tổng hoàn: "
                + tong.ToString("N0")
                + " VNĐ";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hoamair@gmail.com");
                mail.To.Add("hoamair@gmail.com");

                mail.Subject = "Thông báo trả hàng";
                mail.Body = "Yêu cầu trả hàng từ tài khoản -ngthihong123-";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("hoamair@gmail.com", "cwce ffdi rfbe scoj");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("Yêu cầu trả hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void UC_Trahang_Load(object sender, EventArgs e)
        {

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn gửi yêu cầu trả hàng và hoàn tiền cho đơn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            try
            {
                decimal tongTien = 0;

                foreach (DataGridViewRow row in dgvSach.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["ThanhTien"].Value != null)
                    {
                        tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    }
                }
                int maTra = dalTra.TaoTraHang(maHD, txtLyDo.Text, tongTien);

                dalTra.CopyChiTietTra(maTra, maHD);

                MessageBox.Show("Đã gửi yêu cầu trả hàng thành công! Vui lòng chờ nhân viên tiếp nhận và xử lý.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1.instance.LoadControl(new UC_LichSuDonHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý gửi yêu cầu trả hàng: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
