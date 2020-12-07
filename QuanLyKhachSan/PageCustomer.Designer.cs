
namespace QuanLyKhachSan
{
    partial class PageCustomer
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
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.lblTCMND = new System.Windows.Forms.Label();
            this.lvDSKH = new System.Windows.Forms.ListView();
            this.cmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitleTCKH = new System.Windows.Forms.Label();
            this.pnlSeperator = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageCustomerInfo = new QuanLyKhachSan.PageCustomerInfo();
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
            this.pnlLeft.Controls.Add(this.tbCMND);
            this.pnlLeft.Controls.Add(this.lblTCMND);
            this.pnlLeft.Controls.Add(this.lvDSKH);
            this.pnlLeft.Controls.Add(this.lblTitleTCKH);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 442);
            this.pnlLeft.TabIndex = 4;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(111, 67);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(234, 20);
            this.tbCMND.TabIndex = 4;
            this.tbCMND.TextChanged += new System.EventHandler(this.tbCMND_TextChanged);
            // 
            // lblTCMND
            // 
            this.lblTCMND.AutoSize = true;
            this.lblTCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCMND.Location = new System.Drawing.Point(26, 65);
            this.lblTCMND.Name = "lblTCMND";
            this.lblTCMND.Size = new System.Drawing.Size(56, 20);
            this.lblTCMND.TabIndex = 3;
            this.lblTCMND.Text = "CMND";
            // 
            // lvDSKH
            // 
            this.lvDSKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmnd,
            this.tenKH});
            this.lvDSKH.FullRowSelect = true;
            this.lvDSKH.HideSelection = false;
            this.lvDSKH.Location = new System.Drawing.Point(4, 93);
            this.lvDSKH.Name = "lvDSKH";
            this.lvDSKH.Size = new System.Drawing.Size(344, 317);
            this.lvDSKH.TabIndex = 1;
            this.lvDSKH.UseCompatibleStateImageBehavior = false;
            this.lvDSKH.View = System.Windows.Forms.View.Details;
            this.lvDSKH.SelectedIndexChanged += new System.EventHandler(this.lvDSKH_SelectedIndexChanged);
            // 
            // cmnd
            // 
            this.cmnd.Text = "CMND";
            this.cmnd.Width = 134;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Tên Khách Hàng";
            this.tenKH.Width = 206;
            // 
            // lblTitleTCKH
            // 
            this.lblTitleTCKH.AutoSize = true;
            this.lblTitleTCKH.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTCKH.Location = new System.Drawing.Point(22, 9);
            this.lblTitleTCKH.Name = "lblTitleTCKH";
            this.lblTitleTCKH.Size = new System.Drawing.Size(309, 45);
            this.lblTitleTCKH.TabIndex = 0;
            this.lblTitleTCKH.Text = "Tra cứu khách hàng";
            this.lblTitleTCKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSeperator
            // 
            this.pnlSeperator.BackColor = System.Drawing.Color.Black;
            this.pnlSeperator.Location = new System.Drawing.Point(351, 0);
            this.pnlSeperator.Name = "pnlSeperator";
            this.pnlSeperator.Size = new System.Drawing.Size(2, 442);
            this.pnlSeperator.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.lblTitleTTKH);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(354, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(350, 442);
            this.pnlRight.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pageCustomerInfo);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 377);
            this.panel1.TabIndex = 2;
            // 
            // pageCustomerInfo
            // 
            this.pageCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.pageCustomerInfo.Name = "pageCustomerInfo";
            this.pageCustomerInfo.ParentF = null;
            this.pageCustomerInfo.Size = new System.Drawing.Size(350, 377);
            this.pageCustomerInfo.TabIndex = 0;
            // 
            // lblTitleTTKH
            // 
            this.lblTitleTTKH.AutoSize = true;
            this.lblTitleTTKH.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTTKH.Location = new System.Drawing.Point(8, 9);
            this.lblTitleTTKH.Name = "lblTitleTTKH";
            this.lblTitleTTKH.Size = new System.Drawing.Size(339, 45);
            this.lblTitleTTKH.TabIndex = 0;
            this.lblTitleTTKH.Text = "Thông tin khách hàng";
            this.lblTitleTTKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 416);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(345, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlSeperator);
            this.Controls.Add(this.pnlRight);
            this.Name = "PageCustomer";
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
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.Label lblTCMND;
        private System.Windows.Forms.ListView lvDSKH;
        private System.Windows.Forms.ColumnHeader cmnd;
        private System.Windows.Forms.ColumnHeader tenKH;
        private System.Windows.Forms.Label lblTitleTCKH;
        private System.Windows.Forms.Panel pnlSeperator;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleTTKH;
        private PageCustomerInfo pageCustomerInfo;
        private System.Windows.Forms.Button btnRefresh;
    }
}
