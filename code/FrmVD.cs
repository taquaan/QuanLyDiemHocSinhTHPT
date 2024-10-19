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
  public partial class FrmVD : Form
  {
    private KetNoiCSDL kn = new KetNoiCSDL();
    public FrmVD()
    {
      InitializeComponent();
    }
    private void LoadData()
    {
      string sql = "SELECT * FROM HocSinh";
      DataTable dt = kn.Lay_Dulieu(sql);
      dataGridHocSinh.DataSource = dt;
    }
    private void FrmVD_Load(object sender, EventArgs e)
    {
      LoadData();
    }
    // Khi vừa load FormVD xong, data từ table HocSinh sẽ được truyền vào dataGrid
  }
}
