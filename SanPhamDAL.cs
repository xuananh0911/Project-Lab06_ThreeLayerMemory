using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab06_ThreeLayerMemory
{
    public class SanPhamDAL
    {
        private readonly List<SanPham> _data = new List<SanPham>();
        private readonly string _filePath = "SanPham.csv";

        public SanPhamDAL()
        {
            LoadFromFile();
        }

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
                        _data.Add(new SanPham(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            int.Parse(parts[2].Trim()),
                            double.Parse(parts[3].Trim()),
                            parts[4].Trim()
                        ));
                    }
                }
            }
            else
            {
                // Dữ liệu mẫu ban đầu
                _data.Add(new SanPham("SP01", "iPhone 15 Pro", 10, 25000000, "Điện thoại"));
                _data.Add(new SanPham("SP02", "Samsung Galaxy S24", 15, 21000000, "Điện thoại"));
                _data.Add(new SanPham("SP03", "MacBook Pro M3", 5, 45000000, "Laptop"));
                _data.Add(new SanPham("SP04", "Dell XPS 15", 8, 38000000, "Laptop"));
                _data.Add(new SanPham("SP05", "iPad Air 5", 12, 16000000, "Máy tính bảng"));
                SaveToFile();
            }
        }

        public void SaveToFile()
        {
            List<string> lines = new List<string>();
            foreach (var sp in _data)
            {
                lines.Add($"{sp.MaSP},{sp.TenSP},{sp.SoLuong},{sp.DonGia},{sp.DanhMuc}");
            }
            File.WriteAllLines(_filePath, lines, Encoding.UTF8);
        }

        public List<SanPham> GetAll() => new List<SanPham>(_data);

        public void Add(SanPham sp)
        {
            _data.Add(sp);
            SaveToFile();
        }

        public void Update(SanPham sp)
        {
            var item = _data.Find(x => x.MaSP == sp.MaSP);
            if (item != null)
            {
                item.TenSP = sp.TenSP;
                item.SoLuong = sp.SoLuong;
                item.DonGia = sp.DonGia;
                item.DanhMuc = sp.DanhMuc;
                SaveToFile();
            }
        }

        public void Delete(string maSP)
        {
            _data.RemoveAll(x => x.MaSP == maSP);
            SaveToFile();
        }
    }
}