-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyDiemHocSinhTHPT;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE QuanLyDiemHocSinhTHPT;
GO

-- Bảng Lop (Thông tin về lớp học)
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,             -- Tên lớp (VD: "12A1")
    Khoa NVARCHAR(20) NOT NULL                -- Khóa học
);
GO

-- Bảng HocSinh (Thông tin học sinh)
CREATE TABLE HocSinh (
    MaHocSinh INT PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,             -- Họ và tên học sinh
    NgaySinh DATE NOT NULL,                   -- Ngày sinh
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN ('Nam', 'Nữ')) NOT NULL, -- Giới tính
    MaLop INT FOREIGN KEY REFERENCES Lop(MaLop),  -- Khóa ngoại liên kết đến bảng Lớp
    DiaChi NVARCHAR(255),                     -- Địa chỉ
    SoDienThoaiPhuHuynh NVARCHAR(15)          -- Số điện thoại phụ huynh
);
GO

-- Bảng MonHoc (Thông tin môn học)
CREATE TABLE MonHoc (
    MaMonHoc INT PRIMARY KEY,          -- Mã môn học tự tăng
    TenMonHoc NVARCHAR(100) NOT NULL          -- Tên môn học
);
GO

-- Bảng HocKy (Thông tin học kỳ)
CREATE TABLE HocKy (
    MaHocKy INT PRIMARY KEY IDENTITY(1,1),   -- Mã học kỳ tự tăng
    TenHocKy NVARCHAR(50) NOT NULL,          -- Tên học kỳ
    NamHoc NVARCHAR(20) NOT NULL             -- Năm học (VD: "2024-2025")
);
GO

-- Bảng Diem (Bảng điểm học sinh theo môn)
CREATE TABLE Diem (
    MaDiem INT PRIMARY KEY IDENTITY(1,1),      -- Mã bảng điểm tự tăng
    DiemGiuaKy DECIMAL(4, 2) CHECK (DiemGiuaKy BETWEEN 0 AND 10),   -- Điểm giữa kỳ
    DiemCuoiKy DECIMAL(4, 2) CHECK (DiemCuoiKy BETWEEN 0 AND 10),   -- Điểm cuối kỳ
    DiemTrungBinh AS (DiemGiuaKy * 0.4 + DiemCuoiKy * 0.6),         -- Điểm trung bình
    MaHocSinh INT FOREIGN KEY REFERENCES HocSinh(MaHocSinh),        -- Khóa ngoại liên kết đến học sinh
    MaMonHoc INT FOREIGN KEY REFERENCES MonHoc(MaMonHoc),           -- Khóa ngoại liên kết đến môn học
    MaHocKy INT FOREIGN KEY REFERENCES HocKy(MaHocKy)               -- Khóa ngoại liên kết đến học kỳ
);
GO

-- Bảng GiaoVien (Thông tin giáo viên)
CREATE TABLE GiaoVien (
    MaGiaoVien INT PRIMARY KEY,
    HoTenGiaoVien NVARCHAR(100) NOT NULL,     -- Họ và tên giáo viên
    NgaySinh DATE NOT NULL,                   -- Ngày sinh
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN ('Nam', 'Nữ')) NOT NULL, -- Giới tính
    SoDienThoai NVARCHAR(15),                 -- Số điện thoại
    Email VARCHAR(100),                       -- Email
    DiaChi NVARCHAR(255),                     -- Địa chỉ
    MaMonHoc INT FOREIGN KEY REFERENCES MonHoc(MaMonHoc)             -- Liên kết đến môn học
);
GO

-- Bảng TaiKhoanGiaoVien (Quản lý tài khoản giáo viên)
CREATE TABLE TaiKhoanGiaoVien (
    MaTaiKhoan INT PRIMARY KEY IDENTITY(1,1),   -- Mã tài khoản tự tăng
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,   -- Tên đăng nhập, duy nhất
    MatKhau NVARCHAR(255) NOT NULL,             -- Mật khẩu (nên lưu dạng mã hóa)
    VaiTro VARCHAR(20) CHECK (VaiTro IN ('Admin', 'GiaoVien')) NOT NULL,  -- Vai trò của tài khoản
    MaGiaoVien INT FOREIGN KEY REFERENCES GiaoVien(MaGiaoVien)            -- Liên kết đến giáo viên
);
GO
