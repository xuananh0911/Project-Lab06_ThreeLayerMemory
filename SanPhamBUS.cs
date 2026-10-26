using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06_ThreeLayerMemory
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL _dal = new SanPhamDAL();

        public List<SanPham> GetAll() => _dal.GetAll();

        // Tính tổng giá trị hàng tồn kho (Bài 6)
        public double TinhTongGiaTriHangTon()
        {
            return _dal.GetAll().Sum(x => x.ThanhTien);
        }

        public void Add(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.SoLuong < 0)
                throw new ArgumentException("Số lượng không được nhỏ hơn 0!");
            if (sp.DonGia < 0)
                throw new ArgumentException("Đơn giá không được nhỏ hơn 0!");
            if (_dal.GetAll().Any(x => x.MaSP.Equals(sp.MaSP, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Mã sản phẩm đã tồn tại!");

            _dal.Add(sp);
        }

        public void Update(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.SoLuong < 0 || sp.DonGia < 0)
                throw new ArgumentException("Số lượng và Đơn giá phải lớn hơn hoặc bằng 0!");

            _dal.Update(sp);
        }

        public void Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Mã sản phẩm không hợp lệ!");

            _dal.Delete(maSP);
        }

        // Tìm kiếm sản phẩm theo tên (Bài 6)
        public List<SanPham> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return GetAll();
            return _dal.GetAll()
                       .Where(x => x.TenSP.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                   x.MaSP.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                       .ToList();
        }

        // Sắp xếp sản phẩm (Bài 6)
        public List<SanPham> SapXep(bool theoGiaTangDan)
        {
            return theoGiaTangDan ? _dal.GetAll().OrderBy(x => x.DonGia).ToList()
                                  : _dal.GetAll().OrderByDescending(x => x.DonGia).ToList();
        }
    }
}