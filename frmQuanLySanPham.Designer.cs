namespace Lab06_ThreeLayerMemory
{
    partial class frmQuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblTongTonKho;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSapXep;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDGV;
        private System.Windows.Forms.TabPage tabTreeView;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TreeView tvDanhMuc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem mnuThemNode;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiTenNode;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaNode;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblTongTonKho = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDGV = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabTreeView = new System.Windows.Forms.TabPage();
            this.tvDanhMuc = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuThemNode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiTenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabTreeView.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(20, 16);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(50, 16);
            this.lblMaSP.TabIndex = 17;
            this.lblMaSP.Text = "Mã SP:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(300, 16);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(55, 16);
            this.lblTenSP.TabIndex = 15;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 52);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(300, 52);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 16);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(610, 16);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(70, 16);
            this.lblDanhMuc.TabIndex = 13;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 88);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(65, 16);
            this.lblTimKiem.TabIndex = 4;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // lblTongTonKho
            // 
            this.lblTongTonKho.AutoSize = true;
            this.lblTongTonKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTonKho.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTongTonKho.Location = new System.Drawing.Point(570, 87);
            this.lblTongTonKho.Name = "lblTongTonKho";
            this.lblTongTonKho.Size = new System.Drawing.Size(234, 23);
            this.lblTongTonKho.TabIndex = 1;
            this.lblTongTonKho.Text = "Tổng giá trị tồn kho: 0 VNĐ";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(90, 14);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(180, 22);
            this.txtMaSP.TabIndex = 16;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(370, 14);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(220, 22);
            this.txtTenSP.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(90, 50);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(180, 22);
            this.txtSoLuong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(370, 50);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(220, 22);
            this.txtDonGia.TabIndex = 8;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(700, 14);
            this.cboDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(180, 24);
            this.cboDanhMuc.TabIndex = 12;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(90, 86);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 22);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(610, 48);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 24);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(700, 48);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 24);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(790, 48);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 24);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(400, 84);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(150, 24);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp xếp theo Giá";
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDGV);
            this.tabControl1.Controls.Add(this.tabTreeView);
            this.tabControl1.Location = new System.Drawing.Point(20, 120);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDGV
            // 
            this.tabDGV.Controls.Add(this.dgvSanPham);
            this.tabDGV.Location = new System.Drawing.Point(4, 25);
            this.tabDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDGV.Name = "tabDGV";
            this.tabDGV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDGV.Size = new System.Drawing.Size(852, 283);
            this.tabDGV.TabIndex = 0;
            this.tabDGV.Text = "Bài 6: DataGridView Sản phẩm";
            this.tabDGV.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 2);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(846, 279);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // tabTreeView
            // 
            this.tabTreeView.Controls.Add(this.tvDanhMuc);
            this.tabTreeView.Location = new System.Drawing.Point(4, 25);
            this.tabTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTreeView.Name = "tabTreeView";
            this.tabTreeView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTreeView.Size = new System.Drawing.Size(852, 283);
            this.tabTreeView.TabIndex = 1;
            this.tabTreeView.Text = "Bài 7: TreeView Chuột phải (ContextMenuStrip)";
            this.tabTreeView.UseVisualStyleBackColor = true;
            // 
            // tvDanhMuc
            // 
            this.tvDanhMuc.ContextMenuStrip = this.contextMenuStripTreeView;
            this.tvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDanhMuc.LabelEdit = true;
            this.tvDanhMuc.Location = new System.Drawing.Point(3, 2);
            this.tvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvDanhMuc.Name = "tvDanhMuc";
            this.tvDanhMuc.Size = new System.Drawing.Size(846, 279);
            this.tvDanhMuc.TabIndex = 0;
            this.tvDanhMuc.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDanhMuc_NodeMouseClick);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemNode,
            this.mnuDoiTenNode,
            this.mnuXoaNode});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(213, 76);
            // 
            // mnuThemNode
            // 
            this.mnuThemNode.Name = "mnuThemNode";
            this.mnuThemNode.Size = new System.Drawing.Size(212, 24);
            this.mnuThemNode.Text = "Thêm danh mục con";
            this.mnuThemNode.Click += new System.EventHandler(this.mnuThemNode_Click);
            // 
            // mnuDoiTenNode
            // 
            this.mnuDoiTenNode.Name = "mnuDoiTenNode";
            this.mnuDoiTenNode.Size = new System.Drawing.Size(212, 24);
            this.mnuDoiTenNode.Text = "Đổi tên Node";
            this.mnuDoiTenNode.Click += new System.EventHandler(this.mnuDoiTenNode_Click);
            // 
            // mnuXoaNode
            // 
            this.mnuXoaNode.Name = "mnuXoaNode";
            this.mnuXoaNode.Size = new System.Drawing.Size(212, 24);
            this.mnuXoaNode.Text = "Xóa Node";
            this.mnuXoaNode.Click += new System.EventHandler(this.mnuXoaNode_Click);
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 448);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTongTonKho);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblMaSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 06 - Bài 6 & Bài 7: Quản lý Sản phẩm";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabTreeView.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}