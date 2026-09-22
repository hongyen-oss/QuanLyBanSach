using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Linq;
using DAL_QuanLy;
using System.IO;


namespace GUI_QuanLy
{
    public partial class UC_GioHang : UserControl
    {
        private List<DTO_GioHang> dsMua;
        public UC_GioHang()
        {
            InitializeComponent();
            LoadGioHang();
        }
        private void LoadGioHang()
        {
            flowGioHang.Controls.Clear();

            DAL_GioHang dal = new DAL_GioHang();

            List<DTO_GioHang> ds = dal.LayGioHang(Session.Username);
            
            foreach (var item in ds)
            {
                Panel pn = new Panel();
                //  pn.Width = 750;
                pn.Width = 710;
                pn.Height = 130;
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                // CHECKBOX
                CheckBox chk = new CheckBox();
                chk.Left = 10;
                chk.Top = 50;
                chk.Width = 20;
                chk.Tag = item; 

                // ẢNH
                PictureBox pic = new PictureBox();
                pic.Left = 40;
                pic.Top = 10;
                pic.Width = 80;
                pic.Height = 100;
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                string duongDanAnh = Path.Combine(Application.StartupPath, "Images", item.HinhAnh
                );

                if (File.Exists(duongDanAnh))
                {
                    pic.Image =
                        Image.FromFile(duongDanAnh);
                }

                // TÊN SÁCH
                Label lblTen = new Label();
                lblTen.Text = item.TenSach;
                lblTen.Left = 140;
                lblTen.Top = 20;
                lblTen.Width = 250;

                // GIÁ
                Label lblGia = new Label();
                lblGia.Text = item.GiaBan.ToString("N0") + " VNĐ";
                lblGia.Left = 140;
                lblGia.Top = 50;
                lblGia.Width = 150;

                // NÚT -
                Button btnTru = new Button();
                btnTru.Text = "-";
                btnTru.Width = 30;
                btnTru.Height = 30;
                btnTru.Left = 450;
                btnTru.Top = 45;


                Label lblSL = new Label();
                lblSL.Text = item.SoLuong.ToString();
                lblSL.Left = 490;
                lblSL.Top = 52;
                lblSL.Width = 30;


                Button btnCong = new Button();
                btnCong.Text = "+";
                btnCong.Width = 30;
                btnCong.Height = 30;
                btnCong.Left = 530;
                btnCong.Top = 45;


                Label lblThanhTien = new Label();
                lblThanhTien.Text = item.ThanhTien.ToString("N0") + " VNĐ";
                lblThanhTien.Left = 600;
                lblThanhTien.Top = 50;
                lblThanhTien.Width = 150;


                Button btnXoa = new Button();
                btnXoa.Text = "Xóa";
                btnXoa.Left = 600;
                btnXoa.Top = 80;

                btnCong.Click += (s, e) =>
                {
                    item.SoLuong++;

                    DAL_GioHang dalGH =
                        new DAL_GioHang();

                    dalGH.CapNhatSoLuong(
                        Session.Username,
                        item.MaSach,
                        item.SoLuong
                    );

                    LoadGioHang();
                };

                btnTru.Click += (s, e) =>
                {
                    if (item.SoLuong > 1)
                    {
                        item.SoLuong--;

                        DAL_GioHang dalGH =
                            new DAL_GioHang();

                        dalGH.CapNhatSoLuong(
                            Session.Username,
                            item.MaSach,
                            item.SoLuong
                        );
                    }

                    LoadGioHang();
                };

                btnXoa.Click += (s, e) =>
                {
                    DAL_GioHang dalGH = new DAL_GioHang();

                    dalGH.XoaGioHang(
                        Session.Username,
                        item.MaSach
                    );

                    LoadGioHang();
                };

                chk.CheckedChanged += (s, e) =>
                {
                    TinhTongTien();
                };

                pn.Controls.Add(chk);
                pn.Controls.Add(pic);
                pn.Controls.Add(lblTen);
                pn.Controls.Add(lblGia);
                pn.Controls.Add(btnTru);
                pn.Controls.Add(lblSL);
                pn.Controls.Add(btnCong);
                pn.Controls.Add(lblThanhTien);
                pn.Controls.Add(btnXoa);

                flowGioHang.Controls.Add(pn);
            }

            TinhTongTien();
        }
        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (Panel pn in flowGioHang.Controls)
            {
                CheckBox chk = pn.Controls.OfType<CheckBox>().FirstOrDefault();

                if (chk != null && chk.Checked)
                {
                    Label lblTT = pn.Controls
                        .OfType<Label>()
                        .Last();

                    string text = lblTT.Text
                        .Replace("VNĐ", "")
                        .Replace(",", "")
                        .Trim();

                    tong += decimal.Parse(text);
                }
            }

            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }
        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowGioHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMuaHang_Click(object sender, EventArgs e)
       {
            List<DTO_GioHang> dsChon =
                new List<DTO_GioHang>();

            foreach (Panel pn in flowGioHang.Controls)
            {
                CheckBox chk =
                    pn.Controls
                    .OfType<CheckBox>()
                    .FirstOrDefault();

                if (chk != null && chk.Checked)
                {
                    DTO_GioHang item =
                        (DTO_GioHang)chk.Tag;

                    dsChon.Add(item);
                }
            }

            if (dsChon.Count == 0)
            {
                MessageBox.Show(
                    "Cảnh báo: Giỏ hàng đang trống!"
                );

                return;
            }

            Form1.instance.LoadControl(
                new UC_Donhang(dsChon)
            );
        }

        private void flowGioHang_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
