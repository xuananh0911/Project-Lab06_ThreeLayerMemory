using System;

namespace Lab06_ThreeLayerMemory
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        // Bổ sung thuộc tính tự động tính xếp loại để gán Icon (Bài 8)
        public string XepLoai
        {
            get
            {
                if (DiemTB >= 8.0) return "Giỏi";
                if (DiemTB >= 6.5) return "Khá";
                return "Trung bình";
            }
        }

        public SinhVien() { }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB, string khoa = "Công nghệ thông tin")
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiemTB = diemTB;
            Khoa = khoa;
        }
    }
}