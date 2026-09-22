# Hệ Thống Quản Lý Bán Sách (Book Store Management System)

Ứng dụng quản lý cửa hàng sách được xây dựng bằng C# WinForms và SQL Server theo mô hình kiến trúc 4 lớp (N-layer), hỗ trợ quản lý các hoạt động kinh doanh sách cho nhân viên và hoạt động mua sách của khách hàng.
### Nhóm: 11
### Thành viên:
* **Đỗ Trương Minh Anh** – 2354050002
* **Lý Quốc Bảo** – 2354050013
* **Võ Hồng Yến** – 2351010257
  
---

## Công Nghệ Sử Dụng

* **Frontend:** WinForms (C#) – Xây dựng giao diện người dùng trực quan.
* **Backend:** ASP.NET – Xử lý logic nghiệp vụ và kết nối dữ liệu.
* **Database:** SQL Server – Lưu trữ và quản lý toàn bộ cơ sở dữ liệu hệ thống.

---

## Cấu Trúc Hệ Thống (Mô Hình 4 Lớp)

Dự án được phân chia rõ ràng nhằm đảm bảo tính bảo trì, dễ mở rộng và tách biệt logic:
* **DTO (Data Transfer Object):** Chứa các lớp đối tượng ánh xạ với các bảng trong CSDL, đóng vai trò vận chuyển dữ liệu giữa các tầng.
* **DAL (Data Access Layer):** Lớp truy xuất dữ liệu, chứa các câu lệnh SQL và thực hiện các thao tác CRUD (Thêm, Xóa, Sửa, Truy vấn) với SQL Server.
* **BUS (Business Logic Layer):** Lớp xử lý nghiệp vụ trung tâm, thực hiện kiểm tra tính hợp lệ (Validation) và phân quyền trước khi truyền dữ liệu qua DAL.
* **GUI (Presentation Layer):** Lớp giao diện hiển thị thông tin và tiếp nhận tương tác từ người dùng.

---

## Các Chức Năng Chính

* **Quản lý sản phẩm:** Thêm, sửa, xóa, tìm kiếm thông tin sách và quản lý danh mục.
* **Quản lý kho:** Theo dõi số lượng tồn kho và cập nhật hàng hóa.
* **Quy trình đặt hàng & Giỏ hàng:** Xử lý các bước mua hàng của khách hàng.
* **Quản lý tài khoản & Phân quyền:** Phân chia chức năng cho Nhân viên và Khách hàng.
* **Theo dõi đơn hàng & Báo cáo thống kê:** Thống kê doanh thu, báo cáo tình hình kinh doanh và theo dõi trạng thái đơn hàng.

---

## Cơ Sở Dữ Liệu

* Thiết kế sơ đồ thực thể mối quan hệ (ERD).
* Sử dụng SQL Server để xây dựng và quản lý cơ sở dữ liệu.
* Sử dụng các Script SQL để tạo bảng, thiết lập khóa chính, khóa ngoại và các ràng buộc đảm bảo tính toàn vẹn dữ liệu và bảo mật thông tin.
