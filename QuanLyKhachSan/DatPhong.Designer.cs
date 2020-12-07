
namespace QuanLyKhachSan
{
    partial class DatPhong
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
            this.gbAddKH = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTSDT = new System.Windows.Forms.Label();
            this.lblTCMND = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTTongTien = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTSoPhong = new System.Windows.Forms.Label();
            this.cbCMND = new System.Windows.Forms.ComboBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDatCoc = new System.Windows.Forms.Label();
            this.tbDatCoc = new System.Windows.Forms.TextBox();
            this.lblSLNguoi = new System.Windows.Forms.Label();
            this.tbSLNguoi = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cbCoupon = new System.Windows.Forms.ComboBox();
            this.gbAddKH.SuspendLayout();
            this.gbRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddKH
            // 
            this.gbAddKH.Controls.Add(this.cbType);
            this.gbAddKH.Controls.Add(this.tbEmail);
            this.gbAddKH.Controls.Add(this.tbSDT);
            this.gbAddKH.Controls.Add(this.tbCMND);
            this.gbAddKH.Controls.Add(this.tbName);
            this.gbAddKH.Controls.Add(this.lblTType);
            this.gbAddKH.Controls.Add(this.lblEmail);
            this.gbAddKH.Controls.Add(this.lblTSDT);
            this.gbAddKH.Controls.Add(this.lblTCMND);
            this.gbAddKH.Controls.Add(this.lblTName);
            this.gbAddKH.Location = new System.Drawing.Point(13, 45);
            this.gbAddKH.Name = "gbAddKH";
            this.gbAddKH.Size = new System.Drawing.Size(316, 191);
            this.gbAddKH.TabIndex = 0;
            this.gbAddKH.TabStop = false;
            this.gbAddKH.Text = "Thêm Khách Hàng";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Trong Nước",
            "Ngoài Nước"});
            this.cbType.Location = new System.Drawing.Point(81, 155);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(229, 21);
            this.cbType.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(55, 121);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(255, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Text = "@";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(92, 92);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(218, 20);
            this.tbSDT.TabIndex = 6;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(59, 60);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(251, 20);
            this.tbCMND.TabIndex = 4;
            this.tbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(43, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(267, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(6, 156);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(70, 15);
            this.lblTType.TabIndex = 22;
            this.lblTType.Text = "Loại khách:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email:";
            // 
            // lblTSDT
            // 
            this.lblTSDT.AutoSize = true;
            this.lblTSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSDT.Location = new System.Drawing.Point(6, 93);
            this.lblTSDT.Name = "lblTSDT";
            this.lblTSDT.Size = new System.Drawing.Size(82, 15);
            this.lblTSDT.TabIndex = 24;
            this.lblTSDT.Text = "Số điện thoại:";
            // 
            // lblTCMND
            // 
            this.lblTCMND.AutoSize = true;
            this.lblTCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCMND.Location = new System.Drawing.Point(6, 61);
            this.lblTCMND.Name = "lblTCMND";
            this.lblTCMND.Size = new System.Drawing.Size(47, 15);
            this.lblTCMND.TabIndex = 25;
            this.lblTCMND.Text = "CMND:";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.Location = new System.Drawing.Point(6, 27);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(31, 15);
            this.lblTName.TabIndex = 26;
            this.lblTName.Text = "Tên:";
            // 
            // gbRoom
            // 
            this.gbRoom.Controls.Add(this.cbSoPhong);
            this.gbRoom.Controls.Add(this.dtpNgayDi);
            this.gbRoom.Controls.Add(this.lblTongTien);
            this.gbRoom.Controls.Add(this.lblTTongTien);
            this.gbRoom.Controls.Add(this.lblDay);
            this.gbRoom.Controls.Add(this.lblLoaiPhong);
            this.gbRoom.Controls.Add(this.lblDonGia);
            this.gbRoom.Controls.Add(this.lblTSoPhong);
            this.gbRoom.Location = new System.Drawing.Point(336, 18);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(316, 218);
            this.gbRoom.TabIndex = 0;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Thông tin phòng đặt";
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cbSoPhong.Location = new System.Drawing.Point(109, 25);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(200, 21);
            this.cbSoPhong.TabIndex = 1;
            this.cbSoPhong.SelectedIndexChanged += new System.EventHandler(this.cbSoPhong_SelectedIndexChanged);
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Location = new System.Drawing.Point(90, 103);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(219, 20);
            this.dtpNgayDi.TabIndex = 2;
            this.dtpNgayDi.ValueChanged += new System.EventHandler(this.dtpNgayDi_ValueChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(170, 183);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 20);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "900000000";
            // 
            // lblTTongTien
            // 
            this.lblTTongTien.AutoSize = true;
            this.lblTTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTongTien.Location = new System.Drawing.Point(56, 187);
            this.lblTTongTien.Name = "lblTTongTien";
            this.lblTTongTien.Size = new System.Drawing.Size(108, 16);
            this.lblTTongTien.TabIndex = 14;
            this.lblTTongTien.Text = "Tổng tiền phòng:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(19, 103);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(65, 20);
            this.lblDay.TabIndex = 16;
            this.lblDay.Text = "Ngày đi:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(19, 64);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(93, 20);
            this.lblLoaiPhong.TabIndex = 16;
            this.lblLoaiPhong.Text = "Loại Phòng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(19, 144);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(68, 20);
            this.lblDonGia.TabIndex = 16;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblTSoPhong
            // 
            this.lblTSoPhong.AutoSize = true;
            this.lblTSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSoPhong.Location = new System.Drawing.Point(19, 27);
            this.lblTSoPhong.Name = "lblTSoPhong";
            this.lblTSoPhong.Size = new System.Drawing.Size(83, 20);
            this.lblTSoPhong.TabIndex = 17;
            this.lblTSoPhong.Text = "Số Phòng:";
            // 
            // cbCMND
            // 
            this.cbCMND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCMND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCMND.FormattingEnabled = true;
            this.cbCMND.Items.AddRange(new object[] {
            "Thêm mới",
            "123456789",
            "987654321",
            "135792468",
            "246813579"});
            this.cbCMND.Location = new System.Drawing.Point(131, 18);
            this.cbCMND.Name = "cbCMND";
            this.cbCMND.Size = new System.Drawing.Size(198, 21);
            this.cbCMND.TabIndex = 0;
            this.cbCMND.SelectedIndexChanged += new System.EventHandler(this.cbCMND_SelectedIndexChanged);
            this.cbCMND.TextChanged += new System.EventHandler(this.cbCMND_TextChanged);
            this.cbCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(20, 21);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(105, 13);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND Khách Hàng:";
            // 
            // lblDatCoc
            // 
            this.lblDatCoc.AutoSize = true;
            this.lblDatCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatCoc.Location = new System.Drawing.Point(12, 244);
            this.lblDatCoc.Name = "lblDatCoc";
            this.lblDatCoc.Size = new System.Drawing.Size(108, 20);
            this.lblDatCoc.TabIndex = 14;
            this.lblDatCoc.Text = "Đặt cọc trước:";
            // 
            // tbDatCoc
            // 
            this.tbDatCoc.Location = new System.Drawing.Point(126, 244);
            this.tbDatCoc.Name = "tbDatCoc";
            this.tbDatCoc.Size = new System.Drawing.Size(526, 20);
            this.tbDatCoc.TabIndex = 9;
            this.tbDatCoc.Text = "0";
            this.tbDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // lblSLNguoi
            // 
            this.lblSLNguoi.AutoSize = true;
            this.lblSLNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNguoi.Location = new System.Drawing.Point(12, 276);
            this.lblSLNguoi.Name = "lblSLNguoi";
            this.lblSLNguoi.Size = new System.Drawing.Size(119, 20);
            this.lblSLNguoi.TabIndex = 14;
            this.lblSLNguoi.Text = "Số lượng người:";
            // 
            // tbSLNguoi
            // 
            this.tbSLNguoi.Location = new System.Drawing.Point(137, 276);
            this.tbSLNguoi.Name = "tbSLNguoi";
            this.tbSLNguoi.Size = new System.Drawing.Size(515, 20);
            this.tbSLNguoi.TabIndex = 10;
            this.tbSLNguoi.Text = "0";
            this.tbSLNguoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(211, 335);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(262, 32);
            this.btnDatPhong.TabIndex = 12;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(12, 307);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(98, 20);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Mã giảm giá:";
            // 
            // cbCoupon
            // 
            this.cbCoupon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCoupon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCoupon.FormattingEnabled = true;
            this.cbCoupon.Location = new System.Drawing.Point(116, 307);
            this.cbCoupon.Name = "cbCoupon";
            this.cbCoupon.Size = new System.Drawing.Size(536, 21);
            this.cbCoupon.TabIndex = 11;
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 379);
            this.Controls.Add(this.cbCoupon);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.tbSLNguoi);
            this.Controls.Add(this.tbDatCoc);
            this.Controls.Add(this.cbCMND);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.gbAddKH);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSLNguoi);
            this.Controls.Add(this.lblDatCoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng";
            this.gbAddKH.ResumeLayout(false);
            this.gbAddKH.PerformLayout();
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddKH;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.ComboBox cbCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTSDT;
        private System.Windows.Forms.Label lblTCMND;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTSoPhong;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTTongTien;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDatCoc;
        private System.Windows.Forms.TextBox tbDatCoc;
        private System.Windows.Forms.Label lblSLNguoi;
        private System.Windows.Forms.TextBox tbSLNguoi;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cbCoupon;
    }
}