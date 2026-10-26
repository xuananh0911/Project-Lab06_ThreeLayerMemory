namespace Lab06_ThreeLayerMemory
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public string DanhMuc { get; set; }

        // Thành tiền (Tổng giá trị hàng tồn của sản phẩm này)
        public double ThanhTien => SoLuong * DonGia;

        public SanPham() { }

        public SanPham(string maSP, string tenSP, int soLuong, double donGia, string danhMuc = "Điện thoại")
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            DonGia = donGia;
            DanhMuc = danhMuc;
        }
    }
}