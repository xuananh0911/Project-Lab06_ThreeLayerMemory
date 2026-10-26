========================================================================

BÁO CÁO THỰC HÀNH LAB 06 - DATAGRIDVIEW, LISTVIEW, TREEVIEW VÀ MÔ HÌNH 3 LỚP

========================================================================



THÔNG TIN SINH VIÊN:

- Họ và tên: Nguyễn Xuân Anh

- Mã sinh viên: 24001333

- Tên dự án: Lab06_ThreeLayerMemory

- Môi trường: Visual Studio 2022 / .NET Framework / C# Windows Forms

- Học phần: Lập trình .NET (IT3212) - Bộ môn Công nghệ Phần mềm



------------------------------------------------------------------------

1. TỔNG QUAN DỰ ÁN

------------------------------------------------------------------------

Dự án Lab06_ThreeLayerMemory được xây dựng nhằm thiết kế ứng dụng Windows Forms

quản lý dữ liệu phân cấp, kết hợp các Control hiển thị nâng cao (DataGridView, 

ListView, TreeView, ContextMenuStrip, ImageList) và áp dụng kiến trúc chuẩn 3 lớp 

(3-Layer Architecture: GUI - BUS - DAL) chạy hoàn toàn trong bộ nhớ RAM kết hợp 

lưu trữ tệp văn bản CSV.



Mô hình tách biệt hoàn toàn trách nhiệm:

- GUI (Form): Chỉ đảm nhận việc nhận dữ liệu từ người dùng và hiển thị giao diện.

- BUS (Business Logic Layer): Kiểm tra các ràng buộc nghiệp vụ (rỗng, trùng mã, điểm/giá hợp lệ, tính toán tổng tiền).

- DAL (Data Access Layer): Quản lý lưu trữ dữ liệu tạm thời trong bộ nhớ và tự động Đọc/Ghi file CSV.



------------------------------------------------------------------------

2. CHI TIẾT 10 BÀI TẬP ĐÃ HOÀN THÀNH

------------------------------------------------------------------------

[Bài 1]: Hiển thị BindingList trên DataGridView

         - Khởi tạo danh sách BindingList<SinhVien> liên kết trực tiếp với DataGridView 

           giúp bảng tự động cập nhật dữ liệu tức thì.



[Bài 2]: Thao tác CRUD (Thêm, Sửa, Xóa) trong bộ nhớ

         - Thực hiện thao tác Quản lý Sinh viên linh hoạt trên danh sách bộ nhớ RAM 

           thông qua giao diện Form.



[Bài 3]: Danh sách chi tiết bằng ListView

         - Hiển thị thông tin sinh viên dưới dạng cột (Details View) trên ListView, 

           hỗ trợ click chọn dòng để lấy dữ liệu.



[Bài 4]: Cây Khoa - Sinh viên bằng TreeView

         - Tổ chức dữ liệu dạng cây phân cấp: Node gốc là Khoa, Node con là Sinh viên.

         - Lưu trữ đối tượng dữ liệu trong thuộc tính .Tag của TreeNode.



[Bài 5]: Tách mô hình 3 lớp giả lập (GUI - BUS - DAL)

         - Đóng gói toàn bộ xử lý lưu trữ vào SinhVienDAL, kiểm tra lỗi nghiệp vụ 

           vào SinhVienBUS, giúp Form không thao tác trực tiếp với kho dữ liệu.



[Bài 6]: Quản lý Sản phẩm bằng DataGridView

         - Xây dựng Form Quản lý Sản phẩm (frmQuanLySanPham) cho phép Thêm, Sửa, Xóa, 

           Tìm kiếm theo tên/mã, Sắp xếp tăng/giảm theo giá và tự động tính Tổng 

           giá trị hàng tồn kho (Số lượng * Đơn giá).



[Bài 7]: TreeView Quản lý Danh mục với ContextMenuStrip

         - Cây Danh mục - Sản phẩm hỗ trợ Menu ngữ cảnh Chuột phải (ContextMenuStrip) 

           để Thêm danh mục con, Đổi tên Node và Xóa Node.



[Bài 8]: ListView có biểu tượng ImageList

         - Thiết lập ImageList vẽ trực tiếp màu sắc biểu tượng đại diện cho Xếp loại 

           học tập của Sinh viên (Giỏi - Xanh lá, Khá - Xanh dương, TB - Cam).



[Bài 9]: Xuất/Đọc dữ liệu tệp văn bản CSV

         - Tích hợp vào SinhVienDAL và SanPhamDAL cơ chế tự động đọc dữ liệu từ tệp 

           `SinhVien.csv` & `SanPham.csv` khi khởi động và ghi lại mỗi khi thay đổi.



[Bài 10]: Hoàn thiện Kiến trúc 3 lớp

          - Chuẩn hóa toàn bộ cấu trúc dự án, đảm bảo Form (GUI) hoàn toàn không 

            chứa logic tính toán hay xử lý tệp tin.



------------------------------------------------------------------------

3. CẤU TRÚC NGUỒN TRONG SOLUTION (LAB06_THREELAYERMEMORY)

------------------------------------------------------------------------

Lab06_ThreeLayerMemory/

├── Models/

│   ├── SinhVien.cs             : Class đối tượng dữ liệu Sinh viên (kèm thuộc tính XepLoai)

│   └── SanPham.cs              : Class đối tượng dữ liệu Sản phẩm (kèm thuộc tính ThanhTien)

├── DAL/

│   ├── SinhVienDAL.cs          : Đọc/Ghi dữ liệu Sinh viên & lưu tệp SinhVien.csv

│   └── SanPhamDAL.cs           : Đọc/Ghi dữ liệu Sản phẩm & lưu tệp SanPham.csv

├── BUS/

│   ├── SinhVienBUS.cs          : Logic kiểm tra nghiệp vụ Sinh viên

│   └── SanPhamBUS.cs           : Logic nghiệp vụ Sản phẩm, Tính tổng tồn kho, Tìm kiếm, Sắp xếp

├── GUI/

│   ├── frmQuanLySinhVien.cs    : Form Quản lý Sinh viên (Bài 1, 2, 3, 4, 5, 8, 9)

│   └── frmQuanLySanPham.cs     : Form Quản lý Sản phẩm (Bài 6, 7)

├── Program.cs                  : Điểm khởi chạy ứng dụng

└── README.txt                  : Báo cáo thực hành chi tiết



------------------------------------------------------------------------

4. HƯỚNG DẪN BIÊN DỊCH VÀ CHẠY ỨNG DỤNG

------------------------------------------------------------------------

1. Mở file solution Lab06_ThreeLayerMemory.sln trong Visual Studio 2022.

2. Nhấn Ctrl + Shift + B để Rebuild Solution (Đảm bảo 0 Error).

3. Chuyển đổi màn hình chạy trong file `Program.cs`:

   - Chạy Quản lý Sản phẩm: Application.Run(new frmQuanLySanPham());

   - Chạy Quản lý Sinh viên: Application.Run(new frmQuanLySinhVien());

4. Nhấn F5 để chạy ứng dụng.

========================================================================