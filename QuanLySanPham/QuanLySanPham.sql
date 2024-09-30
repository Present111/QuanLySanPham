CREATE TABLE SanPham (
    MaSP NVARCHAR(50) PRIMARY KEY,       -- Mã sản phẩm là khóa chính
    TenSP NVARCHAR(255) NOT NULL,        -- Tên sản phẩm, không được để trống
    SoLuong INT NOT NULL,                -- Số lượng, không được để trống
    DonGia DECIMAL(18, 2) NOT NULL,      -- Đơn giá, không được để trống
    XuatXu NVARCHAR(100),                -- Xuất xứ sản phẩm
    NgayHetHan DATE                      -- Ngày hết hạn
);
INSERT INTO SanPham (MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan) VALUES 
(N'sp1', N'Sữa Chua Vinamilk', 10, 15000, N'Trung Quốc', '2013-08-15'),
(N'sp2', N'Kem Chiên', 12, 800, N'Lào', '2013-05-12'),
(N'sp3', N'Cá viên nướng', 100, 500, N'Việt Nam', '2013-07-30');