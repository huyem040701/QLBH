using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();//dùng để khởi tạo các đối tượng có trên form như textbox,combobox.
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Nhanvien"] == null)
            {
                Nhanvien ttkh = new Nhanvien();
                ttkh.MdiParent = this;//thuộc tính  MdiParent dùng để thiết lập Form Cha của các Form này là frmMain
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["Nhanvien"].Activate();
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Information"] == null)
            {
                Information tt = new Information();
                tt.MdiParent = this;
                tt.Show();
            }
            else
            {
                Application.OpenForms["Information"].Activate();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Thongke"] == null)
            {
                Thongke ttkh = new Thongke();
                ttkh.MdiParent = this;
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["Thongke"].Activate();
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Hoadon"] == null)
            {
                Hoadon tthd = new Hoadon();
                tthd.MdiParent = this;
                tthd.Show();
            }
            else
            {
                Application.OpenForms["Hoadon"].Activate();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Khachhang"] == null)
            {
                Khachhang ttkh = new Khachhang();
                ttkh.MdiParent = this; //thuộc tính  MdiParent dùng để thiết lập Form Cha của các Form này là frmMain
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["Khachhang"].Activate();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Hanghoa"] == null)
            {
                Hanghoa tthh = new Hanghoa();
                tthh.MdiParent = this;//thuộc tính  MdiParent dùng để thiết lập Form Cha của các Form này là frmMain
                tthh.Show();
            }
            else
            {
                Application.OpenForms["Hanghoa"].Activate();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Nhacungcap"] == null)
            {
                Nhacungcap ttkh = new Nhacungcap();
                ttkh.MdiParent = this;//thuộc tính  MdiParent dùng để thiết lập Form Cha của các Form này là Main
                ttkh.Show();//hiện form
            }
            else
            {
                Application.OpenForms["Nhacungcap"].Activate();
            }
        }
    }
}
