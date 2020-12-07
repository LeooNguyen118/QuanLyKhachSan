
namespace QuanLyKhachSan
{
    partial class PageThongKeNgay
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
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lvThongKe = new System.Windows.Forms.ListView();
            this.soPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayDen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongCong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTongCong = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(260, 17);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(41, 16);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(307, 15);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // lvThongKe
            // 
            this.lvThongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.soPhong,
            this.ngayDen,
            this.tongPhong,
            this.tongDichVu,
            this.tongCong});
            this.lvThongKe.HideSelection = false;
            this.lvThongKe.Location = new System.Drawing.Point(3, 51);
            this.lvThongKe.Name = "lvThongKe";
            this.lvThongKe.Size = new System.Drawing.Size(698, 277);
            this.lvThongKe.TabIndex = 2;
            this.lvThongKe.UseCompatibleStateImageBehavior = false;
            this.lvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // soPhong
            // 
            this.soPhong.Text = "Số Phòng";
            this.soPhong.Width = 89;
            // 
            // ngayDen
            // 
            this.ngayDen.Text = "Ngày đến";
            this.ngayDen.Width = 144;
            // 
            // tongPhong
            // 
            this.tongPhong.Text = "Tiền Phòng";
            this.tongPhong.Width = 147;
            // 
            // tongDichVu
            // 
            this.tongDichVu.Text = "Tổng Tiền Dịch Vụ";
            this.tongDichVu.Width = 152;
            // 
            // tongCong
            // 
            this.tongCong.Text = "Tổng cộng";
            this.tongCong.Width = 156;
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Location = new System.Drawing.Point(3, 334);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(83, 18);
            this.lblTongCong.TabIndex = 3;
            this.lblTongCong.Text = "Tổng cộng:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(356, 334);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageThongKeNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.lvThongKe);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.lblNgay);
            this.Name = "PageThongKeNgay";
            this.Size = new System.Drawing.Size(704, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ListView lvThongKe;
        private System.Windows.Forms.ColumnHeader soPhong;
        private System.Windows.Forms.ColumnHeader ngayDen;
        private System.Windows.Forms.ColumnHeader tongPhong;
        private System.Windows.Forms.ColumnHeader tongDichVu;
        private System.Windows.Forms.ColumnHeader tongCong;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Button btnRefresh;
    }
}
