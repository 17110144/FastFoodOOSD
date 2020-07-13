using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFood.BusinessLayer
{
    class cls_Employess
    {
        public static string _checkLogin(string username, string password)
        {
            string NguoiDungID = null;
            string query = string.Format("SELECT NguoiDungID FROM tbl_NguoiDung WHERE TenDangNhap = '{0}' and MatKhau = '{1}'", username, password);
            DataTable dt = cls_Database.TableRead(query);
            if(dt.Rows.Count > 0)
            {
                NguoiDungID = dt.Rows[0]["NguoiDungID"].ToString();
                return NguoiDungID;
            }
            
            return "ERROR";
        }

        public static bool _checkPermission(string id)
        {
            string query = string.Format("SELECT QuanTri FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows[0]["QuanTri"].ToString() == "0" || dt.Rows[0]["QuanTri"].ToString().ToLower() == "false")
            {
                return false;
            }
            return true;
        }

        public static DataTable _ListPermission(string id)
        {
            string query = string.Format("SELECT a.NguoiDungID, a.NghiepVuID, b.URL FROM tbl_QuyenNguoiDung a JOIN tbl_NghiepVu b ON b.NghiepVuID = a.NghiepVuID WHERE NguoiDungID = '{0}'", id);
            return cls_Database.TableRead(query);
        }

        public static string[] _getInfoEmployess(string id)
        {
            string[] info = new string[2];
            string query = string.Format("SELECT a.NhanVienID, a.TenNV FROM tbl_NhanVien a JOIN tbl_NguoiDung b ON b.NhanVienID = a.NhanVienID WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            info[0] = dt.Rows[0]["NhanVienID"].ToString();
            info[1] = dt.Rows[0]["TenNV"].ToString();
            return info;
        }
          
        public static DataTable _getGender()
        {
            string query = "SELECT * FROM tbl_GioiTinh";
            return cls_Database.TableRead(query);
        }
        
        public static DataTable _showEmployess()
        {
            string query = "SELECT a.NhanVienID, a.MaNV, a.TenNV, a.NgaySinh , a.CMND, a.DiaChi , a.Email , a.SDT, b.GioiTinh, b.GioiTinhID, a.TrangThaiID FROM tbl_NhanVien a inner join tbl_GioiTinh b on a.GioiTinhID = b.GioiTinhID ORDER BY a.MaNV ASC";
            return cls_Database.TableRead(query);
        }
        public static DataTable _searchEmployess(string name, string tbl)
        {
            string query = string.Format("SELECT  a.NhanVienID, a.MaNV, a.TenNV, a.NgaySinh , a.CMND, a.DiaChi , a.Email , a.SDT, b.GioiTinh, a.TrangThaiID FROM tbl_NhanVien a inner join tbl_GioiTinh b on a.GioiTinhID = b.GioiTinhID  WHERE a.{0} LIKE N'{1}%' OR a.{0} LIKE N'%{1}%' OR  a.{0} LIKE N'%{1}'", tbl, name);
            return cls_Database.TableRead(query);
        }
        public static bool _addEmployess(string maNV, string tenNV, string ngaySinh, int gioiTinhID, string diaChi, string sdt, string email, string cmnd, int trangthaiID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVien(MaNV, TenNV, NgaySinh, GioiTinhID, DiaChi, SDT, Email, CMND, TrangThaiID) VALUES ('{0}', N'{1}', '{2}', {3}, N'{4}', '{5}', '{6}', '{7}', {8})", maNV, tenNV, ngaySinh, gioiTinhID, diaChi, sdt, email, cmnd, trangthaiID);
                cls_Database.AED(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static bool _delEmployess(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVien WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _checkInHoSoNhanVien(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_HoSoNhanVien WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool _checkInNhanVienBoPhan(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NhanVienBoPhan WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static bool _checkInNhanVienChucDanh(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static bool _checkInNguoiDung(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NguoiDung WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static bool _checkInHoaDon(int nhanvienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_HoaDon WHERE NhanVienID = {0}", nhanvienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static DataTable _getIDEmployess()
        {
            string query = "SELECT MaNV FROM tbl_NhanVien";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static bool _updateEmployess(int nhavienID, string maNV, string tenNV, string ngaySinh, int gioiTinhID, string diaChi, string sdt, string email, string cmnd, int trangthaiID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVien SET MaNV = '{0}', TenNV = N'{1}', NgaySinh = '{2}', GioiTinhID = {3}, DiaChi = N'{4}', SDT = '{5}', Email = '{6}', CMND = '{7}', TrangThaiID = {8} WHERE NhanVienID = {9}", maNV, tenNV, ngaySinh, gioiTinhID, diaChi, sdt, email, cmnd, trangthaiID, nhavienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _getProfileName()
        {
            string query = "SELECT NhanVienID, TenNV FROM tbl_NhanVien";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _getProfileNation()
        {
            string query = "SELECT * FROM tbl_DanToc";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _getProfileCity()
        {
            string query = "SELECT * FROM tbl_TinhThanh";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _getProfileReligion()
        {
            string query = "SELECT * FROM tbl_TonGiao";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _getProfileDiploma()
        {
            string query = "SELECT * FROM tbl_BangCap";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _showProfileInfo()
        {
            string query = @"SELECT b.NhanVienID, b.TenNV, a.NgayVaoLam,  c.TenDanToc, c.DanTocID, d.TenTonGiao, d.TonGiaoID, f.TenTinhThanh, f.TinhThanhID, e.TenBangCap, e.BangCapID, a.GhiChu, a.ImagePath
                                FROM tbl_HoSoNhanVien a 
                                INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID
                                INNER JOIN tbl_DanToc c ON a.DanTocID = c.DanTocID
                                INNER JOIN tbl_TonGiao d ON a.TonGiaoID = d.TonGiaoID
                                INNER JOIN tbl_BangCap e ON a.BangCapID = e.BangCapID
                                INNER JOIN tbl_TinhThanh f ON a.TinhThanhID = f.TinhThanhID";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static bool _addProfile(int nhanvienID, string ngayVaoLam, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID, string ghiChu, string path)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_HoSoNhanVien(NhanVienID, NgayVaoLam, DanTocID, TonGiaoID, TinhThanhID, BangCapID, GhiChu, ImagePath) VALUES ({0}, '{1}', {2}, {3}, {4}, {5}, N'{6}', '{7}')", nhanvienID, ngayVaoLam, danTocID, tonGiaoID, tinhThanhID, bangCapID, ghiChu, path);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _checkProfile(int nhanVienID)
        {
            string query = string.Format("SELECT * FROM tbl_HoSoNhanVien WHERE NhanVienID = {0}", nhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool _updateProfile(int nhanvienID, string ngayVaoLam, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID, string ghiChu, string path)
        {
            try
            {
                string query = string.Format("UPDATE tbl_HoSoNhanVien SET NgayVaoLam = '{0}', DanTocID = {1}, TonGiaoID = {2}, TinhThanhID = {3}, BangCapID = {4}, GhiChu = N'{5}', ImagePath = '{6}' WHERE NhanVienID = '{7}'", ngayVaoLam, danTocID, tonGiaoID, tinhThanhID, bangCapID, ghiChu, path, nhanvienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _delProfile(int nhanvienID, int danTocID, int tonGiaoID, int tinhThanhID, int bangCapID)
        {
            try
            {
                string query = string.Format("DELETE tbl_HoSoNhanVien WHERE NhanVienID = {0} AND DanTocID = {1} AND TonGiaoID = {2} AND TinhThanhID = {3} AND BangCapID = {4}", nhanvienID, danTocID, tonGiaoID, tinhThanhID, bangCapID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _getDeparment()
        {
            string query = "SELECT * FROM tbl_BoPhan";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static DataTable _getOffice()
        {
            string query = "SELECT * FROM tbl_ChucDanh";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static DataTable _getInfoNhanVienBoPhan()
        {
            string query = @"SELECT  a.NhanVienID, a.BoPhanID , b.TenNV, c.TenBoPhan
                            FROM((tbl_NhanVienBoPhan a inner join tbl_NhanVien b ON a.NhanVienID = b.NhanVienID) 
                            inner join tbl_BoPhan c ON a.BoPhanID = c.BoPhanID)";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        public static int _insertNhanVienBoPhan(int nhanVienID, int boPhanID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVienBoPhan(NhanVienID, BoPhanID) VALUES ({0},{1})", nhanVienID, boPhanID);
                cls_Database.AED(query);
                return 1;
            }
            catch (SqlException ex)
            {
                return ex.Number;
            }
        }

        public static bool _updateNhanVienBoPhan(int nhanVienID, int boPhanID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVienBoPhan SET BoPhanID = {0} WHERE NhanVienID = {1}", boPhanID, nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable _getNhanVienChucDanh()
        {
            string query = @"SELECT DISTINCT b.BoPhanID, b.TenBoPhan, f.TenChucDanh, f.TenNV, a.NhanVienID, f.ChucDanhID
                           FROM tbl_NhanVienBoPhan a
                           INNER JOIN tbl_BoPhan b ON a.BoPhanID = b.BoPhanID
                           INNER JOIN 
	                       (SELECT d.ChucDanhID, d.TenChucDanh, c.NhanVienID, e.TenNV
	                        FROM tbl_NhanVienChucDanh c
	                        INNER JOIN tbl_ChucDanh d ON c.ChucDanhID = d.ChucDanhID
	                        INNER JOIN tbl_NhanVien e ON c.NhanVienID = e.NhanVienID) 
		                    AS f ON a.NhanVienID = f.NhanVienID";
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }
        
        public static DataTable _getNhanVienBoPhanID(int boPhanID)
        {
            string query = string.Format("SELECT a.NhanVienID, a.TenNV FROM tbl_NhanVien a INNER JOIN tbl_NhanVienBoPhan b ON a.NhanVienID = b.NhanVienID and b.BoPhanID = {0}", boPhanID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static bool _insertNhanVienChucDanh(int nhanVienID, int chucDanhID)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhanVienChucDanh (NhanVienID, ChucDanhID) VALUES ({0}, {1})", nhanVienID, chucDanhID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _updateNhanVienChucDanh(int nhanVienID, int chucDanhID)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhanVienChucDanh SET ChucDanhID = {0} WHERE NhanVienID = {1}", chucDanhID, nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _deleteNhanVienChucDanh(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _checkNhanVienChucDanh(int nhanVienID)
        {
            string query = string.Format("SELECT * FROM tbl_NhanVienChucDanh WHERE NhanVienID = {0}", nhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool _delNhanVienBoPhan(int nhanVienID)
        {
            try
            {
                string query = string.Format("DELETE tbl_NhanVienBoPhan WHERE NhanVienID = {0}", nhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable _getProfileEmployess(int nhanVienID)
        {
            string query = string.Format(@"SELECT a.TenNV, a.DiaChi, a.Email, a.MaNV, a.NgaySinh, a.SDT, b.ImagePath, a.CMND, b.NgayVaoLam, c.TenDanToc, d.TenBangCap,  e.TenTinhThanh, f.TenTonGiao, g.GioiTinh 
                                            FROM tbl_NhanVien a 
                                            INNER JOIN tbl_HoSoNhanVien b on a.NhanVienID = b.NhanVienID
                                            INNER JOIN tbl_DanToc c on b.DanTocID = c.DanTocID
                                            INNER JOIN tbl_BangCap d on b.BangCapID = d.BangCapID
                                            INNER JOIN tbl_TinhThanh e on b.TinhThanhID = e.TinhThanhID
                                            INNER JOIN tbl_TonGiao f on b.TonGiaoID = f.TonGiaoID
                                            INNER JOIN tbl_GioiTinh g on g.GioiTinhID = a.GioiTinhID
                                            WHERE a.NhanVienID = '{0}'", nhanVienID);
            return cls_Database.TableRead(query);
        }
        
        public static bool _checkPassword(string password, string id)
        {
            string query = string.Format("SELECT MatKhau FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", id);
            DataTable dt = cls_Database.TableRead(query);
            string pass = dt.Rows[0]["MatKhau"].ToString();
            if (pass != password)
            {
                return false;
            }
            return true;
        }

        public static bool _updatePassword(string password, string id)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NguoiDung SET MatKhau = '{0}' WHERE NguoiDungID = '{1}'", password, id);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _getUserPermission()
        {
            string query = @"SELECT a.NguoiDungID, b.NhanVienID, c.BoPhanID, d.TenBoPhan,  b.MaNV, b.TenNV, a.TenDangNhap, a.MatKhau, a.QuanTri 
                            FROM tbl_NguoiDung a
                            INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID
                            INNER JOIN tbl_NhanVienBoPhan c ON a.NhanVienID = c.NhanVienID
                            INNER JOIN tbl_BoPhan d ON d.BoPhanID = c.BoPhanID";
            return cls_Database.TableRead(query);
        }

        public static bool _delUserPermission(int NguoiDungID)
        {
            try
            {
                if (_delPermission(NguoiDungID))
                {
                    string query = string.Format("DELETE FROM tbl_NguoiDung WHERE NguoiDungID = '{0}'", NguoiDungID);
                    cls_Database.AED(query);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _delPermission(int NguoiDungID)
        {
            try
            {
                string query = string.Format("DELETE FROM tbl_QuyenNguoiDung WHERE NguoiDungID = '{0}'", NguoiDungID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _insertUserPermission(string TenDangNhap, string MatKhau, int QuanTri, int NhanVienID)
        { 
            try
            {
                string query = string.Format("INSERT INTO tbl_NguoiDung(TenDangNhap, MatKhau, QuanTri, NhanVienID) VAlUES (N'{0}', '{1}', {2}, '{3}')", TenDangNhap, MatKhau, QuanTri, NhanVienID);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _checkNameUser(string name)
        {
            string query = string.Format("SELECT TenDangNhap FROM tbl_NguoiDung WHERE TenDangNhap = N'{0}'", name);
            DataTable dt = BusinessLayer.cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool _checkUserPermission(int NhanVienID)
        {
            string query = string.Format("SELECT NhanVienID FROM tbl_NguoiDung WHERE NhanVienID = '{0}'", NhanVienID);
            DataTable dt = BusinessLayer.cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool _updateUserPermission(string TenDangNhap, string MatKhau, int QuanTri, int NhanVienID, int NguoiDungID)
        {
            try
            {
                string query = "";
                if (MatKhau == "")
                {
                    query = string.Format("UPDATE tbl_NguoiDung SET TenDangNhap = N'{0}', QuanTri = {1}, NhanVienID = {2} WHERE NguoiDungID = {3}", TenDangNhap, QuanTri, NhanVienID, NguoiDungID);

                }
                else
                {
                    query = string.Format("UPDATE tbl_NguoiDung SET TenDangNhap = N'{0}', MatKhau = '{1}', QuanTri = {2}, NhanVienID = {3} WHERE NguoiDungID = {4}", TenDangNhap, MatKhau, QuanTri, NhanVienID, NguoiDungID);
                }
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _getUserPermission(int NhanVienID)
        {
            string query = string.Format(@"SELECT a.NguoiDungID, a.TenDangNhap 
                                        FROM tbl_NguoiDung a 
                                        INNER JOIN tbl_NhanVien b ON a.NhanVienID = b.NhanVienID and b.NhanVienID = {0}", NhanVienID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static DataTable _getNghiepVu(int NguoiDungID)
        {
            string query = string.Format("SELECT NghiepVuID FROM tbl_QuyenNguoiDung WHERE NguoiDungID = {0}", NguoiDungID);
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static bool _insertPermission(int NguoiDungID, int Permission)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_QuyenNguoiDung(NguoiDungID, NghiepVuID) VALUES ({0}, {1})", NguoiDungID, Permission);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
