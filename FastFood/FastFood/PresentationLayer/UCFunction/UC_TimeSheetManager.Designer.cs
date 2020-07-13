namespace FastFood.PresentationLayer.UCFunction
{
    partial class UC_TimeSheetManager
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnHienThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.dtList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCongChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoPhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamCongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.btnNop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).BeginInit();
            this.grpDanhSach.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(108, 21);
            this.lblTitle.TabIndex = 68;
            this.lblTitle.Text = "CHẤM CÔNG";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnHienThi);
            this.grpThongTin.Controls.Add(this.dtpThang);
            this.grpThongTin.Controls.Add(this.cmbBoPhan);
            this.grpThongTin.Controls.Add(this.lblThang);
            this.grpThongTin.Controls.Add(this.lblBoPhan);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpThongTin.Location = new System.Drawing.Point(28, 64);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(850, 100);
            this.grpThongTin.TabIndex = 70;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chấm công";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHienThi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHienThi.BorderRadius = 5;
            this.btnHienThi.ButtonText = "HIỂN THỊ";
            this.btnHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnHienThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHienThi.Iconimage = null;
            this.btnHienThi.Iconimage_right = null;
            this.btnHienThi.Iconimage_right_Selected = null;
            this.btnHienThi.Iconimage_Selected = null;
            this.btnHienThi.IconMarginLeft = 0;
            this.btnHienThi.IconMarginRight = 0;
            this.btnHienThi.IconRightVisible = true;
            this.btnHienThi.IconRightZoom = 0D;
            this.btnHienThi.IconVisible = true;
            this.btnHienThi.IconZoom = 90D;
            this.btnHienThi.IsTab = false;
            this.btnHienThi.Location = new System.Drawing.Point(606, 42);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnHienThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHienThi.selected = false;
            this.btnHienThi.Size = new System.Drawing.Size(96, 27);
            this.btnHienThi.TabIndex = 74;
            this.btnHienThi.Text = "HIỂN THỊ";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHienThi.Textcolor = System.Drawing.Color.White;
            this.btnHienThi.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(434, 42);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(165, 27);
            this.dtpThang.TabIndex = 3;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(186, 41);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(186, 28);
            this.cmbBoPhan.TabIndex = 2;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(378, 45);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(50, 20);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(116, 45);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(64, 20);
            this.lblBoPhan.TabIndex = 0;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // dtList
            // 
            this.dtList.AllowUserToAddRows = false;
            this.dtList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.TenNV,
            this.NgayCongChuan,
            this.NgayDiLam,
            this.NgayNghi,
            this.NgayTinhLuong,
            this.GhiChu,
            this.TrangThai,
            this.BoPhanID,
            this.NhanVienID,
            this.ChamCongID,
            this.Thang});
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
            this.dtList.Size = new System.Drawing.Size(838, 344);
            this.dtList.TabIndex = 1;
            this.dtList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtList_CellFormatting);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayCongChuan
            // 
            this.NgayCongChuan.DataPropertyName = "NgayCongChuan";
            this.NgayCongChuan.HeaderText = "Ngày công chuẩn";
            this.NgayCongChuan.Name = "NgayCongChuan";
            // 
            // NgayDiLam
            // 
            this.NgayDiLam.DataPropertyName = "NgayDiLam";
            this.NgayDiLam.HeaderText = "Ngày đi làm";
            this.NgayDiLam.Name = "NgayDiLam";
            // 
            // NgayNghi
            // 
            this.NgayNghi.DataPropertyName = "NgayNghi";
            this.NgayNghi.HeaderText = "Ngày nghỉ";
            this.NgayNghi.Name = "NgayNghi";
            // 
            // NgayTinhLuong
            // 
            this.NgayTinhLuong.DataPropertyName = "NgayTinhLuong";
            this.NgayTinhLuong.HeaderText = "Ngày tính lương";
            this.NgayTinhLuong.Name = "NgayTinhLuong";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BoPhanID
            // 
            this.BoPhanID.DataPropertyName = "BoPhanID";
            this.BoPhanID.HeaderText = "BoPhanID";
            this.BoPhanID.Name = "BoPhanID";
            this.BoPhanID.Visible = false;
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "NhanVienID";
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Visible = false;
            // 
            // ChamCongID
            // 
            this.ChamCongID.DataPropertyName = "ChamCongID";
            this.ChamCongID.HeaderText = "ChamCongID";
            this.ChamCongID.Name = "ChamCongID";
            this.ChamCongID.Visible = false;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Thang";
            this.Thang.Name = "Thang";
            this.Thang.Visible = false;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dtList);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpDanhSach.Location = new System.Drawing.Point(28, 170);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(850, 387);
            this.grpDanhSach.TabIndex = 79;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách chấm công";
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
            this.btnNop.Location = new System.Drawing.Point(751, 563);
            this.btnNop.Name = "btnNop";
            this.btnNop.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnNop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnNop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNop.selected = false;
            this.btnNop.Size = new System.Drawing.Size(126, 44);
            this.btnNop.TabIndex = 83;
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
            this.btnLuu.Location = new System.Drawing.Point(620, 563);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(92)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(125, 44);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnBack.TabIndex = 69;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UC_TimeSheetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpThongTin);
            this.Name = "UC_TimeSheetManager";
            this.Size = new System.Drawing.Size(893, 619);
            this.Load += new System.EventHandler(this.UC_TimeSheetManager_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtList)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblThang;
        private Bunifu.Framework.UI.BunifuFlatButton btnHienThi;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtList;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private Bunifu.Framework.UI.BunifuFlatButton btnNop;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCongChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoPhanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChamCongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
