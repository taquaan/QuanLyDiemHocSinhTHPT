using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiemHocSinhTHPT
{
    public partial class FrmDangNhap : Form
    {
        // Class to store all user information
        public class UserInfo
        {
            public string Username { get; set; }
            public string Usercode { get; set; }  
            public string Role { get; set; }      
            public string Teachercode { get; set; }     
        }

        // Static property to hold logged-in user information
        public static UserInfo LoggedInUser { get; private set; }
        
        private SqlConnection connection;

        public FrmDangNhap()
        {
            InitializeComponent();
            connection = new SqlConnection("YourConnectionStringHere"); // Set your connection string here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (CheckLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckLogin(string username, string password)
        {
            using (SqlConnection conn = connection)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TenDangNhap, MaTaiKhoan, VaiTro, MaGiaoVien FROM Hethong WHERE TenDangNhap = @Username AND MatKhau = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate LoggedInUser with all data from the entry
                                LoggedInUser = new UserInfo
                                {
                                    Username = reader["TenDangNhap"].ToString(),
                                    Usercode = reader["MaTaiKhoan"].ToString(),
                                    Role = reader["VaiTro"].ToString(),
                                    Teachercode = reader["MaGiaoVien"].ToString(),
                                };

                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
