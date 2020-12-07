
namespace QuanLyKhachSan
{
    partial class PageServiceFoodInfo
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
            this.btnAction = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTGia = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(122, 132);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(124, 14);
            this.lblEmpty.TabIndex = 27;
            this.lblEmpty.Text = "Hãy chọn một món ăn";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(3, 333);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(344, 34);
            this.btnAction.TabIndex = 26;
            this.btnAction.Text = "Đặt Món Ăn";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(109, 50);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(63, 20);
            this.lblGia.TabIndex = 22;
            this.lblGia.Text = "900000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(111, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "000";
            // 
            // lblTGia
            // 
            this.lblTGia.AutoSize = true;
            this.lblTGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTGia.Location = new System.Drawing.Point(12, 50);
            this.lblTGia.Name = "lblTGia";
            this.lblTGia.Size = new System.Drawing.Size(95, 20);
            this.lblTGia.TabIndex = 24;
            this.lblTGia.Text = "Giá món ăn:";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.Location = new System.Drawing.Point(12, 10);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(97, 20);
            this.lblTName.TabIndex = 25;
            this.lblTName.Text = "Tên món ăn:";
            // 
            // PageServiceFoodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTGia);
            this.Controls.Add(this.lblTName);
            this.Name = "PageServiceFoodInfo";
            this.Size = new System.Drawing.Size(350, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTGia;
        private System.Windows.Forms.Label lblTName;
    }
}
