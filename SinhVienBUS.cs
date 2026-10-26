using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06_ThreeLayerMemory
{
    public class SinhVienBUS
    {
        private readonly SinhVienDAL _dal = new SinhVienDAL();

        public List<SinhVien> GetAll() => _dal.GetAll();

        public void Add(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.MaSV))
                throw new ArgumentException("Mã sinh viên không được để trống!");

            if (string.IsNullOrWhiteSpace(sv.HoTen))
                throw new ArgumentException("Họ tên sinh viên không được để trống!");

            if (sv.DiemTB < 0 || sv.DiemTB > 10)
                throw new ArgumentException("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!");

            if (_dal.GetAll().Any(x => x.MaSV.Equals(sv.MaSV, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Trùng mã sinh viên! Mã này đã tồn tại trong hệ thống.");

            _dal.Add(sv);
        }

        public void Update(SinhVien sv)
        {
            if (string.IsNullOrWhiteSpace(sv.HoTen))
                throw new ArgumentException("Họ tên sinh viên không được để trống!");

            if (sv.DiemTB < 0 || sv.DiemTB > 10)
                throw new ArgumentException("Điểm trung bình phải từ 0 đến 10!");

            _dal.Update(sv);
        }

        public void Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new ArgumentException("Mã sinh viên không hợp lệ!");

            _dal.Delete(maSV);
        }
    }
}