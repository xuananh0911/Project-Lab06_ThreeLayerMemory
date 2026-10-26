using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab06_ThreeLayerMemory
{
    public class SinhVienDAL
    {
        private readonly List<SinhVien> _data = new List<SinhVien>();
        private readonly string _filePath = "SinhVien.csv";

        public SinhVienDAL()
        {
            LoadFromFile();
        }

        // Bài 9: Đọc file CSV khi khởi động
        private void LoadFromFile()
        {
            _data.Clear();
            if (File.Exists(_filePath))
            {
                var lines = File.ReadAllLines(_filePath, Encoding.UTF8);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');
                    if (parts.Length >= 5)
                    {
                        string maSV = parts[0].Trim();
                        string hoTen = parts[1].Trim();
                        DateTime ngaySinh = DateTime.Parse(parts[2].Trim());
                        double diemTB = double.Parse(parts[3].Trim());
                        string khoa = parts[4].Trim();
                        _data.Add(new SinhVien(maSV, hoTen, ngaySinh, diemTB, khoa));
                    }
                }
            }
            else
            {
                // Dữ liệu mẫu khởi tạo lần đầu nếu chưa có file CSV
                _data.Add(new SinhVien("SV01", "Nguyễn Văn An", new DateTime(2004, 1, 15), 8.5, "Công nghệ thông tin"));
                _data.Add(new SinhVien("SV02", "Trần Thị Bình", new DateTime(2004, 5, 20), 7.0, "Công nghệ thông tin"));
                _data.Add(new SinhVien("SV03", "Lê Hoàng Cường", new DateTime(2004, 9, 10), 9.2, "Công nghệ thông tin"));

                _data.Add(new SinhVien("SV04", "Phạm Minh Dung", new DateTime(2004, 3, 12), 6.5, "Kinh tế"));
                _data.Add(new SinhVien("SV05", "Vũ Hoàng Giang", new DateTime(2004, 7, 25), 8.0, "Kinh tế"));
                _data.Add(new SinhVien("SV06", "Đỗ Hải Yến", new DateTime(2004, 11, 30), 9.0, "Kinh tế"));

                _data.Add(new SinhVien("SV07", "Ngoạn Văn Hải", new DateTime(2004, 2, 18), 7.8, "Ngoại ngữ"));
                _data.Add(new SinhVien("SV08", "Đặng Thu Hương", new DateTime(2004, 6, 14), 8.8, "Ngoại ngữ"));
                _data.Add(new SinhVien("SV09", "Nguyễn Xuân Anh", new DateTime(2006, 11, 9), 9.5, "Ngoại ngữ"));

                SaveToFile();
            }
        }

        // Bài 9: Ghi dữ liệu ra tệp CSV
        public void SaveToFile()
        {
            List<string> lines = new List<string>();
            foreach (var sv in _data)
            {
                lines.Add($"{sv.MaSV},{sv.HoTen},{sv.NgaySinh:yyyy-MM-dd},{sv.DiemTB},{sv.Khoa}");
            }
            File.WriteAllLines(_filePath, lines, Encoding.UTF8);
        }

        public List<SinhVien> GetAll() => new List<SinhVien>(_data);

        public void Add(SinhVien sv)
        {
            _data.Add(sv);
            SaveToFile();
        }

        public void Update(SinhVien sv)
        {
            var item = _data.Find(x => x.MaSV == sv.MaSV);
            if (item != null)
            {
                item.HoTen = sv.HoTen;
                item.NgaySinh = sv.NgaySinh;
                item.DiemTB = sv.DiemTB;
                item.Khoa = sv.Khoa;
                SaveToFile();
            }
        }

        public void Delete(string maSV)
        {
            _data.RemoveAll(x => x.MaSV == maSV);
            SaveToFile();
        }
    }
}