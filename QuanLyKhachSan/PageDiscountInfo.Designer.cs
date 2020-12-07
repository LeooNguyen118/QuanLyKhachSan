
namespace QuanLyKhachSan
{
    partial class PageDiscountInfo
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
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblMaGG = new System.Windows.Forms.Label();
            this.lblHieuQua = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(96, 148);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(150, 14);
            this.lblEmpty.TabIndex = 28;
            this.lblEmpty.Text = "Hãy chọn một mã giảm giá";
            // 
            // lblMaGG
            // 
            this.lblMaGG.AutoSize = true;
            this.lblMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGG.Location = new System.Drawing.Point(11, 9);
            this.lblMaGG.Name = "lblMaGG";
            this.lblMaGG.Size = new System.Drawing.Size(106, 20);
            this.lblMaGG.TabIndex = 26;
            this.lblMaGG.Text = "Mã Giảm Giá:";
            // 
            // lblHieuQua
            // 
            this.lblHieuQua.AutoSize = true;
            this.lblHieuQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHieuQua.Location = new System.Drawing.Point(11, 47);
            this.lblHieuQua.Name = "lblHieuQua";
            this.lblHieuQua.Size = new System.Drawing.Size(80, 20);
            this.lblHieuQua.TabIndex = 26;
            this.lblHieuQua.Text = "Hiệu Quả:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(11, 85);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(113, 20);
            this.lblExpiryDate.TabIndex = 26;
            this.lblExpiryDate.Text = "Ngày Hết Hạn:";
            // 
            // PageDiscountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblHieuQua);
            this.Controls.Add(this.lblMaGG);
            this.Name = "PageDiscountInfo";
            this.Size = new System.Drawing.Size(350, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblMaGG;
        private System.Windows.Forms.Label lblHieuQua;
        private System.Windows.Forms.Label lblExpiryDate;
    }
}
