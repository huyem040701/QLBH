using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAL
{
    class DAL_hanghoa
    {
        Function classmate = new Function();// khỏi tạo lớp

        public int Themhang(string mah, string mancc, string tenhang, string soluong, string dongianhap, string dongiaban)
        {
            // chèn vào bảng hàng hóa giá trị ô 
            string sql = "Insert into HANGHOA values(N'" + mah + "',N'" + mancc + "',N'" + tenhang + "',N'" + soluong + "',N'" + dongianhap + "',N'" + dongiaban + "')";
            return classmate.AddDel(sql);
        }
        public int Suahang(string mah, string mancc, string tenhang, string soluong, string dongianhap, string dongiaban)
        {
            string sql = "Update HANGHOA set TenHANG =N'" + tenhang + "',SoLuONG =N'" + soluong + "',DonGIANHAP =N'" + dongianhap + "',DonGIABAN =N'" + dongiaban + "',MaNCC =N'" + mancc + "'where MaH = '" + mah + "'";
            return classmate.AddDel(sql);
        }
        public int Xoahang(string mah)
        {
            string sql = "Delete HANGHOA where MaH = N'" + mah + "'";
            return classmate.AddDel(sql);

        }

        public DataTable Loadhh()
        {
            string sql = "Select * from HANGHOA";// từ sql chọn form hàng hóa
            return classmate.LoadDuLieu(sql);

        }
    }
}
