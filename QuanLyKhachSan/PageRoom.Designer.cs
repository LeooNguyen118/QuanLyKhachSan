
namespace QuanLyKhachSan
{
    partial class PageRoom
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
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTStatus = new System.Windows.Forms.Label();
            this.lblTLoaiPhong = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lvDSPhong = new System.Windows.Forms.ListView();
            this.soPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleTCP = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageRoomInfo = new QuanLyKhachSan.PageRoomInfo();
            this.lblTitleTTP = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.Black;
            this.pnlSeperator.Location = new System.Drawing.Point(351, 0);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(2, 442);
            this.pnlSeperator.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnRefresh);
            this.pnlLeft.Controls.Add(this.lblTStatus);
            this.pnlLeft.Controls.Add(this.lblTLoaiPhong);
            this.pnlLeft.Controls.Add(this.cbStatus);
            this.pnlLeft.Controls.Add(this.cbLoaiPhong);
            this.pnlLeft.Controls.Add(this.lvDSPhong);
            this.pnlLeft.Controls.Add(this.lblTitleTCP);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 442);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblTStatus
            // 
            this.lblTStatus.AutoSize = true;
            this.lblTStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTStatus.Location = new System.Drawing.Point(9, 99);
            this.lblTStatus.Name = "lblTStatus";
            this.lblTStatus.Size = new System.Drawing.Size(80, 20);
            this.lblTStatus.TabIndex = 3;
            this.lblTStatus.Text = "Tình trạng";
            // 
            // lblTLoaiPhong
            // 
            this.lblTLoaiPhong.AutoSize = true;
            this.lblTLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLoaiPhong.Location = new System.Drawing.Point(9, 65);
            this.lblTLoaiPhong.Name = "lblTLoaiPhong";
            this.lblTLoaiPhong.Size = new System.Drawing.Size(88, 20);
            this.lblTLoaiPhong.TabIndex = 3;
            this.lblTLoaiPhong.Text = "Loại phòng";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "----------",
            "Còn trống",
            "Có người"});
            this.cbStatus.Location = new System.Drawing.Point(111, 100);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(234, 21);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "----------",
            "A",
            "B",
            "C"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(111, 65);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(234, 21);
            this.cbLoaiPhong.TabIndex = 2;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lvDSPhong
            // 
            this.lvDSPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.soPhong,
            this.loaiPhong,
            this.tinhTrang});
            this.lvDSPhong.FullRowSelect = true;
            this.lvDSPhong.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDSPhong.HideSelection = false;
            this.lvDSPhong.Location = new System.Drawing.Point(4, 127);
            this.lvDSPhong.MultiSelect = false;
            this.lvDSPhong.Name = "lvDSPhong";
            this.lvDSPhong.Size = new System.Drawing.Size(344, 283);
            this.lvDSPhong.TabIndex = 1;
            this.lvDSPhong.UseCompatibleStateImageBehavior = false;
            this.lvDSPhong.View = System.Windows.Forms.View.Details;
            this.lvDSPhong.SelectedIndexChanged += new System.EventHandler(this.lvDSPhong_SelectedIndexChanged);
            // 
            // soPhong
            // 
            this.soPhong.Text = "Số Phòng";
            this.soPhong.Width = 91;
            // 
            // loaiPhong
            // 
            this.loaiPhong.Text = "Loại Phòng";
            this.loaiPhong.Width = 113;
            // 
            // tinhTrang
            // 
            this.tinhTrang.Text = "Tình Trạng";
            this.tinhTrang.Width = 134;
            // 
            // lblTitleTCP
            // 
            this.lblTitleTCP.AutoSize = true;
            this.lblTitleTCP.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTCP.Location = new System.Drawing.Point(59, 9);
            this.lblTitleTCP.Name = "lblTitleTCP";
            this.lblTitleTCP.Size = new System.Drawing.Size(233, 45);
            this.lblTitleTCP.TabIndex = 0;
            this.lblTitleTCP.Text = "Tra cứu phòng";
            this.lblTitleTCP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lblTitleTTP);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(354, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 442);
            this.pnlRight.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pageRoomInfo);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 377);
            this.panel1.TabIndex = 2;
            // 
            // pageRoomInfo
            // 
            this.pageRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.pageRoomInfo.Name = "pageRoomInfo";
            this.pageRoomInfo.ParentF = null;
            this.pageRoomInfo.Size = new System.Drawing.Size(350, 377);
            this.pageRoomInfo.TabIndex = 0;
            // 
            // lblTitleTTP
            // 
            this.lblTitleTTP.AutoSize = true;
            this.lblTitleTTP.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTTP.Location = new System.Drawing.Point(48, 9);
            this.lblTitleTTP.Name = "lblTitleTTP";
            this.lblTitleTTP.Size = new System.Drawing.Size(263, 45);
            this.lblTitleTTP.TabIndex = 0;
            this.lblTitleTTP.Text = "Thông tin phòng";
            this.lblTitleTTP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // PageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSeperator);
            this.Name = "PageRoom";
            this.Size = new System.Drawing.Size(704, 442);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTStatus;
        private System.Windows.Forms.Label lblTLoaiPhong;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ListView lvDSPhong;
        private System.Windows.Forms.Label lblTitleTCP;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTitleTTP;
        private System.Windows.Forms.ColumnHeader soPhong;
        private System.Windows.Forms.ColumnHeader loaiPhong;
        private System.Windows.Forms.ColumnHeader tinhTrang;
        private System.Windows.Forms.Panel panel1;
        private PageRoomInfo pageRoomInfo;
        private System.Windows.Forms.Button btnRefresh;
    }
}
