using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class DAL_nhacungcap
    {
        Function lopchung = new Function();

        public int Themncc(string mancc, string tenncc)
        {

            string sql = "Insert into NHACUNGCAP values(N'" + mancc + "',N'" + tenncc + "')";
            return lopchung.AddDel(sql);
        }
        public int Suancc(string mancc, string tenncc)
        {
            string sql = "Update NHACUNGCAP set TenNCC =N'" + tenncc + "'where MaNCC = '" + mancc + "'";
            return lopchung.AddDel(sql);
        }
        public int Xoancc(string mancc)
        {
            string sql = "Delete NHACUNGCAP where MaNCC = N'" + mancc + "'";
            return lopchung.AddDel(sql);

        }
        public DataTable Loadncc()
        {
            string sql = "Select * from NHACUNGCAP";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
