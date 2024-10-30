-- Truyền dữ liệu cho các bảng
use QuanLyDiemHocSinhTHPT

-- Bảng Lop
INSERT INTO Lop (MaLop, TenLop, Khoa)
VALUES
(1, '12A1', '2023-2024'),
(2, '12A2', '2023-2024'),
(3, '11A1', '2023-2024'),
(4, '10B1', '2023-2024');

-- Bảng HocSinh
INSERT INTO HocSinh (MaHocSinh, HoTen, NgaySinh, GioiTinh, MaLop, DiaChi, SoDienThoaiPhuHuynh)
VALUES
(1, 'Nguyen Van A', '2006-05-15', 'Nam', 1, '123 Main St', '0901234567'),
(2, 'Tran Thi B', '2006-07-21', 'Nữ', 1, '456 Second St', '0909876543'),
(3, 'Le Van C', '2007-03-12', 'Nam', 2, '789 Third St', '0912345678'),
(4, 'Pham Thi D', '2008-09-30', 'Nữ', 3, '321 Fourth St', '0923456789');

-- Bảng MonHoc
INSERT INTO MonHoc (MaMonHoc, TenMonHoc)
VALUES
(1, 'Toán'),
(2, 'Văn'),
(3, 'Anh'),
(4, 'Hóa Học'),
(5, 'Sinh Học');

-- Bảnh HocKy
INSERT INTO HocKy (TenHocKy, NamHoc)
VALUES
('Học kỳ 1', '2023-2024'),
('Học kỳ 2', '2023-2024'),
('Học kỳ 1', '2024-2025'),
('Học kỳ 2', '2024-2025');

-- Bảng Diem
INSERT INTO Diem (DiemGiuaKy, DiemCuoiKy, MaHocSinh, MaMonHoc, MaHocKy)
VALUES
(7.5, 8.0, 1, 1, 1),
(8.5, 9.0, 2, 2, 1),
(6.0, 7.0, 3, 3, 2),
(9.0, 9.5, 4, 1, 1);

-- Bảng GiaoVien
INSERT INTO GiaoVien (MaGiaoVien, HoTenGiaoVien, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, MaMonHoc)
VALUES
(1, 'admin', '2000-10-01', 'Nam', '0912345678', 'admin@school.edu', '101 Teacher St', 1);

-- Bảng TaiKhoanGiaoVien
INSERT INTO TaiKhoanGiaoVien (TenDangNhap, MatKhau, VaiTro, MaGiaoVien)
VALUES
('admin', 'admin12345', 'GiaoVien', 1)

-- Thêm dữ liệu vào bảng GiaoVien
INSERT INTO GiaoVien (MaGiaoVien, HoTenGiaoVien, NgaySinh, GioiTinh, SoDienThoai, Email, DiaChi, MaMonHoc)
VALUES
(2, 'Nguyen Thi Lan', '1985-02-15', 'Nữ', '0901112223', 'lan.nguyen@school.edu', '123 Teacher Ave', 2),
(3, 'Tran Van Hoa', '1979-06-30', 'Nam', '0903334445', 'hoa.tran@school.edu', '456 Teacher Blvd', 3),
(4, 'Le Thi Kim', '1990-11-05', 'Nữ', '0905556667', 'kim.le@school.edu', '789 Teacher Dr', 4),
(5, 'Pham Van Dung', '1987-08-21', 'Nam', '0907778889', 'dung.pham@school.edu', '101 Teacher Ln', 5);

-- Thêm dữ liệu vào bảng TaiKhoanGiaoVien
INSERT INTO TaiKhoanGiaoVien (TenDangNhap, MatKhau, VaiTro, MaGiaoVien)
VALUES
('lan.nguyen', 'password123', 'GiaoVien', 2),
('hoa.tran', 'password456', 'GiaoVien', 3),
('kim.le', 'password789', 'GiaoVien', 4),
('dung.pham', 'password012', 'GiaoVien', 5);
