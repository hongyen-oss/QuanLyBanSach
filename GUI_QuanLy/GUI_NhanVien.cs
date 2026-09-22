using BUS_QuanLy; 
using DTO_QuanLy; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI_QuanLy
{
    public partial class GUI_NhanVien : Form
    {
        private int userRole;
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_NhanVien(int role)
        {
            InitializeComponent();
            this.userRole = role;
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();

            cboCaTruc.Items.Clear();

            cboCaTruc.Items.Add("Ca 1");
            cboCaTruc.Items.Add("Ca 2");
            cboCaTruc.Items.Add("Ca 3");

            cboCaTruc.SelectedIndex = -1;

            if (userRole == 2)
            {
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
        }
        void LoadData()
        {
            dgvNV.DataSource = busNV.getNhanVien();

            dgvNV.Columns[0].HeaderText = "Mã NV";
            dgvNV.Columns[1].HeaderText = "Họ Tên";
            dgvNV.Columns[2].HeaderText = "Số Điện Thoại";
            dgvNV.Columns[3].HeaderText = "Ca Trực";
            dgvNV.Columns[4].HeaderText = "Gmail";
            dgvNV.Columns[5].HeaderText = "Địa chỉ";

        }
        // XEM
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // THÊM
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV.Text != "" && txtSDTnv.Text != "" && cboCaTruc.SelectedIndex != -1)
            {
                DTO_NhanVien nv = new DTO_NhanVien(0, txtHoTenNV.Text, txtSDTnv.Text, cboCaTruc.Text, txtGmail.Text, txtDiaChi.Text);

                if (busNV.themNhanVien(nv))
                {
                    int maNVVuaTao = busNV.LayMaNVCuoiCung();

                    FormTaiKhoanNV f = new FormTaiKhoanNV(maNVVuaTao);
                    f.ShowDialog(); 

                    MessageBox.Show("Thêm nhân viên và tạo tài khoản thành công!");
                    LoadData();
                   
                    txtHoTenNV.Clear();
                    cboCaTruc.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn Ca trực!");
            }
        }
        // SỦA
        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (txtMaNV.Text != "")
                {
                    int ma = int.Parse(txtMaNV.Text);
                    DTO_NhanVien nv = new DTO_NhanVien(ma, txtHoTenNV.Text, txtSDTnv.Text, cboCaTruc.Text, txtGmail.Text, txtDiaChi.Text);

                    if (busNV.suaNhanVien(nv))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (txtMaNV.Text != "")
                {
                    int ma = int.Parse(txtMaNV.Text);
                    if (busNV.xoaNhanVien(ma))
                    {
                        MessageBox.Show("Đã xóa nhân viên!");
                        LoadData();
                    }
                }
            }
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTenNV.Text = row.Cells[1].Value.ToString();
                txtSDTnv.Text = row.Cells[2].Value.ToString();
                cboCaTruc.Text = row.Cells[3].Value.ToString();
                txtGmail.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
            }

        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoTenNV.Text = row.Cells[1].Value.ToString();
                txtSDTnv.Text = row.Cells[2].Value.ToString();
                cboCaTruc.Text = row.Cells[3].Value.ToString();
                txtGmail.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
