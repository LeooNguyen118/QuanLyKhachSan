
namespace QuanLyKhachSan
{
    partial class DatService
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblTThanhTien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cbNamePV = new System.Windows.Forms.ComboBox();
            this.lblLoaiPV = new System.Windows.Forms.Label();
            this.cbLoaiPV = new System.Windows.Forms.ComboBox();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvGioHang = new System.Windows.Forms.ListView();
            this.tenPV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaPV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.lblTTongCong = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.lblTThanhTien);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.cbNamePV);
            this.groupBox1.Controls.Add(this.lblLoaiPV);
            this.groupBox1.Controls.Add(this.cbLoaiPV);
            this.groupBox1.Controls.Add(this.cbSoPhong);
            this.groupBox1.Controls.Add(this.lblSoPhong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt phục vụ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(9, 198);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(188, 23);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(64, 129);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 20);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(77, 163);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(18, 20);
            this.lblThanhTien.TabIndex = 4;
            this.lblThanhTien.Text = "0";
            // 
            // lblTThanhTien
            // 
            this.lblTThanhTien.AutoSize = true;
            this.lblTThanhTien.Location = new System.Drawing.Point(6, 168);
            this.lblTThanhTien.Name = "lblTThanhTien";
            this.lblTThanhTien.Size = new System.Drawing.Size(65, 13);
            this.lblTThanhTien.TabIndex = 4;
            this.lblTThanhTien.Text = "Thành Tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(6, 131);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cbNamePV
            // 
            this.cbNamePV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamePV.FormattingEnabled = true;
            this.cbNamePV.Location = new System.Drawing.Point(9, 96);
            this.cbNamePV.Name = "cbNamePV";
            this.cbNamePV.Size = new System.Drawing.Size(188, 21);
            this.cbNamePV.TabIndex = 3;
            this.cbNamePV.SelectedIndexChanged += new System.EventHandler(this.cbNamePV_SelectedIndexChanged);
            // 
            // lblLoaiPV
            // 
            this.lblLoaiPV.AutoSize = true;
            this.lblLoaiPV.Location = new System.Drawing.Point(6, 64);
            this.lblLoaiPV.Name = "lblLoaiPV";
            this.lblLoaiPV.Size = new System.Drawing.Size(74, 13);
            this.lblLoaiPV.TabIndex = 2;
            this.lblLoaiPV.Text = "Loại Phục Vụ:";
            // 
            // cbLoaiPV
            // 
            this.cbLoaiPV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPV.FormattingEnabled = true;
            this.cbLoaiPV.Items.AddRange(new object[] {
            "Dịch Vụ",
            "Món Ăn"});
            this.cbLoaiPV.Location = new System.Drawing.Point(86, 61);
            this.cbLoaiPV.Name = "cbLoaiPV";
            this.cbLoaiPV.Size = new System.Drawing.Size(111, 21);
            this.cbLoaiPV.TabIndex = 2;
            this.cbLoaiPV.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPV_SelectedIndexChanged);
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Items.AddRange(new object[] {
            "-------",
            "001",
            "002",
            "003",
            "004"});
            this.cbSoPhong.Location = new System.Drawing.Point(64, 25);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(133, 21);
            this.cbSoPhong.TabIndex = 1;
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(6, 28);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(56, 13);
            this.lblSoPhong.TabIndex = 0;
            this.lblSoPhong.Text = "Số phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.lvGioHang);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.lblTongCong);
            this.groupBox2.Controls.Add(this.lblTTongCong);
            this.groupBox2.Location = new System.Drawing.Point(221, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 227);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 198);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvGioHang
            // 
            this.lvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenPV,
            this.soLuong,
            this.giaPV});
            this.lvGioHang.FullRowSelect = true;
            this.lvGioHang.HideSelection = false;
            this.lvGioHang.Location = new System.Drawing.Point(7, 20);
            this.lvGioHang.MultiSelect = false;
            this.lvGioHang.Name = "lvGioHang";
            this.lvGioHang.Size = new System.Drawing.Size(297, 141);
            this.lvGioHang.TabIndex = 7;
            this.lvGioHang.UseCompatibleStateImageBehavior = false;
            this.lvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // tenPV
            // 
            this.tenPV.Text = "Tên";
            this.tenPV.Width = 131;
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số Lượng";
            // 
            // giaPV
            // 
            this.giaPV.Text = "Thành Tiền";
            this.giaPV.Width = 101;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongCong.Location = new System.Drawing.Point(160, 171);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(18, 20);
            this.lblTongCong.TabIndex = 4;
            this.lblTongCong.Text = "0";
            // 
            // lblTTongCong
            // 
            this.lblTTongCong.AutoSize = true;
            this.lblTTongCong.Location = new System.Drawing.Point(89, 176);
            this.lblTTongCong.Name = "lblTTongCong";
            this.lblTTongCong.Size = new System.Drawing.Size(63, 13);
            this.lblTTongCong.TabIndex = 4;
            this.lblTTongCong.Text = "Tổng Cộng:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(201, 245);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(188, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Thoát";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // DatService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 271);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DatService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phục Vụ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cbNamePV;
        private System.Windows.Forms.Label lblLoaiPV;
        private System.Windows.Forms.ComboBox cbLoaiPV;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblTThanhTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvGioHang;
        private System.Windows.Forms.ColumnHeader tenPV;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader giaPV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label lblTTongCong;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRefresh;
    }
}