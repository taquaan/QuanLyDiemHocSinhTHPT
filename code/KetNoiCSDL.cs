using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemHocSinhTHPT
{
  class KetNoiCSDL
  {
    public SqlConnection cnn;
    public SqlCommand cmd;
    public DataTable dta;
    public SqlDataAdapter ada;

    public void KetNoi_Dulieu()
    {
      string strKetNoi = @"Data Source=LAPTOP-3OLPRLBL\SQLEXPRESS;Initial Catalog=QuanLyDiemHocSinhTHPT;Integrated Security=True";
      cnn = new SqlConnection(strKetNoi);
      cnn.Open();
    }

    public void HuyKetNoi_Dulieu()
    {
      if (cnn.State == ConnectionState.Open)
        cnn.Close();
    }

    public DataTable Lay_Dulieu(string Sql)
    {
      KetNoi_Dulieu();
      ada = new SqlDataAdapter(Sql, cnn);
      dta = new DataTable();
      ada.Fill(dta);
      return dta;
    }
    public void ThucThi(string sql)
    {
      KetNoi_Dulieu();
      cmd = new SqlCommand(sql, cnn);
      cmd.ExecuteNonQuery();
      HuyKetNoi_Dulieu();
    }
  }
}
