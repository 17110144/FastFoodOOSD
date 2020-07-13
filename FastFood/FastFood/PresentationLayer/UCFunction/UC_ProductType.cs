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
    public partial class UC_ProductType : UserControl
    {
        public UC_ProductType()
        {
            InitializeComponent();
        }
        private void _sttButton(bool add, bool edit, bool delete, bool update, bool cancel, bool grpProductType)
        {
            btnThem.Enabled = add;
            btnSua.Enabled = edit;
            btnXoa.Enabled = delete;
            btnCapNhat.Enabled = update;
            btnHuyBo.Enabled = cancel;
            grpLoaiSanPham.Enabled = grpProductType;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            _sttButton(false, true, false, false, false, false);
            frm_Main.Instance.pnlContainer.Controls["UC_Product"].BringToFront();
            txtLoaiSanPham.Text = "";
        }

        private void UC_ProductType_Load(object sender, EventArgs e)
        {
            dtListProductType.DataSource = cls_Product._showProductType();
            _sttButton(false, true, false, false, false, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtListProductType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _sttButton(false, false, false, true, true, true);

                int index = dtListProductType.CurrentCell.RowIndex;
                txtLoaiSanPham.Text = dtListProductType.Rows[index].Cells["TenLoaiSP"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtLoaiSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int loaiSPID;
                int index = dtListProductType.CurrentCell.RowIndex;
                loaiSPID = Convert.ToInt32(dtListProductType.Rows[index].Cells["LoaiSPID"].Value);
                bool updateProductType = cls_Product._updateProductType(loaiSPID, txtLoaiSanPham.Text);
                if (updateProductType == true)
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtListProductType.DataSource = cls_Product._showProductType();
                    _sttButton(false, true, false, false, false, false);
                    txtLoaiSanPham.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật loại sản phẩm này. Vui lòng kiểm tra lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtLoaiSanPham.Text = "";
            _sttButton(false, true, false, false, false, false);
        }
    }
}
