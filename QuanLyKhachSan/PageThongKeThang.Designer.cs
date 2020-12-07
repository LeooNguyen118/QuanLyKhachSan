
namespace QuanLyKhachSan
{
    partial class PageThongKeThang
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
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongCong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.lblThang = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvThongKe
            // 
            this.lvThongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ngay,
            this.tongPhong,
            this.tongDichVu,
            this.tongCong});
            this.lvThongKe.HideSelection = false;
            this.lvThongKe.Location = new System.Drawing.Point(3, 51);
            this.lvThongKe.Name = "lvThongKe";
            this.lvThongKe.Size = new System.Drawing.Size(698, 278);
            this.lvThongKe.TabIndex = 5;
            this.lvThongKe.UseCompatibleStateImageBehavior = false;
            this.lvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày";
            this.ngay.Width = 138;
            // 
            // tongPhong
            // 
            this.tongPhong.Text = "Tiền Phòng";
            this.tongPhong.Width = 147;
            // 
            // tongDichVu
            // 
            this.tongDichVu.Text = "Tổng Tiền Dịch Vụ";
            this.tongDichVu.Width = 163;
            // 
            // tongCong
            // 
            this.tongCong.Text = "Tổng cộng";
            this.tongCong.Width = 189;
            // 
            // dtpThang
            // 
            this.dtpThang.Location = new System.Drawing.Point(307, 15);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(200, 20);
            this.dtpThang.TabIndex = 4;
            this.dtpThang.ValueChanged += new System.EventHandler(this.dtpThang_ValueChanged);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(260, 17);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(47, 16);
            this.lblThang.TabIndex = 3;
            this.lblThang.Text = "Tháng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(356, 335);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Location = new System.Drawing.Point(3, 335);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(83, 18);
            this.lblTongCong.TabIndex = 7;
            this.lblTongCong.Text = "Tổng cộng:";
            // 
            // PageThongKeThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvThongKe);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.lblThang);
            this.Name = "PageThongKeThang";
            this.Size = new System.Drawing.Size(704, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvThongKe;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader tongPhong;
        private System.Windows.Forms.ColumnHeader tongDichVu;
        private System.Windows.Forms.ColumnHeader tongCong;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTongCong;
    }
}
