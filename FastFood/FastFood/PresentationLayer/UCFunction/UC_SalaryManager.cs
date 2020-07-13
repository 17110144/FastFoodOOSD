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
using FastFood.Forms;
using FastFood.BusinessLayer;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_SalaryManager : UserControl
    {
        private int check = 0;
        private int _chucDanhID = 0;
        public UC_SalaryManager()
        {
            InitializeComponent();
        }
        private void _reset()
        {
            txtChucDanh.Text = "";
            txtLuongCung.Text = "";
            txtPhuCap.Text = "";
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
            _sttButton(true, false, true, false, false, false);
            _reset();
            frm_Main.Instance.pnlContainer.Controls["UC_Salary"].BringToFront();
        }

        private void UC_SalaryManager_Load(object sender, EventArgs e)
        {
            /*
            * Gets or sets a value that indicates whether controls in this container will be automatically validated when the focus changes.
            * An AutoValidate enumerated value that indicates whether contained controls are implicitly validated on focus change. The default is Inherit.
            * Source: https://doc.microsoft.com
            */
            _reset();
            _sttButton(true, false, true, false, false, false);
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            dtList.AutoGenerateColumns = false;
            dtList.DataSource = cls_Salary._getChucDanh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
            txtChucDanh.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_chucDanhID == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa lương chức danh " + txtChucDanh.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!cls_Salary._checkChucDanh(_chucDanhID))
                    {
                        MessageBox.Show("Vui lòng xóa bản ghi trong thông tin nhân viên trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool _delCD = cls_Salary._delChucDanh(_chucDanhID);
                        if (_delCD)
                        {
                            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _sttButton(true, false, true, false, false, false);
                            _reset();
                            dtList.DataSource = cls_Salary._getChucDanh();
                            _chucDanhID = 0;
                        }
                        else
                        {
                            MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Get child control theo type truyền vào
                var getChildControls = GetAll(this, typeof(ComboBox));

                var listOfErrors = getChildControls.Select(c => errorProvider.GetError(c))
                                                   .Where(s => !string.IsNullOrEmpty(s))
                                                   .ToList();
                MessageBox.Show("Vui lòng kiểm tra lại thông tin lương:\n - " + string.Join("\n - ", listOfErrors.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (check == 1)
                {
                    bool _insertCD = cls_Salary._insertChucDanh(txtChucDanh.Text, txtLuongCung.Text, txtPhuCap.Text);
                    if (_insertCD)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, false, true, false, false, false);
                        _reset();
                        dtList.DataSource = cls_Salary._getChucDanh();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm thông tin lương. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool _updateCD = cls_Salary._updateChucDanh(txtChucDanh.Text, txtLuongCung.Text, txtPhuCap.Text, _chucDanhID);
                    if (_updateCD)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, false, true, false, false, false);
                        _reset();
                        dtList.DataSource = cls_Salary._getChucDanh();
                        _chucDanhID = 0;
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin lương. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _sttButton(true, false, true, false, false, false);
            _reset();
        }

        private void dtList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cls_Salary._getChucDanh().Rows.Count > 0)
            {
                int index = dtList.CurrentCell.RowIndex;
                _chucDanhID = Convert.ToInt32(dtList.Rows[index].Cells[0].Value);
                txtChucDanh.Text = dtList.Rows[index].Cells[1].Value.ToString();
                txtLuongCung.Text = dtList.Rows[index].Cells[2].Value.ToString();
                txtPhuCap.Text = dtList.Rows[index].Cells[3].Value.ToString();
                btnSua.Enabled = true;
            }
        }

        private void txtChucDanh_Validating(object sender, CancelEventArgs e)
        {
            if (txtChucDanh.Text == "")
            {
                errorProvider.SetError(txtChucDanh, "Tên chức danh không được trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtChucDanh, "");
            }
        }

        private void txtLuongCung_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtLuongCung.Text == "")
            {
                errorProvider.SetError(txtLuongCung, "Lương không được trống.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtLuongCung.Text))
            {
                errorProvider.SetError(txtLuongCung, "Lương phải là số.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLuongCung, "");
            }
        }

        private void txtPhuCap_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (txtPhuCap.Text == "")
            {
                errorProvider.SetError(txtPhuCap, "Phụ cấp không được trống.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtPhuCap.Text))
            {
                errorProvider.SetError(txtPhuCap, "Phụ cấp phải là số.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhuCap, "");
            }
        }

        private void dtList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtList.Columns["TienLuong"].DefaultCellStyle.Format = "N0";
        }
    }
}
