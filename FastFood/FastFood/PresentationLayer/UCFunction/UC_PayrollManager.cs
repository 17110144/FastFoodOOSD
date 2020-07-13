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
    public partial class UC_PayrollManager : UserControl
    {
        public UC_PayrollManager()
        {
            InitializeComponent();
        }
        private void UC_PayrollManager_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_Main.Instance.pnlContainer.Controls["UC_Salary"].BringToFront();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            DataTable dt = cls_Salary._getChiTietBanKeLuong(dtpThang.Value.ToString("yyyyMM"));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản kê lương nào  trong tháng này được tính. Vui lòng chấm công trước khi tính lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dt.Rows.Count > 0)
            {
                dtList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Lỗi hiển thị. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (DataGridViewRow row in dtList.Rows)
            {
                if (row != null)
                {
                    string ChiTietBanKeLuongID = row.Cells["ChiTietBanKeLuongID"].Value.ToString();
                    int NgayCongChuan = row.Cells["NgayCongChuan"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayCongChuan"].Value);
                    int NhanVienID = Convert.ToInt32(row.Cells["NhanVienID"].Value);
                    int NgayTinhLuong = row.Cells["NgayTinhLuong"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["NgayTinhLuong"].Value);
                    string TrangThai = row.Cells["TrangThai"].Value.ToString();
                    decimal TongLuong = row.Cells["TongLuong"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["TongLuong"].Value);
                    decimal PhuCap = row.Cells["PhuCap"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["PhuCap"].Value);
                    decimal TienLuong = row.Cells["TienLuong"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["TienLuong"].Value);
                    decimal ThucLinh = row.Cells["ThucLinh"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["ThucLinh"].Value);

                    if (ChiTietBanKeLuongID != "" && TrangThai == "1")
                    {
                        bool _updateBanKeLuong = cls_Salary._updateChiTietBanKeLuong(TienLuong, PhuCap, TongLuong, ThucLinh, ChiTietBanKeLuongID);
                        if (_updateBanKeLuong)
                        {
                            flag++;
                        }
                    }
                }
            }
            btnTinhLuong_Click(sender, e);
            if (flag == 0)
            {
                MessageBox.Show("Không có bản ghi nào thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu " + flag + " bản ghi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            int flag = 0;
            foreach (DataGridViewRow row in dtList.Rows)
            {
                if (row != null)
                {
                    if (row.Cells["TrangThai"].Value.ToString() == "1")
                    {
                        string ChiTietBanKeLuongID = row.Cells["ChiTietBanKeLuongID"].Value.ToString();
                        bool _updateTrangThai = cls_Salary._updateTrangThaiBanKeLuong(ChiTietBanKeLuongID);
                        if (_updateTrangThai)
                        {
                            flag++;
                        }
                    }
                }
            }

            btnTinhLuong_Click(sender, e);
            if (flag == 0)
            {
                MessageBox.Show("Không có bản ghi nào thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nộp " + flag + " bản ghi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtList.Columns[e.ColumnIndex].Name.Equals("TrangThai"))
            {
                int? stt = e.Value as int?;

                if (stt == 1)
                {
                    e.Value = "Chưa nộp";
                }
                else if (stt == 2)
                {
                    e.Value = "Đã nộp";
                }
                else
                {
                    e.Value = "Unknown";
                }
            }
            dtList.Columns["TienLuong"].DefaultCellStyle.Format = "N0";
            dtList.Columns["PhuCap"].DefaultCellStyle.Format = "N0";
            dtList.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            dtList.Columns["ThucLinh"].DefaultCellStyle.Format = "N0";
        }
    }
}
