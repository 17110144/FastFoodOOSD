using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using FastFood.BusinessLayer;
using FastFood.Forms;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_PersonnelManager : UserControl
    {
        private int check = 0;
        private int nhanvienID = 0;
        public UC_PersonnelManager()
        {
            InitializeComponent();
        }
        private void _formatDT()
        {
            dtListEmployess.Columns["MaNV"].Width = 60;
            dtListEmployess.Columns["TenNV"].Width = 200;
            dtListEmployess.Columns["CMND"].Width = 100;
            dtListEmployess.Columns["SDT"].Width = 110;
        }
        private void _reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            cbDiLam.Checked = false;
            txtTimKiem.Focus();
            errorProvider.Clear();
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
        /*
         * GetAll là hàm get child control trong C#
         * Sử dụng đệ quy để get theo type
         * Truyền vào 1 control và giá trị là txt
         * tham khảo tại stackoverflow
         */
        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            //var tự động nhận biết kiểu dữ liệu trong scope
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                           .Concat(controls)
                           .Where(c => c.GetType() == type);
        }
        private string _genIdEmployess()
        {
            /*
             * Mã nhân viên tự động tăng NV001->NV999
             * Nếu bảng có mã NV001 và NV003 thì mã NV002 sẽ được thêm vào
             */
            DataTable dt = new DataTable();
            //hàm get cột MaNV
            dt = cls_Employess._getIDEmployess();
            // tạo temp để lưu số thứ tự của mã nv
            int temp = 0;
            //nếu danh sánh nv rỗng
            if (dt.Rows.Count == 0)
            {
                temp = 1;
            }
            // nếu ds có 1 nv và MaNV = NV001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
            {
                temp = 2;
            }
            //nếu ds có 1 nv và MaNV # NV001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
            {
                temp = 1;
            }
            //nếu ds có > 1 nv
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                    {
                        temp = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                        break;
                    }
                }

                if (temp == 0)
                {
                    temp = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
                }
            }

            if (temp < 10)
            {
                return "NV00" + temp;
            }
            if (temp < 100)
            {
                return "NV0" + temp;
            }
            return "NV" + temp;
        }
        private List<string> _checkAvailable(int id)
        {
            List<string> msg = new List<string>();
            if (!cls_Employess._checkInNguoiDung(id))
            {
                msg.Add("Vui lòng xóa nhân viên này trong Người Dùng trước khi xóa nhân viên.");
            }
            if (!cls_Employess._checkInHoSoNhanVien(id))
            {
                msg.Add("Vui lòng xóa nhân viên này trong Hồ Sơ Nhân Viên trước khi xóa nhân viên.");
            }
            if (!cls_Employess._checkInNhanVienBoPhan(id))
            {
                msg.Add("Vui lòng xóa nhân viên này trong Bộ Phận trước khi xóa nhân viên.");
            }
            if (!cls_Employess._checkInNhanVienChucDanh(id))
            {
                msg.Add("Vui lòng xóa nhân viên này trong Chức Danh trước khi xóa nhân viên.");
            }
            if (!cls_Employess._checkInHoaDon(id))
            {
                msg.Add("Vui lòng xóa nhân viên này trong Hóa Đơn trước khi xóa nhân viên.");
            }
            return msg;
        }
        private void UC_PersonnelManager_Load(object sender, EventArgs e)
        {
            /*
             * Gets or sets a value that indicates whether controls in this container will be automatically validated when the focus changes.
             * An AutoValidate enumerated value that indicates whether contained controls are implicitly validated on focus change. The default is Inherit.
             * Source: https://doc.microsoft.com
             */
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            cmbGioiTinh.DataSource = cls_Employess._getGender();
            cmbGioiTinh.ValueMember = "GioiTinhID";
            cmbGioiTinh.DisplayMember = "GioiTinh";
            dtListEmployess.AutoGenerateColumns = false;
            dtListEmployess.DataSource = cls_Employess._showEmployess();
            _formatDT();
            _reset();
            _sttButton(true, true, true, false, false, false);

            cmbFilter.ValueMember = "Value";
            cmbFilter.DisplayMember = "Text";
            var items = new[] {
                new { Text = "Tên NV", Value = "TenNV" },
                new { Text = "Số CMND", Value = "CMND" },
                new { Text = "Số điện thoại", Value = "SDT" }
            };
            cmbFilter.DataSource = items;
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtListEmployess.DataSource = cls_Employess._searchEmployess(txtTimKiem.Text, cmbFilter.SelectedValue.ToString());
            _formatDT();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, true, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Personnel"].BringToFront();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
            txtMaNV.Enabled = false;
            txtTenNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (dtListEmployess.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _sttButton(false, false, false, true, true, true);
                txtTenNV.Focus();
                int index = dtListEmployess.CurrentCell.RowIndex;

                nhanvienID = Convert.ToInt32(dtListEmployess.Rows[index].Cells[0].Value);
                txtMaNV.Enabled = false;
                txtMaNV.Text = dtListEmployess.Rows[index].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dtListEmployess.Rows[index].Cells["TenNV"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dtListEmployess.Rows[index].Cells["NgaySinh"].Value.ToString());
                txtCMND.Text = dtListEmployess.Rows[index].Cells["CMND"].Value.ToString();
                txtDiaChi.Text = dtListEmployess.Rows[index].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dtListEmployess.Rows[index].Cells["Email"].Value.ToString();
                txtSDT.Text = dtListEmployess.Rows[index].Cells["SDT"].Value.ToString();
                cmbGioiTinh.SelectedValue = Convert.ToBoolean(dtListEmployess.Rows[index].Cells["GioiTinhID"].Value.ToString());
                cbDiLam.Checked = Convert.ToBoolean(dtListEmployess.Rows[index].Cells["TrangThaiID"].Value.ToString());
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, true, true, false, false, false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtListEmployess.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = dtListEmployess.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dtListEmployess.Rows[index].Cells["MaNV"].Value);

                DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var checkAvailable = _checkAvailable(id);
                    if (checkAvailable.Count > 0)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra:\n - " + string.Join("\n - ", checkAvailable.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cls_Employess._delEmployess(id))
                        {
                            MessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtListEmployess.DataSource = cls_Employess._showEmployess();
                            _formatDT();
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                //Get child control theo type truyền vào
                var getChildControls = GetAll(this, typeof(TextBox));

                var listOfErrors = getChildControls.Select(c => errorProvider.GetError(c))
                                                   .Where(s => !string.IsNullOrEmpty(s))
                                                   .ToList();
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhân viên:\n - " + string.Join("\n - ", listOfErrors.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (check == 1)
                {
                    string genMaNV = _genIdEmployess();
                    string dob = dtpNgaySinh.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    bool addEmployess = cls_Employess._addEmployess(genMaNV, txtTenNV.Text, dob, Convert.ToInt32(cmbGioiTinh.SelectedValue), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtCMND.Text, Convert.ToInt32(cbDiLam.Checked));

                    if (addEmployess == true)
                    {
                        MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reset();
                        _sttButton(true, true, true, false, false, false);
                        _formatDT();
                        dtListEmployess.DataSource = cls_Employess._showEmployess();
                        txtTimKiem.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nhân viên này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string dob = dtpNgaySinh.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    bool updateEmployess = cls_Employess._updateEmployess(nhanvienID, txtMaNV.Text, txtTenNV.Text, dob, Convert.ToInt32(cmbGioiTinh.SelectedValue), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, txtCMND.Text, Convert.ToInt32(cbDiLam.Checked));

                    if (updateEmployess == true)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtListEmployess.DataSource = cls_Employess._showEmployess();
                        _reset();
                        _formatDT();
                        _sttButton(true, true, true, false, false, false);
                        txtTimKiem.Focus();
                        nhanvienID = 0;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật nhân viên này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtTenNV_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNV.Text == "")
            {
                errorProvider.SetError(txtTenNV, "Tên nhân viên không được trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTenNV, "");
            }
        }

        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtCMND.Text == "")
            {
                errorProvider.SetError(txtCMND, "Số CMND không được trống.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtCMND.Text))
            {
                errorProvider.SetError(txtCMND, "Số CMND phải là số.");
                e.Cancel = true;
            }
            else if (txtCMND.TextLength > 10)
            {
                errorProvider.SetError(txtCMND, "Số CMND không đúng.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCMND, "");
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text == "")
            {
                errorProvider.SetError(txtDiaChi, "Địa chỉ không được trống.");
                e.Cancel = true;
            }
            else if (txtDiaChi.TextLength > 255)
            {
                errorProvider.SetError(txtDiaChi, "Địa chỉ không được quá 255 kí tự.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDiaChi, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (txtEmail.Text == "")
            {
                errorProvider.SetError(txtEmail, "Email không được trống.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email không đúng định dạng example@domain.com.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtSDT.Text == "")
            {
                errorProvider.SetError(txtSDT, "Số điện thoại không được trống.");
                e.Cancel = true;
            }
            else if (txtSDT.TextLength > 11)
            {
                errorProvider.SetError(txtSDT, "Số điện thoại không chính xác.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtSDT.Text))
            {
                errorProvider.SetError(txtSDT, "Số điện thoại không chính xác.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSDT, "");
            }
        }
    }
}
