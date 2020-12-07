
namespace QuanLyKhachSan
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pageThongKe = new QuanLyKhachSan.PageThongKe();
            this.pageDiscount = new QuanLyKhachSan.PageDiscount();
            this.pageServiceFood = new QuanLyKhachSan.PageServiceFood();
            this.pageServiceRoom = new QuanLyKhachSan.PageServiceRoom();
            this.pageServices = new QuanLyKhachSan.PageServices();
            this.pageCustomer = new QuanLyKhachSan.PageCustomer();
            this.pageRoom = new QuanLyKhachSan.PageRoom();
            this.pageHome = new QuanLyKhachSan.PageHome();
            this.pnlTop.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(704, 35);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(653, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.pnlNav.Controls.Add(this.lblDate);
            this.pnlNav.Controls.Add(this.lblClock);
            this.pnlNav.Controls.Add(this.pnlSide);
            this.pnlNav.Controls.Add(this.btnDiscount);
            this.pnlNav.Controls.Add(this.btnCharts);
            this.pnlNav.Controls.Add(this.btnService);
            this.pnlNav.Controls.Add(this.btnCustomer);
            this.pnlNav.Controls.Add(this.btnRoom);
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(144, 477);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.pnlSide.Location = new System.Drawing.Point(3, 438);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(11, 34);
            this.pnlSide.TabIndex = 0;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(17, 278);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(123, 34);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.Text = "Mã Giảm Giá";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnDiscount.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnDiscount.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // btnCharts
            // 
            this.btnCharts.BackColor = System.Drawing.Color.Transparent;
            this.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharts.ForeColor = System.Drawing.Color.White;
            this.btnCharts.Location = new System.Drawing.Point(17, 238);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(123, 34);
            this.btnCharts.TabIndex = 3;
            this.btnCharts.Text = "Thống Kê";
            this.btnCharts.UseVisualStyleBackColor = false;
            this.btnCharts.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnCharts.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnCharts.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.Transparent;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Location = new System.Drawing.Point(17, 318);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(123, 34);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Dịch Vụ";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnService.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnService.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(17, 358);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(123, 34);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnCustomer.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnCustomer.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(17, 398);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(123, 34);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "Phòng";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnRoom.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnRoom.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(17, 438);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(123, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnSideNav_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnSideNav_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnSideNav_MouseLeave);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(144, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(704, 477);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pageThongKe);
            this.pnlContent.Controls.Add(this.pageDiscount);
            this.pnlContent.Controls.Add(this.pageServiceFood);
            this.pnlContent.Controls.Add(this.pageServiceRoom);
            this.pnlContent.Controls.Add(this.pageServices);
            this.pnlContent.Controls.Add(this.pageCustomer);
            this.pnlContent.Controls.Add(this.pageRoom);
            this.pnlContent.Controls.Add(this.pageHome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 35);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(704, 442);
            this.pnlContent.TabIndex = 1;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Arial Unicode MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(11, 11);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(129, 35);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(16, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "01/01/2020";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // pageThongKe
            // 
            this.pageThongKe.BackColor = System.Drawing.Color.White;
            this.pageThongKe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pageThongKe.Location = new System.Drawing.Point(0, 0);
            this.pageThongKe.Name = "pageThongKe";
            this.pageThongKe.Size = new System.Drawing.Size(704, 442);
            this.pageThongKe.TabIndex = 6;
            // 
            // pageDiscount
            // 
            this.pageDiscount.BackColor = System.Drawing.Color.White;
            this.pageDiscount.Location = new System.Drawing.Point(0, 0);
            this.pageDiscount.Name = "pageDiscount";
            this.pageDiscount.Size = new System.Drawing.Size(704, 442);
            this.pageDiscount.TabIndex = 5;
            // 
            // pageServiceFood
            // 
            this.pageServiceFood.BackColor = System.Drawing.Color.White;
            this.pageServiceFood.Location = new System.Drawing.Point(0, 0);
            this.pageServiceFood.Name = "pageServiceFood";
            this.pageServiceFood.Size = new System.Drawing.Size(704, 442);
            this.pageServiceFood.TabIndex = 4;
            // 
            // pageServiceRoom
            // 
            this.pageServiceRoom.BackColor = System.Drawing.Color.White;
            this.pageServiceRoom.Location = new System.Drawing.Point(0, 0);
            this.pageServiceRoom.Name = "pageServiceRoom";
            this.pageServiceRoom.Size = new System.Drawing.Size(704, 442);
            this.pageServiceRoom.TabIndex = 3;
            // 
            // pageServices
            // 
            this.pageServices.BackColor = System.Drawing.Color.White;
            this.pageServices.Location = new System.Drawing.Point(0, 0);
            this.pageServices.Name = "pageServices";
            this.pageServices.ParentF = null;
            this.pageServices.Size = new System.Drawing.Size(704, 442);
            this.pageServices.TabIndex = 2;
            // 
            // pageCustomer
            // 
            this.pageCustomer.BackColor = System.Drawing.Color.White;
            this.pageCustomer.Location = new System.Drawing.Point(0, 0);
            this.pageCustomer.Name = "pageCustomer";
            this.pageCustomer.Size = new System.Drawing.Size(704, 442);
            this.pageCustomer.TabIndex = 1;
            // 
            // pageRoom
            // 
            this.pageRoom.BackColor = System.Drawing.Color.White;
            this.pageRoom.Location = new System.Drawing.Point(0, 0);
            this.pageRoom.Name = "pageRoom";
            this.pageRoom.Size = new System.Drawing.Size(704, 442);
            this.pageRoom.TabIndex = 0;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.White;
            this.pageHome.Location = new System.Drawing.Point(0, 0);
            this.pageHome.Name = "pageHome";
            this.pageHome.Size = new System.Drawing.Size(704, 442);
            this.pageHome.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(848, 477);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Activated += new System.EventHandler(this.Index_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContent;
        private PageHome pageHome;
        private PageRoom pageRoom;
        private PageCustomer pageCustomer;
        private System.Windows.Forms.Button btnCharts;
        private PageServices pageServices;
        private PageServiceRoom pageServiceRoom;
        private PageServiceFood pageServiceFood;
        private System.Windows.Forms.Button btnDiscount;
        private PageDiscount pageDiscount;
        private PageThongKe pageThongKe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
    }
}

