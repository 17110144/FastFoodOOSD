using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FastFood.BusinessLayer
{
    class cls_Product
    {
        public static DataTable _showProduct(int choose)
        {
            string query = string.Format("SELECT a.MaSP, a.TenSP, b.NCCID,  b.TenNhaCungCap, a.GiaTien, a.GiamGia, a.SoLuong FROM tbl_SanPham a, tbl_NhaCungCap b WHERE b.NCCID = a.NCCID and LoaiSPID ={0}", choose);
            return cls_Database.TableRead(query);
        }

        public static DataTable _showNCC()
        {
            string query = string.Format("SELECT * FROM tbl_NhaCungCap");
            return cls_Database.TableRead(query);
        }

        public static bool _delProduct(string id)
        {
            try
            {
                string query = string.Format("DELETE FROM tbl_SanPham WHERE MaSP = '{0}'", id);
                cls_Database.AED(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static DataTable _checkProduct(string id)
        {
            string query = string.Format("SELECT * FROM tbl_CTHD WHERE MaSP = '{0}'", id);
            return cls_Database.TableRead(query);
        }

        public static bool _updateProduct(string id, string name, int nccid, int price, int discount, int num)
        {
            try
            {
                string query = string.Format("UPDATE tbl_SanPham SET TenSP = N'{0}', NCCID = {1}, GiaTien = {2} , GiamGia = {3}, SoLuong = {4} WHERE MaSP = '{5}'", name, nccid, price, discount, num, id);
                cls_Database.AED(query);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public static DataTable _searchProduct(int choose, string name, string tbl)
        {
            string query = string.Format("SELECT a.MaSP, a.TenSP, b.NCCID, b.TenNhaCungCap, a.GiaTien, a.GiamGia, a.SoLuong FROM tbl_SanPham a inner join tbl_NhaCungCap b ON b.NCCID = a.NCCID WHERE (a.LoaiSPID = {0} and a.{1} LIKE N'{2}%') OR  (a.LoaiSPID = {0} and a.{1} LIKE N'%{2}%') OR ( a.LoaiSPID = {0} and a.{1} LIKE N'%{2}') ", choose, tbl, name);
            return cls_Database.TableRead(query);
        }

        public static bool _addProduct(int choose, string id, string name, int nccid, int price, int discount, int num)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_SanPham(MaSP, TenSP, NCCID, GiaTien, GiamGia, SoLuong, LoaiSPID) VALUES (N'{0}', N'{1}', {2}, {3}, {4}, {5}, {6})", id, name, nccid, price, discount, num, choose);
                cls_Database.AED(query);
                return true;
            }

            catch(Exception)
            {
                return false;
            }
        }

        public static DataTable _getIDProduct()
        {
            string query = string.Format("SELECT MaSP FROM tbl_SanPham");
            DataTable dt = cls_Database.TableRead(query);
            return dt;
        }

        public static DataTable _showProductType()
        {
            string query = string.Format("SELECT LoaiSPID, TenLoaiSP FROM tbl_LoaiSP");
            return cls_Database.TableRead(query);
        }

        public static bool _updateProductType(int id, string nameProductType)
        {
            try
            {
                string query = string.Format("UPDATE tbl_LoaiSP SET TenLoaiSP = N'{0}' WHERE LoaiSPID = '{1}'", nameProductType, id);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _addNCC(string nameNCC)
        {
            try
            {
                string query = string.Format("INSERT INTO tbl_NhaCungCap(TenNhaCungCap) VALUES (N'{0}')", nameNCC);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _delNCC(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM tbl_NhaCungCap WHERE NCCID = '{0}'", id);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static DataTable _checkNCC(int id)
        {
            string query = string.Format("SELECT NCCID FROM tbl_SanPham WHERE NCCID = '{0}'", id);
            return cls_Database.TableRead(query);
        }

        public static bool _updateNCC(int id, string nameNCC)
        {
            try
            {
                string query = string.Format("UPDATE tbl_NhaCungCap SET TenNhaCungCap = N'{0}' WHERE NCCID = '{1}'", nameNCC, id);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable _showDetailNCC()
        {
            string query = string.Format("SELECT NCCID , TenNhaCungCap FROM tbl_NhaCungCap");
            return cls_Database.TableRead(query);
        }
    }
}
