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
using FastFood.Forms;

namespace FastFood.PresentationLayer.UCFunction
{
    public partial class UC_DrinkManager : UserControl
    {
        int check = 0;
        public UC_DrinkManager()
        {
            InitializeComponent();
        }
        private void _formatDT()
        {
            dtListProduct.Columns["MaSP"].Width = 60;
            dtListProduct.Columns["TenSP"].Width = 220;
            dtListProduct.Columns["TenNhaCungCap"].Width = 300;
        }
        private void _reset()
        {

            txtMaNuocUong.Text = "";
            txtTenNuocUong.Text = "";
            txtGiaTien.Text = "";
            txtGiamGia.Text = "";
            txtSoLuong.Text = "";
            txtTimKiem.Focus();
            errorProvidera.Clear();
        }
        private string _genIdProduct()
        {
            /*
             * Mã sp tự động tăng SP001->SP999
             * Nếu bảng có mã SP001 và SP003 thì mã SP002 sẽ được thêm vào
             */
            DataTable dt = new DataTable();
            //hàm get cột MaSP
            dt = BusinessLayer.cls_Product._getIDProduct();
            // tạo temp để lưu số thứ tự của mã sp
            int temp = 0;
            //nếu danh sánh sp rỗng
            if (dt.Rows.Count == 0)
            {
                temp = 1;
            }
            // nếu ds có 1 sản phẩm và MaSP = SP001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
            {
                temp = 2;
            }
            //nếu ds có 1 sản phẩm và MaSP # SP001
            else if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
            {
                temp = 1;
            }
            //nếu ds có > 1 sp
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
                return "SP00" + temp;
            }
            if (temp < 100)
            {
                return "SP0" + temp;
            }
            return "SP" + temp;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, true, true, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Product"].BringToFront();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            dtListProduct.DataSource = BusinessLayer.cls_Product._searchProduct(2, txtTimKiem.Text, cmbFilter.SelectedValue.ToString());
            _formatDT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
            txtMaNuocUong.Enabled = false;
            txtSoLuong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (dtListProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _sttButton(false, false, false, true, true, true);
                txtSoLuong.Focus();
                int index = dtListProduct.CurrentCell.RowIndex;
                txtMaNuocUong.Enabled = false;
                txtMaNuocUong.Text = dtListProduct.Rows[index].Cells["MaSP"].Value.ToString();
                txtTenNuocUong.Text = dtListProduct.Rows[index].Cells["TenSP"].Value.ToString();
                cmbNhaCungCap.SelectedValue = Convert.ToInt32(dtListProduct.Rows[index].Cells["NCCID"].Value);
                txtGiaTien.Text = dtListProduct.Rows[index].Cells["GiaTien"].Value.ToString();
                txtGiamGia.Text = dtListProduct.Rows[index].Cells["GiamGia"].Value.ToString();
                txtSoLuong.Text = dtListProduct.Rows[index].Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtListProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = dtListProduct.CurrentCell.RowIndex;
                string maNuocUong = dtListProduct.Rows[index].Cells["MaSP"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có muốn xóa thức ăn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataTable dtCTHD = BusinessLayer.cls_Product._checkProduct(maNuocUong);
                    if (dtCTHD.Rows.Count > 0)
                    {
                        MessageBox.Show("Vui lòng xóa sản phẩm trong CTHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (BusinessLayer.cls_Product._delProduct(maNuocUong) == true)
                    {
                        MessageBox.Show(string.Format("Xóa thành công sản phẩm có mã {0}", maNuocUong), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtListProduct.DataSource = BusinessLayer.cls_Product._showProduct(2);
                        _formatDT();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thực hiện xóa sản phẩm này khỏi CSDL. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                //Get child control theo type truyền vào
                var getChildControls = GetAll(this, typeof(TextBox));

                var listOfErrors = getChildControls.Select(c => errorProvidera.GetError(c))
                                                   .Where(s => !string.IsNullOrEmpty(s))
                                                   .ToList();
                MessageBox.Show("Vui lòng kiểm tra lại thông tin sản phẩm:\n - " + string.Join("\n - ", listOfErrors.ToArray()), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (check == 1)
                {
                    string genMaSP = _genIdProduct();
                    bool addProduct = BusinessLayer.cls_Product._addProduct(2, genMaSP, txtTenNuocUong.Text, Convert.ToInt32(cmbNhaCungCap.SelectedValue), int.Parse(txtGiaTien.Text), int.Parse(txtGiamGia.Text), int.Parse(txtSoLuong.Text));

                    if (addProduct == true)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _reset();
                        _formatDT();
                        _sttButton(true, true, true, false, false, false);
                        dtListProduct.DataSource = BusinessLayer.cls_Product._showProduct(2);
                        txtTenNuocUong.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool updateProduct = BusinessLayer.cls_Product._updateProduct(txtMaNuocUong.Text, txtTenNuocUong.Text, Convert.ToInt32(cmbNhaCungCap.SelectedValue), int.Parse(txtGiaTien.Text), int.Parse(txtGiamGia.Text), int.Parse(txtSoLuong.Text));
                    if (updateProduct == true)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtListProduct.DataSource = BusinessLayer.cls_Product._showProduct(2);
                        _reset();
                        _formatDT();
                        _sttButton(true, true, true, false, false, false);
                        txtTimKiem.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật sản phẩm này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            _reset();
            _sttButton(true, true, true, false, false, false);
        }

        private void UC_DrinkManager_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            dtListProduct.DataSource = BusinessLayer.cls_Product._showProduct(2);
            _formatDT();
            _sttButton(true, true, true, false, false, false);
            _reset();
            cmbNhaCungCap.DataSource = BusinessLayer.cls_Product._showNCC();
            cmbNhaCungCap.ValueMember = "NCCID";
            cmbNhaCungCap.DisplayMember = "TenNhaCungCap";

            cmbFilter.DisplayMember = "Text";
            cmbFilter.ValueMember = "Value";

            var items = new[] {
                new { Text = "Tên SP", Value = "TenSP" },
                new { Text = "Mã SP", Value = "MaSP" }
            };
            cmbFilter.DataSource = items;
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtSoLuong.Text == "")
            {
                errorProvidera.SetError(txtSoLuong, "Số lượng sản phẩm không được để trống.");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtSoLuong.Text))
            {
                errorProvidera.SetError(txtSoLuong, "Số lượng sản phẩm phải là số.");
                e.Cancel = true;
            }
            else
            {
                errorProvidera.SetError(txtSoLuong, "");
            }
        }
        private void txtTenNuocUong_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNuocUong.Text == "")
            {
                errorProvidera.SetError(txtTenNuocUong, "Tên nước uống không được trống.");
                e.Cancel = true;
            }
            else
            {
                errorProvidera.SetError(txtTenNuocUong, "");
            }
        }

        private void txtGiaTien_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtGiaTien.Text == "")
            {
                errorProvidera.SetError(txtGiaTien, "Giá tiền không được trống");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtGiaTien.Text) && txtGiaTien.Text != "")
            {
                errorProvidera.SetError(txtGiaTien, "Giá tiền sản phẩm phải là số.");
                e.Cancel = true;
            }
            else
            {
                errorProvidera.SetError(txtGiaTien, "");
            }
        }

        private void txtGiamGia_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (txtGiamGia.Text == "")
            {
                errorProvidera.SetError(txtGiamGia, "% giảm giá không được trống");
                e.Cancel = true;
            }
            else if (!regex.IsMatch(txtGiamGia.Text) && txtGiamGia.Text != "")
            {
                errorProvidera.SetError(txtGiamGia, "% giảm giá phải là số.");
                e.Cancel = true;
            }
            else
            {
                errorProvidera.SetError(txtGiamGia, "");
            }
        }
    }
}
