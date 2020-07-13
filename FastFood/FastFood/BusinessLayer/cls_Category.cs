using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLayer
{
    class cls_Category
    {
        public static DataTable _get(string id, string name, string tbl)
        {
            string query = string.Format("SELECT {0}, {1} FROM {2}", id, name, tbl);
            return cls_Database.TableRead(query);
        }

        public static bool _insert(string tbl, string column, string value)
        {
            try
            {
                string query = string.Format("INSERT INTO {0}({1}) VALUES (N'{2}')", tbl, column, value);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool _update(string tbl, string column1, string column2, string value1, int value2)
        {
            try
            {
                string query = string.Format("UPDATE {0} SET {1} = N'{2}' WHERE {3} = '{4}'", tbl, column1, value1, column2 ,value2);
                cls_Database.AED(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool _check(string column, string tbl, int value)
        {
            string query = string.Format("SELECT {0} FROM {1} WHERE {0} = '{2}'", column, tbl, value);
            DataTable dt = cls_Database.TableRead(query);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static int _del(string column, string tbl1, string tbl2, int value)
        {
            try
            {
                if (!_check(column, tbl2, value))
                {
                    return 0;
                }
                string query = string.Format("DELETE {0} WHERE {1} = '{2}'", tbl1, column, value);
                cls_Database.AED(query);
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
