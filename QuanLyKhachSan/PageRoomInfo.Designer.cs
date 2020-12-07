
namespace QuanLyKhachSan
{
    partial class PageRoomInfo
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblTStatus = new System.Windows.Forms.Label();
            this.lblTLoaiPhong = new System.Windows.Forms.Label();
            this.lblTSoPhong = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblTGia = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnDoiPhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(106, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Còn trống";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(110, 49);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(20, 20);
            this.lblLoaiPhong.TabIndex = 5;
            this.lblLoaiPhong.Text = "A";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(101, 12);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(36, 20);
            this.lblSoPhong.TabIndex = 6;
            this.lblSoPhong.Text = "000";
            // 
            // lblTStatus
            // 
            this.lblTStatus.AutoSize = true;
            this.lblTStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTStatus.Location = new System.Drawing.Point(12, 89);
            this.lblTStatus.Name = "lblTStatus";
            this.lblTStatus.Size = new System.Drawing.Size(88, 20);
            this.lblTStatus.TabIndex = 7;
            this.lblTStatus.Text = "Tình Trạng:";
            // 
            // lblTLoaiPhong
            // 
            this.lblTLoaiPhong.AutoSize = true;
            this.lblTLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLoaiPhong.Location = new System.Drawing.Point(12, 49);
            this.lblTLoaiPhong.Name = "lblTLoaiPhong";
            this.lblTLoaiPhong.Size = new System.Drawing.Size(92, 20);
            this.lblTLoaiPhong.TabIndex = 8;
            this.lblTLoaiPhong.Text = "Loại phòng:";
            // 
            // lblTSoPhong
            // 
            this.lblTSoPhong.AutoSize = true;
            this.lblTSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSoPhong.Location = new System.Drawing.Point(12, 12);
            this.lblTSoPhong.Name = "lblTSoPhong";
            this.lblTSoPhong.Size = new System.Drawing.Size(83, 20);
            this.lblTSoPhong.TabIndex = 9;
            this.lblTSoPhong.Text = "Số Phòng:";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(3, 340);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(344, 34);
            this.btnAction.TabIndex = 10;
            this.btnAction.Text = "Đặt Phòng";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(122, 139);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(117, 14);
            this.lblEmpty.TabIndex = 11;
            this.lblEmpty.Text = "Hãy chọn một phòng";
            // 
            // lblTGia
            // 
            this.lblTGia.AutoSize = true;
            this.lblTGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGia.Location = new System.Drawing.Point(12, 128);
            this.lblTGia.Name = "lblTGia";
            this.lblTGia.Size = new System.Drawing.Size(87, 20);
            this.lblTGia.TabIndex = 7;
            this.lblTGia.Text = "Giá phòng:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(105, 128);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(63, 20);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "900000";
            // 
            // btnDoiPhong
            // 
            this.btnDoiPhong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPhong.Location = new System.Drawing.Point(3, 300);
            this.btnDoiPhong.Name = "btnDoiPhong";
            this.btnDoiPhong.Size = new System.Drawing.Size(344, 34);
            this.btnDoiPhong.TabIndex = 10;
            this.btnDoiPhong.Text = "Đổi Phòng";
            this.btnDoiPhong.UseVisualStyleBackColor = true;
            this.btnDoiPhong.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // PageRoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnDoiPhong);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.lblTGia);
            this.Controls.Add(this.lblTStatus);
            this.Controls.Add(this.lblTLoaiPhong);
            this.Controls.Add(this.lblTSoPhong);
            this.Name = "PageRoomInfo";
            this.Size = new System.Drawing.Size(350, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblTStatus;
        private System.Windows.Forms.Label lblTLoaiPhong;
        private System.Windows.Forms.Label lblTSoPhong;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblTGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Button btnDoiPhong;
    }
}
