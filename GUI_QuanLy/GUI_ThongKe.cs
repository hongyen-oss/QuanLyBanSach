using DAL_QuanLy;

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QuanLy
{
    public partial class GUI_ThongKe : Form
    {
        DAL_ThongKe dal = new DAL_ThongKe();

        // Khai báo 3 biểu đồ cho 3 Tab
        Chart chartKhachHang = new Chart();
        Chart chartDoanhThu = new Chart();
        Chart chartSach = new Chart();

        public GUI_ThongKe()
        {
            InitializeComponent();
            // Gọi hàm khởi tạo biểu đồ ngay khi mở Form
            KhoiTaoTatCaChart();
        }

        private void KhoiTaoTatCaChart()
        {
            // Gán chart vào đúng Panel nằm trong từng Tab
            SetupChart(chartSach, "Sách bán chạy", SeriesChartType.Column, pnlChartSach);
            SetupChart(chartDoanhThu, "Doanh thu", SeriesChartType.Line, pnlChartDT);
            SetupChart(chartKhachHang, "Chi tiêu khách hàng", SeriesChartType.Bar, pnlChartKH);
        }

        private void SetupChart(Chart chart, string seriesName, SeriesChartType type, Panel parentPanel)
        {
            chart.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);

            Series series = new Series(seriesName);
            series.ChartType = type;
            series.Palette = ChartColorPalette.BrightPastel;
            chart.Series.Add(series);

            chart.Legends.Add(new Legend("MainLegend"));

            // Đưa biểu đồ vào TabPage tương ứng
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(chart);
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            if (numTopSach.Items.Contains("Tất cả"))
            {
                numTopSach.SelectedItem = "Tất cả";
            }
            else
            {
                numTopSach.SelectedIndex = 0;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = dtpTuNgay.Value.Date;
                DateTime den = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                int topSach = 70;

                if (numTopSach.SelectedItem != null)
                {
                    string selectedValue = numTopSach.SelectedItem.ToString().Trim();

                    if (selectedValue != "Tất cả")
                    {
                        topSach = Convert.ToInt32(selectedValue);
                    }
                }
                DataTable dtSach = dal.LaySachBanChay(topSach, tu, den);
                dgvSach.DataSource = dtSach;

                FillDataToChart(chartSach, "Sách bán chạy", dtSach, "TenSach", "TongSoLuongBan", pnlChartSach);

               

                DataTable dtDT = dal.LayDoanhThuTheoNgay(tu, den);
                dgvDoanhThu.DataSource = dtDT;
               
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dtDT.Rows)
                {
                    if (row["TongTien"] != DBNull.Value)
                    {
                        tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                    }
                }
                lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + " VNĐ";

                FillDataToChart(chartDoanhThu, "Doanh thu", dtDT, "Ngay", "TongTien", pnlChartDT);


                // thống kê Khách Hàng
                DataTable dtKH = dal.LayTopKhachHang(tu, den);
                dgvKhachHang.DataSource = dtKH;
                FillDataToChart(chartKhachHang, "Chi tiêu khách hàng", dtKH, "HoTen", "TongChiTieu", pnlChartKH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FillDataToChart(Chart chart, string seriesName, DataTable dt, string xField, string yField, Panel parentPanel)
        {
            if (dt.Columns.Contains(yField))
            {
                chart.Series[seriesName].Points.Clear();
                foreach (DataRow r in dt.Rows)
                {
                    chart.Series[seriesName].Points.AddXY(r[xField].ToString(), r[yField]);
                }

                chart.Dock = DockStyle.Fill;
                if (!parentPanel.Controls.Contains(chart))
                {
                    parentPanel.Controls.Add(chart);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlChartDT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
