using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    class Function
    {
        SqlConnection connec;
        string str_connec = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\SQLSEVER\\QuanLyBanHang.mdf;Integrated Security = True";

        public Function()
        {
            connec = new SqlConnection(str_connec); 
        }

        public SqlConnection connection()
        {
            SqlConnection connec = new SqlConnection(str_connec);
            return connec;
        }

        public int AddDel(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, connec);
            if (connec.State != ConnectionState.Open)
            {
                connec.Open();
            }
            int ketqua = comm.ExecuteNonQuery();
            {
                if (connec.State != ConnectionState.Closed) 
                {
                    connec.Close();
                }

            }
            return ketqua;
        }
        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, connec);
            if (connec.State != ConnectionState.Open)
            {
                connec.Open();
            }
            object ketqua = comm.ExecuteScalar();
            {
                if (connec.State != ConnectionState.Closed) 
                {
                    connec.Close();
                }

            }
            return ketqua;

        }

        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connec);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
