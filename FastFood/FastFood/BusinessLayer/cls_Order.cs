using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FastFood.BusinessLayer
{
    class cls_Order
    {

        //Search
        public static DataTable _searchProduct(string nameProduct)
        {
            string query = string.Format("SELECT MaSP, TenSP, GiaTien, SoLuong, GiamGia FROM tbl_SanPham WHERE TenSP LIKE N'{0}%' OR TenSP LIKE N'%{0}%' OR TenSP LIKE N'%{0}'", nameProduct);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        //get MaHD
        public static DataTable _getMaHD()
        {
            string query = string.Format("SELECT MaHD FROM tbl_HoaDon");
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        //thêm mới Hóa Đơn
        public static bool _addNewHD(string maHD, int nhanVienID, string tenKhach, int tongTien)
        {
            try
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                string query = string.Format("INSERT INTO tbl_HoaDon(MaHD, TenKhach, NhanVienID, NgayLapHD, TongTien) VALUES ('{0}', N'{1}', {2}, '{3}', {4})",maHD, tenKhach, nhanVienID, date, tongTien);
                cls_Database.AED(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        //thêm vào chi tiết hóa đơn
        public static void _updateCTHD(string maHD, string maSP, int SLMua)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_CTHD(MaHD, MaSP, SLMua) VALUES ('{0}', '{1}', {2})", maHD, maSP, SLMua);
                cls_Database.AED(query);
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi khi cập nhật chi tiết hóa đơn. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cập nhật lại số lượng sp 
        public static void _updateSP(string maSP, int SLMua)
        {
            try
            {
                int sl = 0;
                string query1 = string.Format("SELECT SoLuong FROM tbl_SanPham WHERE MaSP = '{0}'", maSP);
                DataTable dt = new DataTable();
                dt = cls_Database.TableRead(query1);
                sl = Convert.ToInt32(dt.Rows[0][0].ToString());
                int update = sl - SLMua;
                string query = string.Format("UPDATE tbl_SanPham SET SoLuong = {0} WHERE MaSP = '{1}'", update, maSP);
                cls_Database.AED(query);
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi khi cập nhật số lượng sản phẩm. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
