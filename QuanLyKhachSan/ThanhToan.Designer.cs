
namespace QuanLyKhachSan
{
    partial class ThanhToan
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
            this.gbService = new System.Windows.Forms.GroupBox();
            this.lvService = new System.Windows.Forms.ListView();
            this.servName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvFood = new System.Windows.Forms.ListView();
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblTienFood = new System.Windows.Forms.Label();
            this.lblTienService = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblDatCoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbService.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbService
            // 
            this.gbService.Controls.Add(this.lvService);
            this.gbService.Location = new System.Drawing.Point(255, 176);
            this.gbService.Name = "gbService";
            this.gbService.Size = new System.Drawing.Size(360, 157);
            this.gbService.TabIndex = 0;
            this.gbService.TabStop = false;
            this.gbService.Text = "Dịch Vụ";
            // 
            // lvService
            // 
            this.lvService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.servName,
            this.servNum,
            this.servPrice});
            this.lvService.HideSelection = false;
            this.lvService.Location = new System.Drawing.Point(7, 19);
            this.lvService.Name = "lvService";
            this.lvService.Size = new System.Drawing.Size(347, 131);
            this.lvService.TabIndex = 0;
            this.lvService.UseCompatibleStateImageBehavior = false;
            this.lvService.View = System.Windows.Forms.View.Details;
            // 
            // servName
            // 
            this.servName.Text = "Tên";
            this.servName.Width = 139;
            // 
            // servNum
            // 
            this.servNum.Text = "Số lượng";
            this.servNum.Width = 63;
            // 
            // servPrice
            // 
            this.servPrice.Text = "Thành tiền";
            this.servPrice.Width = 121;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvFood);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Món ăn";
            // 
            // lvFood
            // 
            this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodName,
            this.foodNum,
            this.foodPrice});
            this.lvFood.HideSelection = false;
            this.lvFood.Location = new System.Drawing.Point(7, 20);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(347, 131);
            this.lvFood.TabIndex = 0;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.Details;
            // 
            // foodName
            // 
            this.foodName.Text = "Tên";
            this.foodName.Width = 139;
            // 
            // foodNum
            // 
            this.foodNum.Text = "Số lượng";
            this.foodNum.Width = 63;
            // 
            // foodPrice
            // 
            this.foodPrice.Text = "Thành tiền";
            this.foodPrice.Width = 121;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thanh Toán";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(12, 47);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(92, 13);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên Khách Hàng:";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(12, 68);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(42, 13);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND:";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(12, 90);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(56, 13);
            this.lblSoPhong.TabIndex = 2;
            this.lblSoPhong.Text = "Số phòng:";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(12, 112);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(57, 13);
            this.lblNgayDen.TabIndex = 2;
            this.lblNgayDen.Text = "Ngày đến:";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(12, 133);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(47, 13);
            this.lblNgayDi.TabIndex = 2;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(12, 180);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(88, 13);
            this.lblTienPhong.TabIndex = 2;
            this.lblTienPhong.Text = "Tổng tiền phòng:";
            this.lblTienPhong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTienFood
            // 
            this.lblTienFood.AutoSize = true;
            this.lblTienFood.Location = new System.Drawing.Point(11, 202);
            this.lblTienFood.Name = "lblTienFood";
            this.lblTienFood.Size = new System.Drawing.Size(93, 13);
            this.lblTienFood.TabIndex = 2;
            this.lblTienFood.Text = "Tổng tiền món ăn:";
            this.lblTienFood.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTienService
            // 
            this.lblTienService.AutoSize = true;
            this.lblTienService.Location = new System.Drawing.Point(11, 226);
            this.lblTienService.Name = "lblTienService";
            this.lblTienService.Size = new System.Drawing.Size(93, 13);
            this.lblTienService.TabIndex = 2;
            this.lblTienService.Text = "Tổng tiền dịch vụ:";
            this.lblTienService.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 2);
            this.panel1.TabIndex = 3;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.Red;
            this.lblThanhTien.Location = new System.Drawing.Point(64, 302);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(129, 29);
            this.lblThanhTien.TabIndex = 4;
            this.lblThanhTien.Text = "00.000.000";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(213, 342);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(243, 33);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(11, 271);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(51, 13);
            this.lblGiamGia.TabIndex = 2;
            this.lblGiamGia.Text = "Giảm giá:";
            this.lblGiamGia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDatCoc
            // 
            this.lblDatCoc.AutoSize = true;
            this.lblDatCoc.Location = new System.Drawing.Point(11, 249);
            this.lblDatCoc.Name = "lblDatCoc";
            this.lblDatCoc.Size = new System.Drawing.Size(48, 13);
            this.lblDatCoc.TabIndex = 2;
            this.lblDatCoc.Text = "Đặt cọc:";
            this.lblDatCoc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn giá phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 382);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDatCoc);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTienService);
            this.Controls.Add(this.lblTienFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTienPhong);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.lblNgayDen);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.gbService.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbService;
        private System.Windows.Forms.ListView lvService;
        private System.Windows.Forms.ColumnHeader servName;
        private System.Windows.Forms.ColumnHeader servNum;
        private System.Windows.Forms.ColumnHeader servPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader foodNum;
        private System.Windows.Forms.ColumnHeader foodPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTienFood;
        private System.Windows.Forms.Label lblTienService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblDatCoc;
        private System.Windows.Forms.Label label1;
    }
}