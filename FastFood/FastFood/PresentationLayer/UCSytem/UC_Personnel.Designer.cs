namespace FastFood.PresentationLayer.UCSytem
{
    partial class UC_Personnel
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
            this.grpChucDanh = new System.Windows.Forms.GroupBox();
            this.grpQuanLyNhanSu = new System.Windows.Forms.GroupBox();
            this.grpQuanLyNhanVien = new System.Windows.Forms.GroupBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnChucDanh = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnQuanLyNhanVien = new Bunifu.Framework.UI.BunifuImageButton();
            this.grpChucDanh.SuspendLayout();
            this.grpQuanLyNhanSu.SuspendLayout();
            this.grpQuanLyNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChucDanh
            // 
            this.grpChucDanh.Controls.Add(this.btnChucDanh);
            this.grpChucDanh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucDanh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpChucDanh.Location = new System.Drawing.Point(256, 236);
            this.grpChucDanh.Name = "grpChucDanh";
            this.grpChucDanh.Size = new System.Drawing.Size(207, 200);
            this.grpChucDanh.TabIndex = 1;
            this.grpChucDanh.TabStop = false;
            this.grpChucDanh.Text = "Chức danh";
            // 
            // grpQuanLyNhanSu
            // 
            this.grpQuanLyNhanSu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpQuanLyNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.grpQuanLyNhanSu.Controls.Add(this.grpChucDanh);
            this.grpQuanLyNhanSu.Controls.Add(this.grpQuanLyNhanVien);
            this.grpQuanLyNhanSu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuanLyNhanSu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpQuanLyNhanSu.Location = new System.Drawing.Point(183, 69);
            this.grpQuanLyNhanSu.Name = "grpQuanLyNhanSu";
            this.grpQuanLyNhanSu.Size = new System.Drawing.Size(485, 461);
            this.grpQuanLyNhanSu.TabIndex = 5;
            this.grpQuanLyNhanSu.TabStop = false;
            this.grpQuanLyNhanSu.Text = "Quản lý nhân sự";
            // 
            // grpQuanLyNhanVien
            // 
            this.grpQuanLyNhanVien.Controls.Add(this.btnQuanLyNhanVien);
            this.grpQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuanLyNhanVien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpQuanLyNhanVien.Location = new System.Drawing.Point(43, 28);
            this.grpQuanLyNhanVien.Name = "grpQuanLyNhanVien";
            this.grpQuanLyNhanVien.Size = new System.Drawing.Size(207, 200);
            this.grpQuanLyNhanVien.TabIndex = 0;
            this.grpQuanLyNhanVien.TabStop = false;
            this.grpQuanLyNhanVien.Text = "Quản lý nhân viên";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnChucDanh
            // 
            this.btnChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.btnChucDanh.Image = global::FastFood.Properties.Resources.contact_card_100px;
            this.btnChucDanh.ImageActive = null;
            this.btnChucDanh.Location = new System.Drawing.Point(35, 28);
            this.btnChucDanh.Name = "btnChucDanh";
            this.btnChucDanh.Size = new System.Drawing.Size(145, 145);
            this.btnChucDanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChucDanh.TabIndex = 0;
            this.btnChucDanh.TabStop = false;
            this.btnChucDanh.Zoom = 10;
            this.btnChucDanh.Click += new System.EventHandler(this.btnChucDanh_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyNhanVien.Image = global::FastFood.Properties.Resources.edit_user_100px;
            this.btnQuanLyNhanVien.ImageActive = null;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(35, 28);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(145, 145);
            this.btnQuanLyNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.TabStop = false;
            this.btnQuanLyNhanVien.Zoom = 10;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // UC_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.grpQuanLyNhanSu);
            this.Name = "UC_Personnel";
            this.Size = new System.Drawing.Size(893, 619);
            this.grpChucDanh.ResumeLayout(false);
            this.grpQuanLyNhanSu.ResumeLayout(false);
            this.grpQuanLyNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpChucDanh;
        private Bunifu.Framework.UI.BunifuImageButton btnChucDanh;
        private System.Windows.Forms.GroupBox grpQuanLyNhanSu;
        private System.Windows.Forms.GroupBox grpQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuImageButton btnQuanLyNhanVien;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
