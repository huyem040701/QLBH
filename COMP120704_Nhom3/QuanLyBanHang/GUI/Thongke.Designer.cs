namespace QuanLyBanHang.GUI
{
    partial class Thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.btnTimTheoKhoangtg = new System.Windows.Forms.Button();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Location = new System.Drawing.Point(16, 255);
            this.dgv_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersWidth = 51;
            this.dgv_thongke.Size = new System.Drawing.Size(826, 254);
            this.dgv_thongke.TabIndex = 96;
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "MM/dd/yyyy";
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(239, 32);
            this.dt_timesau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(197, 30);
            this.dt_timesau.TabIndex = 85;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Cyan;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Image = global::QuanLyBanHang.Properties.Resources.Find;
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(231, 79);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(241, 59);
            this.btn_load.TabIndex = 86;
            this.btn_load.Text = "Tìm tất cả hóa đơn";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "MM/dd/yyyy";
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(8, 32);
            this.dt_timetruoc.Margin = new System.Windows.Forms.Padding(4);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(184, 30);
            this.dt_timetruoc.TabIndex = 84;
            // 
            // btnTimTheoKhoangtg
            // 
            this.btnTimTheoKhoangtg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimTheoKhoangtg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTheoKhoangtg.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoKhoangtg.Image = global::QuanLyBanHang.Properties.Resources.Find;
            this.btnTimTheoKhoangtg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTheoKhoangtg.Location = new System.Drawing.Point(0, 78);
            this.btnTimTheoKhoangtg.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimTheoKhoangtg.Name = "btnTimTheoKhoangtg";
            this.btnTimTheoKhoangtg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTimTheoKhoangtg.Size = new System.Drawing.Size(193, 59);
            this.btnTimTheoKhoangtg.TabIndex = 4;
            this.btnTimTheoKhoangtg.Text = "Tìm";
            this.btnTimTheoKhoangtg.UseVisualStyleBackColor = false;
            this.btnTimTheoKhoangtg.Click += new System.EventHandler(this.btnTimTheoKhoangtg_Click);
            // 
            // txt_tong
            // 
            this.txt_tong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong.Location = new System.Drawing.Point(540, 176);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(219, 33);
            this.txt_tong.TabIndex = 100;
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Transparent;
            this.btn_tinhtong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtong.Location = new System.Drawing.Point(567, 103);
            this.btn_tinhtong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(192, 51);
            this.btn_tinhtong.TabIndex = 99;
            this.btn_tinhtong.Text = "Tính tổng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 45);
            this.label2.TabIndex = 98;
            this.label2.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_timesau);
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.dt_timetruoc);
            this.groupBox3.Controls.Add(this.btnTimTheoKhoangtg);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(480, 148);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm theo thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "VNĐ";
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(877, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_thongke);
            this.Controls.Add(this.txt_tong);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_thongke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_thongke;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.Button btnTimTheoKhoangtg;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}