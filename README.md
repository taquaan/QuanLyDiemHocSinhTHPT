# Phần mềm Quản lý học sinh THPT 
## Hướng dẫn thiết lập:
1. Tiến hành tạo một Database, copy và chạy lần lượt nội dung trong các file: [Tables.sql](https://github.com/taquaan/QuanLyDiemHocSinhTHPT/blob/main/Tables.sql) -> [Data.sql](https://github.com/taquaan/QuanLyDiemHocSinhTHPT/blob/main/Data.sql)
2. Copy Server Name trên SQL Server và gán giá trị này cho biến **strKetNoi -> Data Source** trong file [KetNoiCSDL.cs](https://github.com/taquaan/QuanLyDiemHocSinhTHPT/blob/main/code/KetNoiCSDL.cs)

   ```csharp
    string strKetNoi = @"Data Source=<data-source>;Initial Catalog=QuanLyDiemHocSinhTHPT;Integrated Security=True";
    ```
3. Đăng nhập với tài khoản (lưu trong file [Data.sql](https://github.com/taquaan/QuanLyDiemHocSinhTHPT/blob/main/Data.sql))
   - Tên đăng nhập: admin
   - Mật khẩu: admin12345
