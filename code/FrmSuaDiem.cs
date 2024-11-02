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
  public partial class FrmSuaDiem : Form
  {
    private KetNoiCSDL kn = new KetNoiCSDL(); 
    public FrmSuaDiem()
    {
      InitializeComponent();
    }

    // LOAD DATA
    private void LoadData()
    {
      string sql = "SELECT * FROM Diem";
      DataTable dt = kn.Lay_Dulieu(sql); 
      dtaThongTin.DataSource = dt;
    }
    private void LoadMaHocSinh()
    {
      string sql = "SELECT MaHocSinh FROM HocSinh";
      DataTable dtHosInh = kn.Lay_Dulieu(sql);

      cboMaHocSinh.DataSource = dtHosInh;
      cboMaHocSinh.DisplayMember = "MaHocSinh"; 
      cboMaHocSinh.ValueMember = "MaHocSinh";
    }
    private void LoadHocKy()
    {
      string sql = "SELECT MaHocKy, TenHocKy FROM HocKy";
      DataTable dtHocKy = kn.Lay_Dulieu(sql);

      // Thêm 1 cột tạm thời để hiển thị tên cùng với mã  
      dtHocKy.Columns.Add("DisplayText", typeof(string));
      foreach (DataRow row in dtHocKy.Rows)
      {
        row["DisplayText"] = $"{row["TenHocKy"]} (Mã: {row["MaHocKy"]})";
      }

      cboHocKy.DataSource = dtHocKy;
      cboHocKy.DisplayMember = "DisplayText";
      cboHocKy.ValueMember = "MaHocKy";
    }
    private void LoadMon()
    {
      string sql = "SELECT MaMonHoc, TenMonHoc FROM MonHoc";
      DataTable dtMon = kn.Lay_Dulieu(sql);

      dtMon.Columns.Add("DisplayText", typeof(string));
      foreach (DataRow row in dtMon.Rows)
      {
        row["DisplayText"] = $"{row["TenMonHoc"]} (Mã: {row["MaMonHoc"]})";
      }

      cboMon.DataSource = dtMon;
      cboMon.DisplayMember = "DisplayText";
      cboMon.ValueMember = "MaMonHoc";
    }

    // VALIDATION
    private bool gradeisEmpty()
    {
      if (string.IsNullOrWhiteSpace(txtDiemGiuaKy.Text) || string.IsNullOrWhiteSpace(txtDiemCuoiKy.Text))
      {
        MessageBox.Show("Nhập cả điểm Giữa Kỳ và Cuối Kỳ.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return true;
      }
      return false;
    }

    private bool instanceExists()
    {
      string mahs = cboMaHocSinh.Text;
      string hocKy = cboHocKy.SelectedValue.ToString();
      string mon = cboMon.SelectedValue.ToString();

      string sql = $"SELECT COUNT(*) FROM Diem WHERE MaHocSinh = '{mahs}' AND MaHocKy = '{hocKy}' AND MaMonHoc = '{mon}'";
      DataTable dt = kn.Lay_Dulieu(sql);

      if (dt.Rows.Count > 0)
      {
        MessageBox.Show("Mã học sinh, học kỳ và môn học đã tồn tại. Vui lòng nhập lại.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return true;
      }
      return false;
    }

    // EVENT
    private void labelDashboard_Click(object sender, EventArgs e)
    {
      FrmDashboard dashboard = new FrmDashboard();
      dashboard.Show();
      this.Close();
    }

    private void FrmSuaDiem_Load(object sender, EventArgs e)
    {
      LoadData();
      LoadMaHocSinh();
      LoadHocKy();
      LoadMon();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (gradeisEmpty())
      {
        return;
      }
      if (instanceExists())
      {
        return;
      }

      string mahs = cboMaHocSinh.Text;
      string hocKy = cboHocKy.SelectedValue.ToString();
      string mon = cboMon.SelectedValue.ToString();
      float giuaKy = float.Parse(txtDiemGiuaKy.Text);
      float cuoiKy = float.Parse(txtDiemCuoiKy.Text);

      string sql = $"INSERT INTO Diem (DiemGiuaKy, DiemCuoiKy, MaHocSinh, MaMonHoc, MaHocKy) VALUES ('{giuaKy}', '{cuoiKy}', '{mahs}', '{mon}', '{hocKy}')";
      kn.ThucThi(sql);
      LoadData();
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (gradeisEmpty())
      {
        return;
      }

      string mahs = cboMaHocSinh.Text;
      string hocKy = cboHocKy.SelectedValue.ToString();
      string mon = cboMon.SelectedValue.ToString();
      float giuaKy = float.Parse(txtDiemGiuaKy.Text);
      float cuoiKy = float.Parse(txtDiemCuoiKy.Text);

      string sql = $"UPDATE Diem SET DiemGiuaKy = '{giuaKy}', DiemCuoiKy = '{cuoiKy}' WHERE MaHocSinh = '{mahs}' AND MaMonHoc = '{mon}' AND MaHocKy = '{hocKy}'"; ;
      kn.ThucThi(sql);
      LoadData();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      string mahs = cboMaHocSinh.Text;
      string hocKy = cboHocKy.SelectedValue.ToString();
      string mon = cboMon.SelectedValue.ToString();

      string sql = $"DELETE FROM Diem WHERE MaHocSinh = '{mahs}' AND MaMonHoc = '{mon}' AND MaHocKy = '{hocKy}'";
      kn.ThucThi(sql);
      LoadData();
    }
  }
}
