
namespace QuanLyKhachSan
{
    partial class PageThongKeCongNo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvThongKe = new System.Windows.Forms.ListView();
            this.ngayDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datCoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phaiThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvThongKe
            // 
            this.lvThongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ngayDi,
            this.soPhong,
            this.khachHang,
            this.datCoc,
            this.phaiThu});
            this.lvThongKe.HideSelection = false;
            this.lvThongKe.Location = new System.Drawing.Point(3, 3);
            this.lvThongKe.Name = "lvThongKe";
            this.lvThongKe.Size = new System.Drawing.Size(698, 325);
            this.lvThongKe.TabIndex = 5;
            this.lvThongKe.UseCompatibleStateImageBehavior = false;
            this.lvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // ngayDi
            // 
            this.ngayDi.Text = "Ngày Đi";
            this.ngayDi.Width = 113;
            // 
            // soPhong
            // 
            this.soPhong.Text = "Số Phòng";
            this.soPhong.Width = 84;
            // 
            // khachHang
            // 
            this.khachHang.Text = "Tên Khách Hàng";
            this.khachHang.Width = 165;
            // 
            // datCoc
            // 
            this.datCoc.Text = "Tiền Đặt Cọc";
            this.datCoc.Width = 147;
            // 
            // phaiThu
            // 
            this.phaiThu.Text = "Còn lại phải thu";
            this.phaiThu.Width = 124;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(180, 334);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageThongKeCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvThongKe);
            this.Name = "PageThongKeCongNo";
            this.Size = new System.Drawing.Size(704, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThongKe;
        private System.Windows.Forms.ColumnHeader soPhong;
        private System.Windows.Forms.ColumnHeader khachHang;
        private System.Windows.Forms.ColumnHeader datCoc;
        private System.Windows.Forms.ColumnHeader phaiThu;
        private System.Windows.Forms.ColumnHeader ngayDi;
        private System.Windows.Forms.Button btnRefresh;
    }
}
