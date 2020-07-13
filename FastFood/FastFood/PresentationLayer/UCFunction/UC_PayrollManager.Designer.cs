namespace FastFood.PresentationLayer.UCFunction
{
    partial class UC_PayrollManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dtList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietBanKeLuongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThucLinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinhLuong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.lblThang = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(41, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 21);
            this.lblTitle.TabIndex = 70;
            this.lblTitle.Text = "BẢNG KÊ LƯƠNG";
            // 
            // btnNop
            // 
            this.btnNop.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnNop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNop.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNop.BorderRadius = 5;
            this.btnNop.ButtonText = "NỘP";
            this.btnNop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNop.DisabledColor = System.Drawing.Color.Gray;
            this.btnNop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNop.Iconimage = null;
            this.btnNop.Iconimage_right = null;
            this.btnNop.Iconimage_right_Selected = null;
            this.btnNop.Iconimage_Selected = null;
            this.btnNop.IconMarginLeft = 0;
            this.btnNop.IconMarginRight = 0;
            this.btnNop.IconRightVisible = true;
            this.btnNop.IconRightZoom = 0D;
            this.btnNop.IconVisible = true;
            this.btnNop.IconZoom = 90D;
            this.btnNop.IsTab = false;
            this.btnNop.Location = new System.Drawing.Point(528, 57);
            this.btnNop.Name = "btnNop";
            this.btnNop.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnNop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnNop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNop.selected = false;
            this.btnNop.Size = new System.Drawing.Size(114, 35);
            this.btnNop.TabIndex = 87;
            this.btnNop.Text = "NỘP";
            this.btnNop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNop.Textcolor = System.Drawing.Color.White;
            this.btnNop.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.ButtonText = "LƯU";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 90D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(408, 57);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(114, 35);
            this.btnLuu.TabIndex = 86;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dtList);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpDanhSach.Location = new System.Drawing.Point(28, 98);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(850, 502);
            this.grpDanhSach.TabIndex = 85;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách kê lương";
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtList.ColumnHeadersHeight = 50;
            this.dtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.ChiTietBanKeLuongID,
            this.NhanVienID,
            this.TenNV,
            this.NgayCongChuan,
            this.NgayTinhLuong,
            this.TienLuong,
            this.PhuCap,
            this.TongLuong,
            this.ThucLinh,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtList.DoubleBuffered = true;
            this.dtList.EnableHeadersVisualStyles = false;
            this.dtList.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.dtList.HeaderForeColor = System.Drawing.Color.White;
            this.dtList.Location = new System.Drawing.Point(6, 28);
            this.dtList.MultiSelect = false;
            this.dtList.Name = "dtList";
            this.dtList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtList.RowHeadersVisible = false;
            this.dtList.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtList.Size = new System.Drawing.Size(838, 468);
            this.dtList.TabIndex = 1;
            this.dtList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtList_CellFormatting);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 58;
            // 
            // ChiTietBanKeLuongID
            // 
            this.ChiTietBanKeLuongID.DataPropertyName = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.HeaderText = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.Name = "ChiTietBanKeLuongID";
            this.ChiTietBanKeLuongID.Visible = false;
            this.ChiTietBanKeLuongID.Width = 194;
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = false;
            this.NhanVienID.Width = 121;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 60;
            // 
            // NgayCongChuan
            // 
            this.NgayCongChuan.DataPropertyName = "NgayCongChuan";
            this.NgayCongChuan.HeaderText = "Ngày công chuẩn";
            this.NgayCongChuan.Name = "NgayCongChuan";
            this.NgayCongChuan.ReadOnly = true;
            this.NgayCongChuan.Width = 147;
            // 
            // NgayTinhLuong
            // 
            this.NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            this.NgayTinhLuong.HeaderText = "Ngày tính lương";
            this.NgayTinhLuong.Name = "NgayTinhLuong";
            this.NgayTinhLuong.ReadOnly = true;
            this.NgayTinhLuong.Width = 139;
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "TienLuong";
            this.TienLuong.HeaderText = "Tiền lương cứng";
            this.TienLuong.Name = "TienLuong";
            this.TienLuong.ReadOnly = true;
            this.TienLuong.Width = 141;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ cấp";
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.ReadOnly = true;
            this.PhuCap.Width = 85;
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "Tổng lương";
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.ReadOnly = true;
            this.TongLuong.Width = 110;
            // 
            // ThucLinh
            // 
            this.ThucLinh.DataPropertyName = "ThucLinh";
            this.ThucLinh.HeaderText = "Thực lĩnh";
            this.ThucLinh.Name = "ThucLinh";
            this.ThucLinh.ReadOnly = true;
            this.ThucLinh.Width = 93;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThai.Width = 98;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTinhLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhLuong.BorderRadius = 5;
            this.btnTinhLuong.ButtonText = "TÍNH LƯƠNG";
            this.btnTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuong.DisabledColor = System.Drawing.Color.Gray;
            this.btnTinhLuong.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTinhLuong.Iconimage = null;
            this.btnTinhLuong.Iconimage_right = null;
            this.btnTinhLuong.Iconimage_right_Selected = null;
            this.btnTinhLuong.Iconimage_Selected = null;
            this.btnTinhLuong.IconMarginLeft = 0;
            this.btnTinhLuong.IconMarginRight = 0;
            this.btnTinhLuong.IconRightVisible = true;
            this.btnTinhLuong.IconRightZoom = 0D;
            this.btnTinhLuong.IconVisible = true;
            this.btnTinhLuong.IconZoom = 90D;
            this.btnTinhLuong.IsTab = false;
            this.btnTinhLuong.Location = new System.Drawing.Point(288, 57);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnTinhLuong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnTinhLuong.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTinhLuong.selected = false;
            this.btnTinhLuong.Size = new System.Drawing.Size(114, 35);
            this.btnTinhLuong.TabIndex = 74;
            this.btnTinhLuong.Text = "TÍNH LƯƠNG";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTinhLuong.Textcolor = System.Drawing.Color.White;
            this.btnTinhLuong.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(101, 63);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(165, 27);
            this.dtpThang.TabIndex = 3;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblThang.Location = new System.Drawing.Point(45, 66);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(50, 20);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::FastFood.Properties.Resources.left_round_32px;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 71;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UC_PayrollManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_PayrollManager";
            this.Size = new System.Drawing.Size(893, 619);
            this.Load += new System.EventHandler(this.UC_PayrollManager_Load);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnNop;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtList;
        private Bunifu.Framework.UI.BunifuFlatButton btnTinhLuong;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietBanKeLuongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucLinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
