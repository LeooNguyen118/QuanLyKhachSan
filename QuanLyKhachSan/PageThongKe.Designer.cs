
namespace QuanLyKhachSan
{
    partial class PageThongKe
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pageThongKeNgay = new QuanLyKhachSan.PageThongKeNgay();
            this.pageThongKeThang = new QuanLyKhachSan.PageThongKeThang();
            this.pageThongKeCongNo = new QuanLyKhachSan.PageThongKeCongNo();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(293, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thống kê";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatType);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 82);
            this.panel1.TabIndex = 3;
            // 
            // cbStatType
            // 
            this.cbStatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatType.FormattingEnabled = true;
            this.cbStatType.Items.AddRange(new object[] {
            "Thống kê doanh thu theo ngày",
            "Thống kê doanh thu theo tháng",
            "Thống kê công nợ"});
            this.cbStatType.Location = new System.Drawing.Point(166, 48);
            this.cbStatType.Name = "cbStatType";
            this.cbStatType.Size = new System.Drawing.Size(393, 21);
            this.cbStatType.TabIndex = 2;
            this.cbStatType.SelectedIndexChanged += new System.EventHandler(this.cbStatType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pageThongKeCongNo);
            this.panel2.Controls.Add(this.pageThongKeThang);
            this.panel2.Controls.Add(this.pageThongKeNgay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 360);
            this.panel2.TabIndex = 4;
            // 
            // pageThongKeNgay
            // 
            this.pageThongKeNgay.Location = new System.Drawing.Point(0, 0);
            this.pageThongKeNgay.Name = "pageThongKeNgay";
            this.pageThongKeNgay.Size = new System.Drawing.Size(704, 360);
            this.pageThongKeNgay.TabIndex = 0;
            // 
            // pageThongKeThang
            // 
            this.pageThongKeThang.Location = new System.Drawing.Point(0, 0);
            this.pageThongKeThang.Name = "pageThongKeThang";
            this.pageThongKeThang.Size = new System.Drawing.Size(704, 360);
            this.pageThongKeThang.TabIndex = 1;
            // 
            // pageThongKeCongNo
            // 
            this.pageThongKeCongNo.Location = new System.Drawing.Point(0, 0);
            this.pageThongKeCongNo.Name = "pageThongKeCongNo";
            this.pageThongKeCongNo.Size = new System.Drawing.Size(704, 360);
            this.pageThongKeCongNo.TabIndex = 2;
            // 
            // PageThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PageThongKe";
            this.Size = new System.Drawing.Size(704, 442);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatType;
        private System.Windows.Forms.Panel panel2;
        private PageThongKeCongNo pageThongKeCongNo;
        private PageThongKeThang pageThongKeThang;
        private PageThongKeNgay pageThongKeNgay;
    }
}
