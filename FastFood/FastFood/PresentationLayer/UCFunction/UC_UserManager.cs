using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.BusinessLayer;
using FastFood.Forms;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_UserManager : UserControl
    {
        private int check = 0;
        private int _NguoiDungID = 0;
        //private int nhanvienID = 0;
        public UC_UserManager()
        {
            InitializeComponent();
        }

        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpinfo)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpThongTin.Enabled = grpinfo;
        }
        private void _reset()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cbQuanTri.Checked = false;
        }
        private void UC_UserManager_Load(object sender, EventArgs e)
        {
            DataTable dt = cls_Employess._getDeparment();
            DataTable dtlist = cls_Employess._getUserPermission();
            _sttButton(true, false, true, false, false, false);
            _reset();
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            cmbBoPhan.DataSource = dt;
            dtList.DataSource = dtlist;
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cls_Employess._getNhanVienBoPhanID(Convert.ToInt32(cmbBoPhan.SelectedValue));
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_NguoiDungID == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Xóa người dùng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool delUser = cls_Employess._delUserPermission(_NguoiDungID);
                    if (delUser == true)
                    {
                        MessageBox.Show("Xóa thành công người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reset();
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = cls_Employess._getUserPermission();
                        _NguoiDungID = 0;
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, false, true, false, false, false);
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cls_Employess._getUserPermission().Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                int NhanVienID = Convert.ToInt32(dtList.Rows[index].Cells["NhanVienID"].Value);
                int BoPhanID = Convert.ToInt32(dtList.Rows[index].Cells["BoPhanID"].Value);
                _NguoiDungID = Convert.ToInt32(dtList.Rows[index].Cells["NguoiDungID"].Value);
                cmbBoPhan.SelectedValue = BoPhanID;
                cmbNhanVien.SelectedValue = NhanVienID;
                txtTenDangNhap.Text = dtList.Rows[index].Cells["TenDangNhap"].Value.ToString();
                cbQuanTri.Checked = Convert.ToBoolean(dtList.Rows[index].Cells["QuanTri"].Value);
                btnSua.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!cls_Employess._checkUserPermission(Convert.ToInt32(cmbNhanVien.SelectedValue)))
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản. Vui lòng kiểm tra và thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!cls_Employess._checkNameUser(txtTenDangNhap.Text))
                {
                    MessageBox.Show("Tên đăng nhập đã có trên hệ thống. Vui lòng kiểm tra và thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMatKhau.Text.Length < 8)
                {
                    MessageBox.Show("Mật khẩu ít nhất phải có 8 kí tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool addUserPermission = cls_Employess._insertUserPermission(txtTenDangNhap.Text, txtMatKhau.Text, Convert.ToInt32(cbQuanTri.Checked), Convert.ToInt32(cmbNhanVien.SelectedValue));
                if (addUserPermission)
                {
                    MessageBox.Show("Tạo tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reset();
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = cls_Employess._getUserPermission();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                bool updateUserPermission;
                if (txtMatKhau.Text != "")
                {
                    updateUserPermission = cls_Employess._updateUserPermission(txtTenDangNhap.Text, txtMatKhau.Text, Convert.ToInt32(cbQuanTri.Checked), Convert.ToInt32(cmbNhanVien.SelectedValue), _NguoiDungID);
                }
                else
                {
                    updateUserPermission = cls_Employess._updateUserPermission(txtTenDangNhap.Text, "", Convert.ToInt32(cbQuanTri.Checked), Convert.ToInt32(cmbNhanVien.SelectedValue), _NguoiDungID);
                }

                if (updateUserPermission)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _reset();
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = cls_Employess._getUserPermission();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_System"].BringToFront();
        }
    }
}
