
namespace QuanLyKhachSan
{
    partial class PageCustomerInfo
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
            this.lblTSDT = new System.Windows.Forms.Label();
            this.lblTCMND = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblTType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(105, 150);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(145, 14);
            this.lblEmpty.TabIndex = 19;
            this.lblEmpty.Text = "Hãy chọn một khách hàng";
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(3, 339);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(344, 34);
            this.btnAction.TabIndex = 18;
            this.btnAction.Text = "Sửa thông tin";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblTSDT
            // 
            this.lblTSDT.AutoSize = true;
            this.lblTSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSDT.Location = new System.Drawing.Point(12, 67);
            this.lblTSDT.Name = "lblTSDT";
            this.lblTSDT.Size = new System.Drawing.Size(106, 20);
            this.lblTSDT.TabIndex = 15;
            this.lblTSDT.Text = "Số điện thoại:";
            // 
            // lblTCMND
            // 
            this.lblTCMND.AutoSize = true;
            this.lblTCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCMND.Location = new System.Drawing.Point(12, 37);
            this.lblTCMND.Name = "lblTCMND";
            this.lblTCMND.Size = new System.Drawing.Size(60, 20);
            this.lblTCMND.TabIndex = 16;
            this.lblTCMND.Text = "CMND:";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.Location = new System.Drawing.Point(12, 7);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(40, 20);
            this.lblTName.TabIndex = 17;
            this.lblTName.Text = "Tên:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(58, 7);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 20);
            this.tbName.TabIndex = 20;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(78, 37);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(259, 20);
            this.tbCMND.TabIndex = 20;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(124, 67);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(213, 20);
            this.tbSDT.TabIndex = 20;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(70, 97);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(267, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTType.Location = new System.Drawing.Point(12, 127);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(90, 20);
            this.lblTType.TabIndex = 15;
            this.lblTType.Text = "Loại khách:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Trong Nước",
            "Ngoài Nước"});
            this.cbType.Location = new System.Drawing.Point(108, 126);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(229, 21);
            this.cbType.TabIndex = 21;
            // 
            // PageCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblTType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTSDT);
            this.Controls.Add(this.lblTCMND);
            this.Controls.Add(this.lblTName);
            this.Name = "PageCustomerInfo";
            this.Size = new System.Drawing.Size(350, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblTSDT;
        private System.Windows.Forms.Label lblTCMND;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.ComboBox cbType;
    }
}
