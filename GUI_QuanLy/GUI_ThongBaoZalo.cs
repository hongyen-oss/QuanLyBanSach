using BUS_QuanLy;
using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GUI_QuanLy
{
    public partial class GUI_ThongBaoZalo : Form
    {
        BUS_ThongBao busTB = new BUS_ThongBao();
        public GUI_ThongBaoZalo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GUI_ThongBaoZalo_Load(object sender, EventArgs e)
        {
            DataTable dt = busTB.LayTheLoai();

            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "TenTheLoai";

            cboTheLoai.DataSource = dt;
            cboTheLoai.SelectedIndex = -1;
        }

        private void btnGuiMoi_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvThongBao.Rows)
            {
                if (row.Cells["SDT"].Value != null && !row.IsNewRow)
                {
                    string sdt = row.Cells["SDT"].Value.ToString();
                    string noiDung = txtNoiDung.Text;

                    GuiTinZalo(sdt, noiDung);
                    count++;
                }
            }
            MessageBox.Show($"Gửi thành công {count} tin nhắn!");
        }
        private void GuiTinZalo(string sdt, string noiDung)
        {
            Console.WriteLine($"[MOCK ZALO] Đang gửi đến: {sdt} | Nội dung: {noiDung}");
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string theLoaiSelected = cboTheLoai.Text;
            if (string.IsNullOrEmpty(theLoaiSelected)) return;

            dgvThongBao.DataSource = busTB.GetKhachHangTheoTheLoai(theLoaiSelected);

            DataTable dtSach = busTB.LaySachMoiNhatTheoTheLoai(theLoaiSelected);

            cboChonSach.DataSource = null;

            if (dtSach != null && dtSach.Rows.Count > 0)
            {
                cboChonSach.DataSource = dtSach;
                cboChonSach.DisplayMember = "TenSach";
                cboChonSach.ValueMember = "MaSach";
            }
            else
            {
                MessageBox.Show("Không có sách nào trong thể loại này.");
            }
        }

        private async void btnGmail_Click(object sender, EventArgs e)
        {
            if (cboChonSach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sách!");
                return;
            }

            DataRowView dr = (DataRowView)cboChonSach.SelectedItem;
            string tenSach = dr["TenSach"].ToString();
            string gia = dr["GiaBan"].ToString();
            string moTa = dr["MoTa"].ToString();
            string thuMucGoc = Application.StartupPath;
            
            string tenFileAnh = dr["HinhAnh"].ToString(); 
            string duongDanDayDu = System.IO.Path.Combine(thuMucGoc, "Images", tenFileAnh);

            if (!System.IO.File.Exists(duongDanDayDu))
            {
                MessageBox.Show("Không tìm thấy ảnh tại: " + duongDanDayDu);
                return;
            }
            string noiDungMail = TaoNoiDungHtml(tenSach, gia, moTa);

            int count = 0;
            btnGmail.Enabled = false;

            bool timThayCotEmail = dgvThongBao.Columns.Contains("Email");

            foreach (DataGridViewRow row in dgvThongBao.Rows)
            {
                if (row.IsNewRow) continue;

                if (timThayCotEmail && row.Cells["Email"].Value != null)
                {
                    string emailNhan = row.Cells["Email"].Value.ToString();

                    if (!string.IsNullOrWhiteSpace(emailNhan))
                    {
                        try
                        {
                            await GuiMail(emailNhan, "Thông báo sách mới: " + tenSach, noiDungMail, duongDanDayDu);
                            count++;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Lỗi gửi: {ex.Message}");
                        }
                    }
                }
            }

            btnGmail.Enabled = true;
            MessageBox.Show($"Đã gửi thành công cho {count} khách hàng!");
        }
        private async Task GuiMail(string emailNhan, string tieuDe, string noiDung, string duongDanAnh)
        {
            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("abystore.system@gmail.com", "idun rdmi kzke ebjv");
                smtpClient.EnableSsl = true;

                using (var mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress("abystore.system@gmail.com");
                    mailMessage.Subject = tieuDe;
                    mailMessage.To.Add(emailNhan);

                    LinkedResource imageResource = new LinkedResource(duongDanAnh, "image/jpeg");
                    imageResource.ContentId = "AnhSach";

                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(noiDung, null, "text/html");
                    htmlView.LinkedResources.Add(imageResource);

                    mailMessage.AlternateViews.Add(htmlView);
                   
                    await smtpClient.SendMailAsync(mailMessage);
                }
            }
        }
        private string TaoNoiDungHtml(string tenSach, string gia, string moTa)
        {
            return $@"
        <div style='font-family: Arial;'>
            <h2>Thông báo sách mới về!</h2>
            <img src='cid:AnhSach' style='width: 200px;' />
            <h3>{tenSach}</h3>
            <p>Giá: {gia} VNĐ</p>
            <p>Mô tả: {moTa}</p>
        </div>";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedIndex == -1) return;

            // 1. Lấy sách mới nhất
            DataTable dtSach = busTB.LaySachMoiNhatTheoTheLoai(cboTheLoai.Text);

            if (dtSach.Rows.Count > 0)
            {
                DataRow dr = dtSach.Rows[0];
                string tenSach = dr["TenSach"].ToString();

                cboChonSach.Text = tenSach;

                txtNoiDung.Text = $"Thông báo với bạn, Sách mới về có thể bạn sẽ thích: {tenSach}.\r\n" +
                  $"Giá: {dr["GiaBan"]} VNĐ\r\n" +
                  $"Mô tả: {dr["MoTa"]}";
            }
        }
    }
}
