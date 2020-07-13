using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.Forms;
using FastFood.BusinessLayer;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_OfficeManager : UserControl
    {
        private int check = 0;
        private int _nhanVienID = 0;
        public UC_OfficeManager()
        {
            InitializeComponent();
        }
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            //var tự động nhận biết kiểu dữ liệu trong scope
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
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
        private void UC_OfficeManager_Load(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            dtList.DataSource = cls_Employess._getNhanVienChucDanh();
            DataTable getBoPhan = cls_Employess._getDeparment();
            DataTable getChucDanh = cls_Employess._getOffice();


            cmbChucDanh.ValueMember = "ChucDanhID";
            cmbChucDanh.DisplayMember = "TenChucDanh";
            cmbChucDanh.DataSource = getChucDanh;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Personnel"].BringToFront();
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
            if (_nhanVienID == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa chức danh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool delNVCD = cls_Employess._deleteNhanVienChucDanh(_nhanVienID);
                if (delNVCD == true)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _sttButton(true, false, true, false, false, false);
                    dtList.DataSource = cls_Employess._getNhanVienChucDanh();
                    _nhanVienID = 0;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                var getChildControls = GetAll(this, typeof(ComboBox));

                var listOfErrors = getChildControls.Select(c => errorProvider.GetError(c))
                                                   .Where(s => !string.IsNullOrEmpty(s))
                                                   .ToList();
                MessageBox.Show("Vui lòng kiểm tra lại thông tin:\n - " + string.Join("\n - ", listOfErrors.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (check == 1)
                {
                    bool insertNVCD = cls_Employess._insertNhanVienChucDanh(Convert.ToInt32(cmbTenNV.SelectedValue), Convert.ToInt32(cmbChucDanh.SelectedValue));

                    if (insertNVCD == true)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = cls_Employess._getNhanVienChucDanh();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool updateNVCD = cls_Employess._updateNhanVienChucDanh(Convert.ToInt32(cmbTenNV.SelectedValue), Convert.ToInt32(cmbChucDanh.SelectedValue));
                    if (updateNVCD == true)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = cls_Employess._getNhanVienChucDanh();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            errorProvider.Clear();
        }

        private void cmbTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTenNV.SelectedValue == null)
            {
                errorProvider.SetError(cmbTenNV, "Vui lòng chọn tên nhân viên.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbTenNV, "");
            }
        }

        private void cmbChucDanh_Validating(object sender, CancelEventArgs e)
        {
            if (cmbTenNV.SelectedValue == null)
            {
                errorProvider.SetError(cmbChucDanh, "Vui lòng chọn chức danh.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbChucDanh, "");
            }
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cls_Employess._getNhanVienChucDanh().Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                _nhanVienID = Convert.ToInt32(dtList.Rows[index].Cells["NhanVienID"].Value);
                cmbTenNV.SelectedValue = Convert.ToInt32(dtList.Rows[index].Cells["NhanVienID"].Value);
                cmbChucDanh.SelectedValue = Convert.ToInt32(dtList.Rows[index].Cells["ChucDanhID"].Value);
                btnSua.Enabled = true;
            }
        }
    }
}
