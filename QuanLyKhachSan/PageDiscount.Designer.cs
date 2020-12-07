
namespace QuanLyKhachSan
{
    partial class PageDiscount
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tbMaGG = new System.Windows.Forms.TextBox();
            this.lblTCMaGG = new System.Windows.Forms.Label();
            this.lvDSMGG = new System.Windows.Forms.ListView();
            this.maGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hieuQua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expiryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleTCGG = new System.Windows.Forms.Label();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageDiscountInfo1 = new QuanLyKhachSan.PageDiscountInfo();
            this.pageDiscountInfo = new QuanLyKhachSan.PageDiscountInfo();
            this.lblTitleTTKH = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnRefresh);
            this.pnlLeft.Controls.Add(this.tbMaGG);
            this.pnlLeft.Controls.Add(this.lblTCMaGG);
            this.pnlLeft.Controls.Add(this.lvDSMGG);
            this.pnlLeft.Controls.Add(this.lblTitleTCGG);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 442);
            this.pnlLeft.TabIndex = 7;
            // 
            // tbMaGG
            // 
            this.tbMaGG.Location = new System.Drawing.Point(111, 67);
            this.tbMaGG.Name = "tbMaGG";
            this.tbMaGG.Size = new System.Drawing.Size(234, 20);
            this.tbMaGG.TabIndex = 4;
            // 
            // lblTCMaGG
            // 
            this.lblTCMaGG.AutoSize = true;
            this.lblTCMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCMaGG.Location = new System.Drawing.Point(5, 67);
            this.lblTCMaGG.Name = "lblTCMaGG";
            this.lblTCMaGG.Size = new System.Drawing.Size(106, 20);
            this.lblTCMaGG.TabIndex = 3;
            this.lblTCMaGG.Text = "Mã Giảm Giá:";
            // 
            // lvDSMGG
            // 
            this.lvDSMGG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maGiamGia,
            this.hieuQua,
            this.expiryDate});
            this.lvDSMGG.FullRowSelect = true;
            this.lvDSMGG.HideSelection = false;
            this.lvDSMGG.Location = new System.Drawing.Point(4, 93);
            this.lvDSMGG.Name = "lvDSMGG";
            this.lvDSMGG.Size = new System.Drawing.Size(344, 317);
            this.lvDSMGG.TabIndex = 1;
            this.lvDSMGG.UseCompatibleStateImageBehavior = false;
            this.lvDSMGG.View = System.Windows.Forms.View.Details;
            this.lvDSMGG.SelectedIndexChanged += new System.EventHandler(this.lvDSMGG_SelectedIndexChanged);
            // 
            // maGiamGia
            // 
            this.maGiamGia.Text = "Mã Giảm Giá";
            this.maGiamGia.Width = 93;
            // 
            // hieuQua
            // 
            this.hieuQua.Text = "Hiệu Quả";
            this.hieuQua.Width = 132;
            // 
            // expiryDate
            // 
            this.expiryDate.Text = "Ngày hết hạn";
            this.expiryDate.Width = 113;
            // 
            // lblTitleTCGG
            // 
            this.lblTitleTCGG.AutoSize = true;
            this.lblTitleTCGG.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTCGG.Location = new System.Drawing.Point(14, 9);
            this.lblTitleTCGG.Name = "lblTitleTCGG";
            this.lblTitleTCGG.Size = new System.Drawing.Size(319, 45);
            this.lblTitleTCGG.TabIndex = 0;
            this.lblTitleTCGG.Text = "Tra cứu mã giảm giá";
            this.lblTitleTCGG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.Black;
            this.pnlSeperator.Location = new System.Drawing.Point(351, 0);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(2, 442);
            this.pnlSeperator.TabIndex = 6;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lblTitleTTKH);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(354, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 442);
            this.pnlRight.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pageDiscountInfo1);
            this.panel1.Controls.Add(this.pageDiscountInfo);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 377);
            this.panel1.TabIndex = 2;
            // 
            // pageDiscountInfo1
            // 
            this.pageDiscountInfo1.Location = new System.Drawing.Point(0, 0);
            this.pageDiscountInfo1.Name = "pageDiscountInfo1";
            this.pageDiscountInfo1.Size = new System.Drawing.Size(350, 377);
            this.pageDiscountInfo1.TabIndex = 1;
            // 
            // pageDiscountInfo
            // 
            this.pageDiscountInfo.Location = new System.Drawing.Point(0, 0);
            this.pageDiscountInfo.Name = "pageDiscountInfo";
            this.pageDiscountInfo.Size = new System.Drawing.Size(350, 377);
            this.pageDiscountInfo.TabIndex = 0;
            // 
            // lblTitleTTKH
            // 
            this.lblTitleTTKH.AutoSize = true;
            this.lblTitleTTKH.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTTKH.Location = new System.Drawing.Point(1, 9);
            this.lblTitleTTKH.Name = "lblTitleTTKH";
            this.lblTitleTTKH.Size = new System.Drawing.Size(349, 45);
            this.lblTitleTTKH.TabIndex = 0;
            this.lblTitleTTKH.Text = "Thông tin mã giảm giá";
            this.lblTitleTTKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 416);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSeperator);
            this.Controls.Add(this.pnlRight);
            this.Name = "PageDiscount";
            this.Size = new System.Drawing.Size(704, 442);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox tbMaGG;
        private System.Windows.Forms.Label lblTCMaGG;
        private System.Windows.Forms.ListView lvDSMGG;
        private System.Windows.Forms.ColumnHeader maGiamGia;
        private System.Windows.Forms.ColumnHeader hieuQua;
        private System.Windows.Forms.ColumnHeader expiryDate;
        private System.Windows.Forms.Label lblTitleTCGG;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleTTKH;
        private PageDiscountInfo pageDiscountInfo;
        private PageDiscountInfo pageDiscountInfo1;
        private System.Windows.Forms.Button btnRefresh;
    }
}
