using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Login : Form
    {
        Function Classmate = new Function();
        public Login()
        {
            InitializeComponent();//dùng để khởi tạo các đối tượng có trên form như textbox,combobox.
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;//Message Box: Dạng thông báo có lựa chọn Yes hoặc No.
            dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) // Nếu lựa chọn yes 
            {
                Application.Exit();// thì thoát chương trình
            }
        }
        int k = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            /* string User = "huyem";
             string Pass = "123456";
                 if (User.Equals(txt_taikhoan.Text) && Pass.Equals(txt_matkhau.Text))*/
            // Từ SQL chọn từ TAIKHOAN = với txtbox TK và MK
            string sql = "select count(*) from TAIKHOAN where TK = '" + txt_taikhoan.Text + "'and MK = '" + txt_matkhau.Text + "'";
            int kq = (int)Classmate.ExcuteScalar(sql);//phương thức ExecuteScalar thì nó sẽ thi hành câu lệnh SQL và trả về 1 giá trị là cột đầu tiên của dòng đầu tiên là 0 với 1

            if (kq > 0)
            {               
                Main main = new Main();// khởi tạo form
                main.Show();// hiện form Main
                this.Hide();// ẩn form hiện tại
            }
            else
            {
                k++;
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại");
                txt_taikhoan.Text = "";// gán textbox rỗng
                txt_matkhau.Text = "";
                txt_taikhoan.Focus();// đưa con trỏ về ô tài khooản
                if (k == 2)
                {
                    MessageBox.Show("Bạn đã nhập sai 2 lần, chương trình sẽ đóng");
                    Application.Exit();
                }
            }         

        }   

    }
    
    
}
