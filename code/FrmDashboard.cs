using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemHocSinhTHPT
{
    public partial class FrmDashboard : Form
    {
        private KetNoiCSDL dbConnection;
        private bool isSidebarExpanded = false;
        private Timer timer;
        private const int MaxPanelWidth = 180;
        private const int MinPanelWidth = 0;

        public FrmDashboard()
        {
            InitializeComponent();
            dbConnection = new KetNoiCSDL();
            LoadKhoa();
            // Ensure event handlers are wired up
            DropKhoa.SelectedIndexChanged += new EventHandler(DropKhoa_SelectedIndexChanged);
            btnTimKiem.Click += new EventHandler(btnTimKiem_Click);
            btnMenuToggle.Click += new EventHandler(btnMenuToggle_Click);
            // Initialize Timer
            timer = new Timer();
            timer.Interval = 10; // Điều chỉnh khoảng thời gian cho hoạt động mượt mà
            timer.Tick += Timer_Tick;
            // Đăng ký sự kiện Load
            this.Load += new EventHandler(FrmDashboard_Load);
            // Đăng ký sự kiện Click cho btnQuanLyDiem
            btnQuanLyDiem.Click += new EventHandler(btnQuanLyDiem_Click);
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Khởi tạo trạng thái ban đầu của các nút và MenuPanel
            MenuPanel.Width = MinPanelWidth; // Đặt chiều rộng ban đầu của MenuPanel là tối thiểu
            btnThongTinGV.Visible = false;   // Đảm bảo các nút bị ẩn
            btnQuanLyDiem.Visible = false;
            btnHoTro.Visible = false;
            btnDangXuat.Visible = false;

            DropKhoa.Visible = false;
            DropLop.Visible = false;
            btnTimKiem.Visible = false;
            dgvHocSinh.Visible = false;
        }

        private void btnMenuToggle_Click(object sender, EventArgs e)
        {
            // Đảo ngược trạng thái của sidebar
            isSidebarExpanded = !isSidebarExpanded;
            // Bắt đầu timer để hoạt động mở hoặc đóng sidebar
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                // Mở rộng panel
                MenuPanel.Width += 10;
                if (MenuPanel.Width >= MaxPanelWidth)
                {
                    MenuPanel.Width = MaxPanelWidth;
                    timer.Stop();
                    btnThongTinGV.Visible = true;
                    btnQuanLyDiem.Visible = true;
                    btnHoTro.Visible = true;
                    btnDangXuat.Visible = true;
                }
            }
            else
            {
                // Thu hẹp panel
                MenuPanel.Width -= 10;
                if (MenuPanel.Width <= MinPanelWidth)
                {
                    MenuPanel.Width = MinPanelWidth;
                    timer.Stop();
                    btnThongTinGV.Visible = false;
                    btnQuanLyDiem.Visible = false;
                    btnHoTro.Visible = false;
                    btnDangXuat.Visible = false;
                }
            }
        }

        private void LoadKhoa()
        {
            string query = "SELECT DISTINCT Khoa FROM Lop";
            DataTable dataTable = dbConnection.Lay_Dulieu(query);
            foreach (DataRow row in dataTable.Rows)
            {
                DropKhoa.Items.Add(row["Khoa"].ToString());
            }
        }

        private void DropKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropLop.Items.Clear();
            string selectedKhoa = DropKhoa.SelectedItem.ToString();
            // If Khoa is a string, enclose it in quotes
            string query = $"SELECT MaLop, TenLop FROM Lop WHERE Khoa = '{selectedKhoa}'";
            DataTable dataTable = dbConnection.Lay_Dulieu(query);
            foreach (DataRow row in dataTable.Rows)
            {
                DropLop.Items.Add(new KeyValuePair<string, string>(row["MaLop"].ToString(), row["TenLop"].ToString()));
            }
            DropLop.DisplayMember = "Value";
            DropLop.ValueMember = "Key";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (DropLop.SelectedItem != null)
            {
                string selectedLop = ((KeyValuePair<string, string>)DropLop.SelectedItem).Key;
                string query = $@"
                    SELECT hs.MaHocSinh, hs.HoTen, hs.NgaySinh, hs.GioiTinh, hs.DiaChi, hs.SoDienThoaiPhuHuynh, lop.TenLop, diem.DiemGiuaKy, diem.DiemCuoiKy, diem.DiemTrungBinh
                    FROM HocSinh hs
                    JOIN Lop lop ON hs.MaLop = lop.MaLop
                    LEFT JOIN Diem diem ON hs.MaHocSinh = diem.MaHocSinh
                    WHERE hs.MaLop = '{selectedLop}'";

                DataTable dataTable = dbConnection.Lay_Dulieu(query);
                dgvHocSinh.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please select a class (Lop).");
            }
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            // Ẩn sidebar menu
            MenuPanel.Width = MinPanelWidth;
            btnThongTinGV.Visible = false;
            btnQuanLyDiem.Visible = false;
            btnHoTro.Visible = false;
            btnDangXuat.Visible = false;

            // Hiển thị các điều khiển liên quan đến quản lý điểm
            DropKhoa.Visible = true;
            DropLop.Visible = true;
            btnTimKiem.Visible = true;
            dgvHocSinh.Visible = true;

            // Load dữ liệu cho DropKhoa nếu cần
            LoadKhoa();
        }
    }
}