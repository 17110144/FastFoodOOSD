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
    public partial class UC_DepartmentManager : UserControl
    {
                private int check = 0;
        private int _nhanVienID = 0;
        public UC_DepartmentManager()
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
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            //var tự động nhận biết kiểu dữ liệu trong scope
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            _sttButton(true, false, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Personnel"].BringToFront();
        }

        private void UC_DepartmentManager_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;

            DataTable nhanVien = BusinessLayer.cls_Employess._getProfileName();
            DataTable boPhan = BusinessLayer.cls_Employess._getDeparment();

            cmbTenNV.DataSource = nhanVien;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";

            cmbBoPhan.DataSource = boPhan;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";

            errorProvider.Clear();
            _sttButton(true, false, true, false, false, false);
            dtList.DataSource = BusinessLayer.cls_Employess._getInfoNhanVienBoPhan();
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

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BusinessLayer.cls_Employess._getInfoNhanVienBoPhan().Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                _nhanVienID = Convert.ToInt32(dtList.Rows[index].Cells["NhanVienID"].Value);
                cmbTenNV.SelectedValue = Convert.ToInt32(dtList.Rows[index].Cells["NhanVienID"].Value);
                cmbBoPhan.SelectedValue = Convert.ToInt32(dtList.Rows[index].Cells["BoPhanID"].Value);
                btnSua.Enabled = true;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            _sttButton(true, false, true, false, false, false);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                //Get child control theo type truyền vào
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
                    int insertNVBP = BusinessLayer.cls_Employess._insertNhanVienBoPhan(Convert.ToInt32(cmbTenNV.SelectedValue), Convert.ToInt32(cmbBoPhan.SelectedValue));
                    if (insertNVBP == 1)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = BusinessLayer.cls_Employess._getInfoNhanVienBoPhan();
                    }
                    else if (insertNVBP == 2627)
                    {
                        MessageBox.Show("Nhân viên này đã thuộc bộ phận. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool updateNVBP = BusinessLayer.cls_Employess._updateNhanVienBoPhan(Convert.ToInt32(cmbTenNV.SelectedValue), Convert.ToInt32(cmbBoPhan.SelectedValue));
                    if (updateNVBP == true)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = BusinessLayer.cls_Employess._getInfoNhanVienBoPhan();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void cmbBoPhan_Validating(object sender, CancelEventArgs e)
        {

            if (cmbBoPhan.SelectedValue == null)
            {
                errorProvider.SetError(cmbBoPhan, "Vui lòng chọn bộ phận.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbBoPhan, "");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_nhanVienID == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!BusinessLayer.cls_Employess._checkNhanVienChucDanh(_nhanVienID))
                {
                    MessageBox.Show("Vui lòng xóa chức danh nhân viên này trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool delNVBP = BusinessLayer.cls_Employess._delNhanVienBoPhan(_nhanVienID);
                    if (delNVBP == true)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, false, true, false, false, false);
                        dtList.DataSource = BusinessLayer.cls_Employess._getInfoNhanVienBoPhan();
                        _nhanVienID = 0;
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
