
namespace QuanLyKhachSan
{
    partial class PageServices
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
            this.pnlFood = new System.Windows.Forms.Panel();
            this.lblFood = new System.Windows.Forms.Label();
            this.pnlService = new System.Windows.Forms.Panel();
            this.lblService = new System.Windows.Forms.Label();
            this.pnlFood.SuspendLayout();
            this.pnlService.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.Firebrick;
            this.pnlFood.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.roomFood;
            this.pnlFood.Controls.Add(this.lblFood);
            this.pnlFood.Location = new System.Drawing.Point(353, 3);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(348, 436);
            this.pnlFood.TabIndex = 3;
            this.pnlFood.Click += new System.EventHandler(this.pnlFood_Click);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.White;
            this.lblFood.Location = new System.Drawing.Point(54, 350);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(251, 42);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "Dịch Vụ Thức Ăn";
            this.lblFood.Click += new System.EventHandler(this.pnlFood_Click);
            // 
            // pnlService
            // 
            this.pnlService.BackColor = System.Drawing.Color.Firebrick;
            this.pnlService.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.roomService;
            this.pnlService.Controls.Add(this.lblService);
            this.pnlService.Location = new System.Drawing.Point(3, 3);
            this.pnlService.Name = "pnlService";
            this.pnlService.Size = new System.Drawing.Size(348, 436);
            this.pnlService.TabIndex = 4;
            this.pnlService.Click += new System.EventHandler(this.pnlService_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(64, 350);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(222, 42);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Dịch Vụ Phòng";
            this.lblService.Click += new System.EventHandler(this.pnlService_Click);
            // 
            // PageServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlService);
            this.Controls.Add(this.pnlFood);
            this.Name = "PageServices";
            this.Size = new System.Drawing.Size(704, 442);
            this.pnlFood.ResumeLayout(false);
            this.pnlFood.PerformLayout();
            this.pnlService.ResumeLayout(false);
            this.pnlService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Panel pnlService;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblService;
    }
}
