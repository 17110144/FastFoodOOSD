namespace FastFood.PresentationLayer.UCSytem
{
    partial class UC_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSearchProduct = new System.Windows.Forms.GroupBox();
            this.dtSearch = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpListProduct = new System.Windows.Forms.GroupBox();
            this.dtChoose = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpInfoInvoice = new System.Windows.Forms.GroupBox();
            this.txtEmployess = new System.Windows.Forms.TextBox();
            this.lblEmployess = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtReturnPayment = new System.Windows.Forms.TextBox();
            this.lblReturnPayment = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveDB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.check = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.grpSearchProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch)).BeginInit();
            this.grpListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtChoose)).BeginInit();
            this.grpInfoInvoice.SuspendLayout();
            this.grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchProduct
            // 
            this.grpSearchProduct.Controls.Add(this.dtSearch);
            this.grpSearchProduct.Controls.Add(this.txtSearch);
            this.grpSearchProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpSearchProduct.Location = new System.Drawing.Point(3, 3);
            this.grpSearchProduct.Name = "grpSearchProduct";
            this.grpSearchProduct.Size = new System.Drawing.Size(450, 443);
            this.grpSearchProduct.TabIndex = 0;
            this.grpSearchProduct.TabStop = false;
            this.grpSearchProduct.Text = "Chọn món";
            // 
            // dtSearch
            // 
            this.dtSearch.AllowUserToAddRows = false;
            this.dtSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSearch.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.GiaTien,
            this.SoLuong,
            this.GiamGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtSearch.DoubleBuffered = true;
            this.dtSearch.EnableHeadersVisualStyles = false;
            this.dtSearch.GridColor = System.Drawing.Color.Azure;
            this.dtSearch.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dtSearch.HeaderForeColor = System.Drawing.Color.White;
            this.dtSearch.Location = new System.Drawing.Point(6, 61);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.ReadOnly = true;
            this.dtSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtSearch.RowHeadersVisible = false;
            this.dtSearch.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSearch.Size = new System.Drawing.Size(438, 376);
            this.dtSearch.TabIndex = 1;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá (%)";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(83, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // grpListProduct
            // 
            this.grpListProduct.Controls.Add(this.dtChoose);
            this.grpListProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpListProduct.Location = new System.Drawing.Point(459, 3);
            this.grpListProduct.Name = "grpListProduct";
            this.grpListProduct.Size = new System.Drawing.Size(431, 397);
            this.grpListProduct.TabIndex = 1;
            this.grpListProduct.TabStop = false;
            this.grpListProduct.Text = "Danh sách gọi món";
            // 
            // dtChoose
            // 
            this.dtChoose.AllowUserToAddRows = false;
            this.dtChoose.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dtChoose.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtChoose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtChoose.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtChoose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtChoose.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtChoose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtChoose.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtChoose.DoubleBuffered = true;
            this.dtChoose.EnableHeadersVisualStyles = false;
            this.dtChoose.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.dtChoose.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dtChoose.HeaderForeColor = System.Drawing.Color.White;
            this.dtChoose.Location = new System.Drawing.Point(6, 26);
            this.dtChoose.Name = "dtChoose";
            this.dtChoose.ReadOnly = true;
            this.dtChoose.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtChoose.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtChoose.RowHeadersVisible = false;
            this.dtChoose.RowHeadersWidth = 50;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtChoose.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtChoose.Size = new System.Drawing.Size(419, 365);
            this.dtChoose.TabIndex = 0;
            // 
            // grpInfoInvoice
            // 
            this.grpInfoInvoice.Controls.Add(this.txtEmployess);
            this.grpInfoInvoice.Controls.Add(this.lblEmployess);
            this.grpInfoInvoice.Controls.Add(this.txtUser);
            this.grpInfoInvoice.Controls.Add(this.lblUser);
            this.grpInfoInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoInvoice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpInfoInvoice.Location = new System.Drawing.Point(3, 452);
            this.grpInfoInvoice.Name = "grpInfoInvoice";
            this.grpInfoInvoice.Size = new System.Drawing.Size(450, 87);
            this.grpInfoInvoice.TabIndex = 19;
            this.grpInfoInvoice.TabStop = false;
            this.grpInfoInvoice.Text = "Thông tin hóa đơn";
            // 
            // txtEmployess
            // 
            this.txtEmployess.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmployess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployess.Location = new System.Drawing.Point(284, 34);
            this.txtEmployess.Name = "txtEmployess";
            this.txtEmployess.Size = new System.Drawing.Size(160, 23);
            this.txtEmployess.TabIndex = 10;
            // 
            // lblEmployess
            // 
            this.lblEmployess.AutoSize = true;
            this.lblEmployess.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployess.Location = new System.Drawing.Point(204, 36);
            this.lblEmployess.Name = "lblEmployess";
            this.lblEmployess.Size = new System.Drawing.Size(84, 20);
            this.lblEmployess.TabIndex = 8;
            this.lblEmployess.Text = "Nhân viên:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(93, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(109, 23);
            this.txtUser.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUser.Location = new System.Drawing.Point(2, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(94, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Khách hàng:";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblTotalMoney);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.txtReturnPayment);
            this.grpPayment.Controls.Add(this.lblReturnPayment);
            this.grpPayment.Controls.Add(this.txtReceive);
            this.grpPayment.Controls.Add(this.lblReceive);
            this.grpPayment.Controls.Add(this.txtDiscount);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtMoney);
            this.grpPayment.Controls.Add(this.lblMoney);
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpPayment.Location = new System.Drawing.Point(462, 406);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(431, 169);
            this.grpPayment.TabIndex = 21;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thanh toán";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalMoney.Location = new System.Drawing.Point(164, 125);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(25, 30);
            this.lblTotalMoney.TabIndex = 18;
            this.lblTotalMoney.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(25, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 30);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "TỔNG CỘNG:";
            // 
            // txtReturnPayment
            // 
            this.txtReturnPayment.BackColor = System.Drawing.Color.AliceBlue;
            this.txtReturnPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnPayment.Location = new System.Drawing.Point(301, 82);
            this.txtReturnPayment.Name = "txtReturnPayment";
            this.txtReturnPayment.Size = new System.Drawing.Size(120, 27);
            this.txtReturnPayment.TabIndex = 16;
            // 
            // lblReturnPayment
            // 
            this.lblReturnPayment.AutoSize = true;
            this.lblReturnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnPayment.Location = new System.Drawing.Point(222, 85);
            this.lblReturnPayment.Name = "lblReturnPayment";
            this.lblReturnPayment.Size = new System.Drawing.Size(77, 20);
            this.lblReturnPayment.TabIndex = 15;
            this.lblReturnPayment.Text = "Tiền thừa:";
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.Color.AliceBlue;
            this.txtReceive.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.Location = new System.Drawing.Point(98, 82);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(118, 27);
            this.txtReceive.TabIndex = 14;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceive.Location = new System.Drawing.Point(7, 85);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(85, 20);
            this.lblReceive.TabIndex = 13;
            this.lblReceive.Text = "Khách đưa:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(301, 29);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(120, 27);
            this.txtDiscount.TabIndex = 12;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(222, 33);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(73, 20);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Giảm giá:";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(98, 30);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(118, 27);
            this.txtMoney.TabIndex = 10;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMoney.Location = new System.Drawing.Point(6, 32);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(86, 20);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Thành tiền:";
            // 
            // btnDone
            // 
            this.btnDone.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnDone.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDone.BorderRadius = 5;
            this.btnDone.ButtonText = "XONG";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDone.Iconimage = null;
            this.btnDone.Iconimage_right = null;
            this.btnDone.Iconimage_right_Selected = null;
            this.btnDone.Iconimage_Selected = null;
            this.btnDone.IconMarginLeft = 0;
            this.btnDone.IconMarginRight = 0;
            this.btnDone.IconRightVisible = true;
            this.btnDone.IconRightZoom = 0D;
            this.btnDone.IconVisible = true;
            this.btnDone.IconZoom = 90D;
            this.btnDone.IsTab = false;
            this.btnDone.Location = new System.Drawing.Point(801, 580);
            this.btnDone.Name = "btnDone";
            this.btnDone.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnDone.OnHovercolor = System.Drawing.Color.Black;
            this.btnDone.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDone.selected = false;
            this.btnDone.Size = new System.Drawing.Size(82, 30);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "XONG";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Textcolor = System.Drawing.Color.AliceBlue;
            this.btnDone.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.ButtonText = "HỦY";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(713, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(82, 30);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.AliceBlue;
            this.btnCancel.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 5;
            this.btnAddProduct.ButtonText = "THÊM MÓN";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = null;
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 90D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(11, 545);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.Black;
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(112, 30);
            this.btnAddProduct.TabIndex = 23;
            this.btnAddProduct.Text = "THÊM MÓN";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.AliceBlue;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnDelProduct.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelProduct.BorderRadius = 5;
            this.btnDelProduct.ButtonText = "XÓA MÓN";
            this.btnDelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelProduct.Iconimage = null;
            this.btnDelProduct.Iconimage_right = null;
            this.btnDelProduct.Iconimage_right_Selected = null;
            this.btnDelProduct.Iconimage_Selected = null;
            this.btnDelProduct.IconMarginLeft = 0;
            this.btnDelProduct.IconMarginRight = 0;
            this.btnDelProduct.IconRightVisible = true;
            this.btnDelProduct.IconRightZoom = 0D;
            this.btnDelProduct.IconVisible = true;
            this.btnDelProduct.IconZoom = 90D;
            this.btnDelProduct.IsTab = false;
            this.btnDelProduct.Location = new System.Drawing.Point(188, 545);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnDelProduct.OnHovercolor = System.Drawing.Color.Black;
            this.btnDelProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelProduct.selected = false;
            this.btnDelProduct.Size = new System.Drawing.Size(98, 30);
            this.btnDelProduct.TabIndex = 24;
            this.btnDelProduct.Text = "XÓA MÓN";
            this.btnDelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelProduct.Textcolor = System.Drawing.Color.AliceBlue;
            this.btnDelProduct.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnSaveDB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveDB.BorderRadius = 5;
            this.btnSaveDB.ButtonText = "LƯU CSDL";
            this.btnSaveDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDB.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveDB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveDB.Iconimage = null;
            this.btnSaveDB.Iconimage_right = null;
            this.btnSaveDB.Iconimage_right_Selected = null;
            this.btnSaveDB.Iconimage_Selected = null;
            this.btnSaveDB.IconMarginLeft = 0;
            this.btnSaveDB.IconMarginRight = 0;
            this.btnSaveDB.IconRightVisible = true;
            this.btnSaveDB.IconRightZoom = 0D;
            this.btnSaveDB.IconVisible = true;
            this.btnSaveDB.IconZoom = 90D;
            this.btnSaveDB.IsTab = false;
            this.btnSaveDB.Location = new System.Drawing.Point(351, 545);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnSaveDB.OnHovercolor = System.Drawing.Color.Black;
            this.btnSaveDB.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveDB.selected = false;
            this.btnSaveDB.Size = new System.Drawing.Size(94, 30);
            this.btnSaveDB.TabIndex = 26;
            this.btnSaveDB.Text = "LƯU CSDL";
            this.btnSaveDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveDB.Textcolor = System.Drawing.Color.AliceBlue;
            this.btnSaveDB.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // check
            // 
            this.check.ContainerControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpInfoInvoice);
            this.Controls.Add(this.grpListProduct);
            this.Controls.Add(this.grpSearchProduct);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(893, 619);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            this.grpSearchProduct.ResumeLayout(false);
            this.grpSearchProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSearch)).EndInit();
            this.grpListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtChoose)).EndInit();
            this.grpInfoInvoice.ResumeLayout(false);
            this.grpInfoInvoice.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchProduct;
        private System.Windows.Forms.GroupBox grpListProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpInfoInvoice;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblEmployess;
        private System.Windows.Forms.TextBox txtEmployess;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lblReturnPayment;
        private System.Windows.Forms.TextBox txtReturnPayment;
        private Bunifu.Framework.UI.BunifuFlatButton btnDone;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveDB;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalMoney;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtChoose;
        private System.Windows.Forms.ErrorProvider check;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
