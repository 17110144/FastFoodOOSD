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

    public partial class UC_NCCManager : UserControl
    {

        public UC_NCCManager()
        {
            InitializeComponent();
        }
        int check = 0;
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpncc)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpNCC.Enabled = grpncc;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            check = 1;
            _sttButton(false, false, false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            check = 2;
            if (dtListNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tên nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _sttButton(false, false, false, true, true, true);

                int index = dtListNCC.CurrentCell.RowIndex;
                txtTenNCC.Text = dtListNCC.Rows[index].Cells["TenNhaCungCap"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtListNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = dtListNCC.CurrentCell.RowIndex;
                int maNCC = Convert.ToInt32(dtListNCC.Rows[index].Cells["NCCID"].Value);

                DialogResult result = MessageBox.Show("Bạn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataTable dt = cls_Product._checkNCC(maNCC);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Vui lòng xóa sản phẩm trong DS sản phẩm trước khi xóa nhà cung cấp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cls_Product._delNCC(maNCC) == true)
                    {
                        MessageBox.Show("Xóa thành công nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtListNCC.DataSource = cls_Product._showDetailNCC();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thực hiện xóa nhà cung cấp này khỏi CSDL. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                if (txtTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool addNCC = cls_Product._addNCC(txtTenNCC.Text);

                    if (addNCC == true)
                    {
                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, true, true, false, false, false);
                        dtListNCC.DataSource = cls_Product._showDetailNCC();
                        txtTenNCC.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nhà cung cấp này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (txtTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại các thông tin. Đảm bảo thông tin nhập đầy đủ và chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idNCC;
                    int index = dtListNCC.CurrentCell.RowIndex;
                    idNCC = Convert.ToInt32(dtListNCC.Rows[index].Cells["NCCID"].Value);

                    bool updateNCC = cls_Product._updateNCC(idNCC, txtTenNCC.Text);
                    if (updateNCC == true)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _sttButton(true, true, true, false, false, false);
                        dtListNCC.DataSource = cls_Product._showDetailNCC();
                        txtTenNCC.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật nhà cung cấp này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtTenNCC.Text = "";
            _sttButton(true, true, true, false, false, false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(true, true, false, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Product"].BringToFront();
            txtTenNCC.Text = "";
        }

        private void UC_NCCManager_Load(object sender, EventArgs e)
        {
            dtListNCC.DataSource = cls_Product._showDetailNCC();
            _sttButton(true, true, true, false, false, false);
            txtTenNCC.Text = "";
        }
    }
}
