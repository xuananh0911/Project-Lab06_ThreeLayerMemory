using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab06_ThreeLayerMemory
{
    public partial class frmQuanLySinhVien : Form
    {
        private readonly SinhVienBUS _bus = new SinhVienBUS();
        private BindingList<SinhVien> _bindingList;
        private ImageList _imgListLoaiSV;

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Kinh tế", "Ngoại ngữ" });
            cboKhoa.SelectedIndex = 0;

            // Bài 8: Khởi tạo ImageList vẽ icon bằng code (không cần file ảnh bên ngoài)
            InitImageList();

            // Khởi tạo cột cho ListView
            lvSinhVien.SmallImageList = _imgListLoaiSV;
            lvSinhVien.Columns.Add("Mã SV", 100);
            lvSinhVien.Columns.Add("Họ tên", 200);
            lvSinhVien.Columns.Add("Ngày sinh", 110);
            lvSinhVien.Columns.Add("Điểm TB", 90);
            lvSinhVien.Columns.Add("Xếp loại", 100);
            lvSinhVien.Columns.Add("Khoa", 180);

            LoadDataAllControls();
        }

        // Bài 8: Hàm tạo ImageList màu sắc cho các loại sinh viên
        private void InitImageList()
        {
            _imgListLoaiSV = new ImageList();
            _imgListLoaiSV.ImageSize = new Size(16, 16);

            // Icon 0: Giỏi (Xanh lá)
            Bitmap bGioi = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bGioi)) g.Clear(Color.LightGreen);
            _imgListLoaiSV.Images.Add("Gioi", bGioi);

            // Icon 1: Khá (Xanh dương)
            Bitmap bKha = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bKha)) g.Clear(Color.LightSkyBlue);
            _imgListLoaiSV.Images.Add("Kha", bKha);

            // Icon 2: Trung bình (Cam/Vàng)
            Bitmap bTB = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bTB)) g.Clear(Color.Orange);
            _imgListLoaiSV.Images.Add("TB", bTB);
        }

        private void LoadDataAllControls()
        {
            var data = _bus.GetAll();

            _bindingList = new BindingList<SinhVien>(data);
            dgvSinhVien.DataSource = _bindingList;

            LoadListView();
            LoadTreeView();
        }

        // Bài 8 & 3: Hiển thị ListView kèm Icon Biểu tượng
        private void LoadListView()
        {
            lvSinhVien.Items.Clear();
            foreach (var sv in _bus.GetAll())
            {
                // Chọn index hình ảnh dựa theo điểm
                int imgIndex = sv.DiemTB >= 8.0 ? 0 : (sv.DiemTB >= 6.5 ? 1 : 2);

                var item = new ListViewItem(sv.MaSV, imgIndex);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiemTB.ToString("F2"));
                item.SubItems.Add(sv.XepLoai);
                item.SubItems.Add(sv.Khoa);
                item.Tag = sv;
                lvSinhVien.Items.Add(item);
            }
        }

        private void LoadTreeView()
        {
            tvKhoaSinhVien.Nodes.Clear();
            var groupedData = _bus.GetAll().GroupBy(x => x.Khoa);

            foreach (var group in groupedData)
            {
                TreeNode khoaNode = new TreeNode(group.Key);
                foreach (var sv in group)
                {
                    TreeNode svNode = new TreeNode($"{sv.MaSV} - {sv.HoTen} ({sv.XepLoai})");
                    svNode.Tag = sv;
                    khoaNode.Nodes.Add(svNode);
                }
                tvKhoaSinhVien.Nodes.Add(khoaNode);
            }
            tvKhoaSinhVien.ExpandAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtDiemTB.Text.Trim(), out double diem))
                {
                    MessageBox.Show("Điểm trung bình phải là số thực!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SinhVien sv = new SinhVien(
                    txtMaSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value,
                    diem,
                    cboKhoa.SelectedItem.ToString()
                );

                _bus.Add(sv);
                LoadDataAllControls();
                ClearForm();
                MessageBox.Show("Thêm sinh viên thành công! Dữ liệu đã lưu vào CSV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtDiemTB.Text.Trim(), out double diem))
                {
                    MessageBox.Show("Điểm trung bình phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SinhVien sv = new SinhVien(
                    txtMaSV.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value,
                    diem,
                    cboKhoa.SelectedItem.ToString()
                );

                _bus.Update(sv);
                LoadDataAllControls();
                MessageBox.Show("Cập nhật thành công! Dữ liệu đã lưu vào CSV.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _bus.Delete(maSV);
                    LoadDataAllControls();
                    ClearForm();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSinhVien.Rows[e.RowIndex].DataBoundItem is SinhVien sv)
            {
                DisplaySinhVien(sv);
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0 && lvSinhVien.SelectedItems[0].Tag is SinhVien sv)
            {
                DisplaySinhVien(sv);
            }
        }

        private void tvKhoaSinhVien_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is SinhVien sv)
            {
                DisplaySinhVien(sv);
            }
        }

        private void DisplaySinhVien(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiemTB.Text = sv.DiemTB.ToString("F2");
            cboKhoa.SelectedItem = sv.Khoa;
        }

        private void ClearForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            txtMaSV.Focus();
        }
    }
}