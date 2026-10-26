namespace Lab06_ThreeLayerMemory
{
    partial class frmQuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblKhoa;

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.ComboBox cboKhoa;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDGV;
        private System.Windows.Forms.TabPage tabListView;
        private System.Windows.Forms.TabPage tabTreeView;

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.TreeView tvKhoaSinhVien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDGV = new System.Windows.Forms.TabPage();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.tabListView = new System.Windows.Forms.TabPage();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.tabTreeView = new System.Windows.Forms.TabPage();
            this.tvKhoaSinhVien = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tabListView.SuspendLayout();
            this.tabTreeView.SuspendLayout();
            this.SuspendLayout();

            // lblMaSV
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(20, 20);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(56, 20);
            this.lblMaSV.Text = "Mã SV:";

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(100, 17);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 27);

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(310, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 20);
            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(380, 17);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 27);

            // lblNgaySinh
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(630, 20);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(77, 20);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(720, 17);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 27);

            // lblDiemTB
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(20, 65);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(69, 20);
            this.lblDiemTB.Text = "Điểm TB:";

            // txtDiemTB
            this.txtDiemTB.Location = new System.Drawing.Point(100, 62);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(180, 27);

            // lblKhoa
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(310, 65);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(46, 20);
            this.lblKhoa.Text = "Khoa:";

            // cboKhoa
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(380, 62);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(220, 28);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(630, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(715, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(800, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // tabControl1
            this.tabControl1.Controls.Add(this.tabDGV);
            this.tabControl1.Controls.Add(this.tabListView);
            this.tabControl1.Controls.Add(this.tabTreeView);
            this.tabControl1.Location = new System.Drawing.Point(20, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 430);

            // tabDGV
            this.tabDGV.Controls.Add(this.dgvSinhVien);
            this.tabDGV.Location = new System.Drawing.Point(4, 29);
            this.tabDGV.Name = "tabDGV";
            this.tabDGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDGV.Size = new System.Drawing.Size(847, 397);
            this.tabDGV.Text = "Bài 1 & 2: DataGridView";
            this.tabDGV.UseVisualStyleBackColor = true;

            // dgvSinhVien
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 3);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(841, 391);
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // tabListView
            this.tabListView.Controls.Add(this.lvSinhVien);
            this.tabListView.Location = new System.Drawing.Point(4, 29);
            this.tabListView.Name = "tabListView";
            this.tabListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView.Size = new System.Drawing.Size(847, 397);
            this.tabListView.Text = "Bài 3 & 8: ListView";
            this.tabListView.UseVisualStyleBackColor = true;

            // lvSinhVien
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 3);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(841, 391);
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);

            // tabTreeView
            this.tabTreeView.Controls.Add(this.tvKhoaSinhVien);
            this.tabTreeView.Location = new System.Drawing.Point(4, 29);
            this.tabTreeView.Name = "tabTreeView";
            this.tabTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreeView.Size = new System.Drawing.Size(847, 397);
            this.tabTreeView.Text = "Bài 4: TreeView";
            this.tabTreeView.UseVisualStyleBackColor = true;

            // tvKhoaSinhVien
            this.tvKhoaSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvKhoaSinhVien.Location = new System.Drawing.Point(3, 3);
            this.tvKhoaSinhVien.Name = "tvKhoaSinhVien";
            this.tvKhoaSinhVien.Size = new System.Drawing.Size(841, 391);
            this.tvKhoaSinhVien.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoaSinhVien_AfterSelect);

            // frmQuanLySinhVien
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 06 - Quản lý Sinh viên (Mô hình 3 lớp)";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tabListView.ResumeLayout(false);
            this.tabTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}