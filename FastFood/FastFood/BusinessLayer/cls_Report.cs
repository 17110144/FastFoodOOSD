using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLayer
{
    class cls_Report
    {
        public static DataTable _getProfileEmployess(int nhanvienID)
        {
            string query = string.Format(@"SELECT a.TenNV, a.NgaySinh, a.CMND, a.DiaChi, c.TenChucDanh, d.NgayVaoLam, c.TienLuong,e.TenBangCap
                                            FROM tbl_NhanVien a
                                            INNER JOIN tbl_NhanVienChucDanh b ON a.NhanVienID = b.NhanVienID
                                            INNER JOIN tbl_ChucDanh c ON c.ChucDanhID = b.ChucDanhID
                                            INNER JOIN tbl_HoSoNhanVien d ON a.NhanVienID = d.NhanVienID
                                            INNER JOIN tbl_BangCap e ON e.BangCapID = d.BangCapID
                                            WHERE a.NhanVienID = '{0}'", nhanvienID);
            return cls_Database.TableRead(query);
        }
        public static DataTable _getNhanVien()
        {
            string query = "SELECT TenNV, NhanVienID FROM tbl_NhanVien";
            return cls_Database.TableRead(query);
        }

        public static DataTable _getLoaiSP()
        {
            string query = "SELECT LoaiSPID, TenLoaiSP FROM tbl_LoaiSP";
            return cls_Database.TableRead(query);
        }
        public static DataTable _searchInvoice(string id)
        {
            string query = string.Format(@"SELECT  a.MaHD, a.TenKhach, b.TenNV, a.NgayLapHD, a.TongTien
                                            FROM tbl_HoaDon a
                                            INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID
                                            WHERE a.MaHD LIKE N'%{0}' OR a.MaHD LIKE N'%{0}%' OR a.MaHD LIKE N'{0}%'", id);
            return cls_Database.TableRead(query);
        }
    }
}
