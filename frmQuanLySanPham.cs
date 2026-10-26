using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab06_ThreeLayerMemory
{
    public partial class frmQuanLySanPham : Form
    {
        private readonly SanPhamBUS _bus = new SanPhamBUS();
        private BindingList<SanPham> _bindingList;
        private bool _isSortAscending = true;

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            cboDanhMuc.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Máy tính bảng" });
            cboDanhMuc.SelectedIndex = 0;

            LoadDataAllControls();
        }

        private void LoadDataAllControls()
        {
            var data = _bus.GetAll();

            _bindingList = new BindingList<SanPham>(data);
            dgvSanPham.DataSource = _bindingList;

            double tongGiaTri = _bus.TinhTongGiaTriHangTon();
            lblTongTonKho.Text = $"Tổng tồn kho: {tongGiaTri:N0} VNĐ";

            LoadTreeView();
        }

        private void LoadTreeView()
        {
            tvDanhMuc.Nodes.Clear();
            var groupedData = _bus.GetAll().GroupBy(x => x.DanhMuc);

            foreach (var group in groupedData)
            {
                TreeNode catNode = new TreeNode(group.Key);
                foreach (var sp in group)
                {
                    TreeNode spNode = new TreeNode($"{sp.MaSP} - {sp.TenSP} (SL: {sp.SoLuong})");
                    spNode.Tag = sp;
                    catNode.Nodes.Add(spNode);
                }
                tvDanhMuc.Nodes.Add(catNode);
            }
            tvDanhMuc.ExpandAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int sl) || !double.TryParse(txtDonGia.Text.Trim(), out double gia))
                {
                    MessageBox.Show("Số lượng và Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SanPham sp = new SanPham(
                    txtMaSP.Text.Trim(),
                    txtTenSP.Text.Trim(),
                    sl,
                    gia,
                    cboDanhMuc.SelectedItem.ToString()
                );

                _bus.Add(sp);
                LoadDataAllControls();
                ClearForm();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!int.TryParse(txtSoLuong.Text.Trim(), out int sl) || !double.TryParse(txtDonGia.Text.Trim(), out double gia))
                {
                    MessageBox.Show("Số lượng và Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SanPham sp = new SanPham(
                    txtMaSP.Text.Trim(),
                    txtTenSP.Text.Trim(),
                    sl,
                    gia,
                    cboDanhMuc.SelectedItem.ToString()
                );

                _bus.Update(sp);
                LoadDataAllControls();
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string maSP = txtMaSP.Text.Trim();
                if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {maSP} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _bus.Delete(maSP);
                    LoadDataAllControls();
                    ClearForm();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var ketQua = _bus.TimKiem(txtTimKiem.Text.Trim());
            dgvSanPham.DataSource = new BindingList<SanPham>(ketQua);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            var dataSorted = _bus.SapXep(_isSortAscending);
            dgvSanPham.DataSource = new BindingList<SanPham>(dataSorted);
            btnSapXep.Text = _isSortAscending ? "Sắp xếp: Giá Giảm dần" : "Sắp xếp: Giá Tăng dần";
            _isSortAscending = !_isSortAscending;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSanPham.Rows[e.RowIndex].DataBoundItem is SanPham sp)
            {
                DisplaySanPham(sp);
            }
        }

        private void DisplaySanPham(SanPham sp)
        {
            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtSoLuong.Text = sp.SoLuong.ToString();
            txtDonGia.Text = sp.DonGia.ToString("F0");
            cboDanhMuc.SelectedItem = sp.DanhMuc;
        }

        private void ClearForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        private void tvDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvDanhMuc.SelectedNode = e.Node;
            }
        }

        private void mnuThemNode_Click(object sender, EventArgs e)
        {
            if (tvDanhMuc.SelectedNode != null)
            {
                TreeNode newNode = new TreeNode("Danh mục mới");
                tvDanhMuc.SelectedNode.Nodes.Add(newNode);
                tvDanhMuc.SelectedNode.Expand();
            }
            else
            {
                tvDanhMuc.Nodes.Add(new TreeNode("Danh mục gốc mới"));
            }
        }

        private void mnuDoiTenNode_Click(object sender, EventArgs e)
        {
            if (tvDanhMuc.SelectedNode != null)
            {
                tvDanhMuc.SelectedNode.BeginEdit();
            }
        }

        private void mnuXoaNode_Click(object sender, EventArgs e)
        {
            if (tvDanhMuc.SelectedNode != null)
            {
                tvDanhMuc.Nodes.Remove(tvDanhMuc.SelectedNode);
            }
        }
    }
}