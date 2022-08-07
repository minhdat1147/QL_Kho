using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using POJO;
namespace DAO
{
    public class DAL_HD:DBConnect
    {    
        public DataTable Timkiem(string makh)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hoadon where makh='" + makh + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool them(POJO.DTO_CTHD ncc)
        {
            try 
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO CHITIETHD VALUES ({0}, N'{1}',{2},{3},{4})", ncc.Mahd, ncc.Tendu, ncc.Sl, ncc.Dongia, ncc.Thanhtien);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
        public DataTable Timkiem1(int mahd)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM chitiethd where mahd=" + mahd + "", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool sua(POJO.DTO_HD ncc)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("update hoadon set makh='{1}' , tongtien={2} where mahd={0}", ncc.Mahd,ncc.Makh,ncc.Tongtien);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
