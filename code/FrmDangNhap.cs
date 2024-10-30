using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDiemHocSinhTHPT
{
    public partial class FrmDangNhap : Form
    {
        // Kết nối SQL đã được khai báo trước đó
        private SqlConnection connection;

        public FrmDangNhap()
        {
            InitializeComponent();
            // Thiết lập chuỗi kết nối SQL Server
            connection = new SqlConnection("");
        }

        // Sự kiện khi nhấn nút "Đăng Nhập"
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Gọi hàm kiểm tra thông tin đăng nhập từ SQL Server
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;  // Đăng nhập thành công, trả về DialogResult OK
                this.Close();  // Đóng form đăng nhập khi thành công
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm kiểm tra thông tin đăng nhập từ SQL Server
        private bool CheckLogin(string username, string password)
        {
            // Sử dụng chuỗi kết nối từ biến connection
            using (SqlConnection conn = connection)
            {
                try
                {
                    // Mở kết nối SQL
                    conn.Open();

                    // Câu lệnh SQL để kiểm tra thông tin đăng nhập
                    string query = "SELECT COUNT(*) FROM Hethong WHERE TenDangNhap = @Username AND MatKhau = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Thực thi câu lệnh SQL và kiểm tra kết quả
                        int result = (int)cmd.ExecuteScalar();
                        return result > 0;  // Nếu tìm thấy entry phù hợp, trả về true
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
