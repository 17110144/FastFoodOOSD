using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.Forms
{
    public partial class frm_UserPermission : Form
    {
        public frm_UserPermission()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_UserPermission_Load(object sender, EventArgs e)
        {
            /*
            DataTable dt = lib.cls_Employess._getDeparment();
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            cmbBoPhan.DataSource = dt;
            */
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataTable dt = lib.cls_Employess._getNhanVienBoPhanID(Convert.ToInt32(cmbBoPhan.SelectedValue));
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.DataSource = dt;
            */
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataTable dt = lib.cls_Employess._getUserPermission(Convert.ToInt32(cmbNhanVien.SelectedValue));
            cmbNguoiDung.ValueMember = "NguoiDungID";
            cmbNguoiDung.DisplayMember = "TenDangNhap";
            cmbNguoiDung.DataSource = dt;
            */
        }

        private void cmbNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            cbHeThong.Checked = false;
            cbNhanSu.Checked = false;
            cbTienLuong.Checked = false;
            cbThongKe.Checked = false;
            cbSanPham.Checked = false;
            cbGoiMon.Checked = false;
            cbDanhMuc.Checked = false;

            DataTable nghiepVu = lib.cls_Employess._getNghiepVu(Convert.ToInt32(cmbNguoiDung.SelectedValue));
            for (int i = 0; i < nghiepVu.Rows.Count; i++)
            {
                switch (nghiepVu.Rows[i].ItemArray[0].ToString())
                {
                    case "1":
                        cbHeThong.Checked = true;
                        break;
                    case "2":
                        cbNhanSu.Checked = true;
                        break;
                    case "3":
                        cbTienLuong.Checked = true;
                        break;
                    case "4":
                        cbThongKe.Checked = true;
                        break;
                    case "5":
                        cbSanPham.Checked = true;
                        break;
                    case "6":
                        cbGoiMon.Checked = true;
                        break;
                    case "7":
                        cbDanhMuc.Checked = true;
                        break;
                }
            }
            */
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /*
            if (cmbNguoiDung.SelectedValue == null)
            {
                MessageBox.Show("Nhân viên này chưa có tài khoản. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool delPermission = lib.cls_Employess._delPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue));
            if (!delPermission)
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbHeThong.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbHeThong.AccessibleDescription));
            }
            if (cbDanhMuc.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbDanhMuc.AccessibleDescription));
            }
            if (cbNhanSu.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbNhanSu.AccessibleDescription));
            }
            if (cbThongKe.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbThongKe.AccessibleDescription));
            }
            if (cbTienLuong.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbTienLuong.AccessibleDescription));
            }
            if (cbSanPham.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbSanPham.AccessibleDescription));
            }
            if (cbGoiMon.Checked == true)
            {
                lib.cls_Employess._insertPermission(Convert.ToInt32(cmbNguoiDung.SelectedValue), Convert.ToInt32(cbGoiMon.AccessibleDescription));
            }
            MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }
    }
}
