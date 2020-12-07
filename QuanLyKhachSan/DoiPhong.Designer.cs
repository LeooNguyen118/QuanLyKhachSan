
namespace QuanLyKhachSan
{
    partial class DoiPhong
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblPhongMoi = new System.Windows.Forms.Label();
            this.cbPhongMoi = new System.Windows.Forms.ComboBox();
            this.lblPhi = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đổi Phòng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(13, 52);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(56, 13);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng cũ:";
            // 
            // lblPhongMoi
            // 
            this.lblPhongMoi.AutoSize = true;
            this.lblPhongMoi.Location = new System.Drawing.Point(13, 89);
            this.lblPhongMoi.Name = "lblPhongMoi";
            this.lblPhongMoi.Size = new System.Drawing.Size(60, 13);
            this.lblPhongMoi.TabIndex = 1;
            this.lblPhongMoi.Text = "Phòng mới:";
            // 
            // cbPhongMoi
            // 
            this.cbPhongMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongMoi.FormattingEnabled = true;
            this.cbPhongMoi.Items.AddRange(new object[] {
            "------",
            "001",
            "002",
            "003",
            "004"});
            this.cbPhongMoi.Location = new System.Drawing.Point(79, 85);
            this.cbPhongMoi.Name = "cbPhongMoi";
            this.cbPhongMoi.Size = new System.Drawing.Size(173, 21);
            this.cbPhongMoi.TabIndex = 2;
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.Location = new System.Drawing.Point(12, 125);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(78, 13);
            this.lblPhi.TabIndex = 1;
            this.lblPhi.Text = "Phí đổi phòng:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(84, 157);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(95, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Xác Nhận";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // DoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 196);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbPhongMoi);
            this.Controls.Add(this.lblPhi);
            this.Controls.Add(this.lblPhongMoi);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Phòng";
            this.Load += new System.EventHandler(this.DoiPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblPhongMoi;
        private System.Windows.Forms.ComboBox cbPhongMoi;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.Button btnAccept;
    }
}