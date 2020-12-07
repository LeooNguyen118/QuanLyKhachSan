
namespace QuanLyKhachSan
{
    partial class PageServiceFood
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
            this.lvDSFood = new System.Windows.Forms.ListView();
            this.tenMA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTraCuu = new System.Windows.Forms.Label();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageServiceFoodInfo = new QuanLyKhachSan.PageServiceFoodInfo();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnRefresh);
            this.pnlLeft.Controls.Add(this.lvDSFood);
            this.pnlLeft.Controls.Add(this.lblTraCuu);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 442);
            this.pnlLeft.TabIndex = 10;
            // 
            // lvDSFood
            // 
            this.lvDSFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenMA,
            this.giaTien});
            this.lvDSFood.FullRowSelect = true;
            this.lvDSFood.HideSelection = false;
            this.lvDSFood.Location = new System.Drawing.Point(4, 65);
            this.lvDSFood.Name = "lvDSFood";
            this.lvDSFood.Size = new System.Drawing.Size(344, 345);
            this.lvDSFood.TabIndex = 1;
            this.lvDSFood.UseCompatibleStateImageBehavior = false;
            this.lvDSFood.View = System.Windows.Forms.View.Details;
            this.lvDSFood.SelectedIndexChanged += new System.EventHandler(this.lvDSFood_SelectedIndexChanged);
            // 
            // tenMA
            // 
            this.tenMA.Text = "Tên Món Ăn";
            this.tenMA.Width = 190;
            // 
            // giaTien
            // 
            this.giaTien.Text = "Giá Tiền";
            this.giaTien.Width = 149;
            // 
            // lblTraCuu
            // 
            this.lblTraCuu.AutoSize = true;
            this.lblTraCuu.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraCuu.Location = new System.Drawing.Point(45, 9);
            this.lblTraCuu.Name = "lblTraCuu";
            this.lblTraCuu.Size = new System.Drawing.Size(253, 45);
            this.lblTraCuu.TabIndex = 0;
            this.lblTraCuu.Text = "Tra cứu món ăn";
            this.lblTraCuu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.Black;
            this.pnlSeperator.Location = new System.Drawing.Point(351, 0);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(2, 442);
            this.pnlSeperator.TabIndex = 9;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lblThongTin);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(354, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 442);
            this.pnlRight.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pageServiceFoodInfo);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 377);
            this.panel1.TabIndex = 2;
            // 
            // pageServiceFoodInfo
            // 
            this.pageServiceFoodInfo.Location = new System.Drawing.Point(0, 0);
            this.pageServiceFoodInfo.Name = "pageServiceFoodInfo";
            this.pageServiceFoodInfo.Size = new System.Drawing.Size(350, 377);
            this.pageServiceFoodInfo.TabIndex = 0;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(41, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(283, 45);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin món ăn";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 416);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageServiceFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSeperator);
            this.Controls.Add(this.pnlRight);
            this.Name = "PageServiceFood";
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
        private System.Windows.Forms.ListView lvDSFood;
        private System.Windows.Forms.ColumnHeader tenMA;
        private System.Windows.Forms.ColumnHeader giaTien;
        private System.Windows.Forms.Label lblTraCuu;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongTin;
        private PageServiceFoodInfo pageServiceFoodInfo;
        private System.Windows.Forms.Button btnRefresh;
    }
}
