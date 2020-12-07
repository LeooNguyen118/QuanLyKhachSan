
namespace QuanLyKhachSan
{
    partial class ControlPanel
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
            this.tabControlPanel = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.tabService = new System.Windows.Forms.TabPage();
            this.btnUpdateDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.btnUpdateMA = new System.Windows.Forms.Button();
            this.dgvMA = new System.Windows.Forms.DataGridView();
            this.tabCoupon = new System.Windows.Forms.TabPage();
            this.btnUpdateMGG = new System.Windows.Forms.Button();
            this.dgvMGG = new System.Windows.Forms.DataGridView();
            this.tabThamSo = new System.Windows.Forms.TabPage();
            this.btnUpdateTS = new System.Windows.Forms.Button();
            this.dgvTS = new System.Windows.Forms.DataGridView();
            this.tabControlPanel.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tabFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).BeginInit();
            this.tabCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMGG)).BeginInit();
            this.tabThamSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPanel
            // 
            this.tabControlPanel.Controls.Add(this.tabPhong);
            this.tabControlPanel.Controls.Add(this.tabService);
            this.tabControlPanel.Controls.Add(this.tabFood);
            this.tabControlPanel.Controls.Add(this.tabCoupon);
            this.tabControlPanel.Controls.Add(this.tabThamSo);
            this.tabControlPanel.Location = new System.Drawing.Point(12, 12);
            this.tabControlPanel.Name = "tabControlPanel";
            this.tabControlPanel.SelectedIndex = 0;
            this.tabControlPanel.Size = new System.Drawing.Size(760, 437);
            this.tabControlPanel.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.btnUpdateRoom);
            this.tabPhong.Controls.Add(this.dgvRoom);
            this.tabPhong.Location = new System.Drawing.Point(4, 22);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(752, 411);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            this.tabPhong.Enter += new System.EventHandler(this.tabPhong_Enter);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(6, 365);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(740, 40);
            this.btnUpdateRoom.TabIndex = 1;
            this.btnUpdateRoom.Text = "Cập Nhật";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(6, 6);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.Size = new System.Drawing.Size(740, 353);
            this.dgvRoom.TabIndex = 0;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.btnUpdateDV);
            this.tabService.Controls.Add(this.dgvDV);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(752, 411);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Dịch Vụ";
            this.tabService.UseVisualStyleBackColor = true;
            this.tabService.Enter += new System.EventHandler(this.tabService_Enter);
            // 
            // btnUpdateDV
            // 
            this.btnUpdateDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDV.Location = new System.Drawing.Point(6, 365);
            this.btnUpdateDV.Name = "btnUpdateDV";
            this.btnUpdateDV.Size = new System.Drawing.Size(740, 40);
            this.btnUpdateDV.TabIndex = 3;
            this.btnUpdateDV.Text = "Cập Nhật";
            this.btnUpdateDV.UseVisualStyleBackColor = true;
            this.btnUpdateDV.Click += new System.EventHandler(this.btnUpdateDV_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(6, 6);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.Size = new System.Drawing.Size(740, 353);
            this.dgvDV.TabIndex = 2;
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.btnUpdateMA);
            this.tabFood.Controls.Add(this.dgvMA);
            this.tabFood.Location = new System.Drawing.Point(4, 22);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(752, 411);
            this.tabFood.TabIndex = 2;
            this.tabFood.Text = "Món ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            this.tabFood.Enter += new System.EventHandler(this.tabFood_Enter);
            // 
            // btnUpdateMA
            // 
            this.btnUpdateMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMA.Location = new System.Drawing.Point(6, 365);
            this.btnUpdateMA.Name = "btnUpdateMA";
            this.btnUpdateMA.Size = new System.Drawing.Size(740, 40);
            this.btnUpdateMA.TabIndex = 3;
            this.btnUpdateMA.Text = "Cập Nhật";
            this.btnUpdateMA.UseVisualStyleBackColor = true;
            this.btnUpdateMA.Click += new System.EventHandler(this.btnUpdateMA_Click);
            // 
            // dgvMA
            // 
            this.dgvMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMA.Location = new System.Drawing.Point(6, 6);
            this.dgvMA.Name = "dgvMA";
            this.dgvMA.Size = new System.Drawing.Size(740, 353);
            this.dgvMA.TabIndex = 2;
            // 
            // tabCoupon
            // 
            this.tabCoupon.Controls.Add(this.btnUpdateMGG);
            this.tabCoupon.Controls.Add(this.dgvMGG);
            this.tabCoupon.Location = new System.Drawing.Point(4, 22);
            this.tabCoupon.Name = "tabCoupon";
            this.tabCoupon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoupon.Size = new System.Drawing.Size(752, 411);
            this.tabCoupon.TabIndex = 3;
            this.tabCoupon.Text = "Mã giảm giá";
            this.tabCoupon.UseVisualStyleBackColor = true;
            this.tabCoupon.Enter += new System.EventHandler(this.tabCoupon_Enter);
            // 
            // btnUpdateMGG
            // 
            this.btnUpdateMGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMGG.Location = new System.Drawing.Point(6, 365);
            this.btnUpdateMGG.Name = "btnUpdateMGG";
            this.btnUpdateMGG.Size = new System.Drawing.Size(740, 40);
            this.btnUpdateMGG.TabIndex = 3;
            this.btnUpdateMGG.Text = "Cập Nhật";
            this.btnUpdateMGG.UseVisualStyleBackColor = true;
            this.btnUpdateMGG.Click += new System.EventHandler(this.btnUpdateMGG_Click);
            // 
            // dgvMGG
            // 
            this.dgvMGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMGG.Location = new System.Drawing.Point(6, 6);
            this.dgvMGG.Name = "dgvMGG";
            this.dgvMGG.Size = new System.Drawing.Size(740, 353);
            this.dgvMGG.TabIndex = 2;
            // 
            // tabThamSo
            // 
            this.tabThamSo.Controls.Add(this.btnUpdateTS);
            this.tabThamSo.Controls.Add(this.dgvTS);
            this.tabThamSo.Location = new System.Drawing.Point(4, 22);
            this.tabThamSo.Name = "tabThamSo";
            this.tabThamSo.Padding = new System.Windows.Forms.Padding(3);
            this.tabThamSo.Size = new System.Drawing.Size(752, 411);
            this.tabThamSo.TabIndex = 4;
            this.tabThamSo.Text = "Giá trị tham số";
            this.tabThamSo.UseVisualStyleBackColor = true;
            this.tabThamSo.Enter += new System.EventHandler(this.tabThamSo_Enter);
            // 
            // btnUpdateTS
            // 
            this.btnUpdateTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTS.Location = new System.Drawing.Point(6, 365);
            this.btnUpdateTS.Name = "btnUpdateTS";
            this.btnUpdateTS.Size = new System.Drawing.Size(740, 40);
            this.btnUpdateTS.TabIndex = 3;
            this.btnUpdateTS.Text = "Cập Nhật";
            this.btnUpdateTS.UseVisualStyleBackColor = true;
            this.btnUpdateTS.Click += new System.EventHandler(this.btnUpdateTS_Click);
            // 
            // dgvTS
            // 
            this.dgvTS.AllowUserToAddRows = false;
            this.dgvTS.AllowUserToDeleteRows = false;
            this.dgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTS.Location = new System.Drawing.Point(6, 6);
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.Size = new System.Drawing.Size(740, 353);
            this.dgvTS.TabIndex = 2;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.tabControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlPanel_FormClosed);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.tabControlPanel.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tabFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).EndInit();
            this.tabCoupon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMGG)).EndInit();
            this.tabThamSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPanel;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Button btnUpdateDV;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Button btnUpdateMA;
        private System.Windows.Forms.DataGridView dgvMA;
        private System.Windows.Forms.TabPage tabCoupon;
        private System.Windows.Forms.Button btnUpdateMGG;
        private System.Windows.Forms.DataGridView dgvMGG;
        private System.Windows.Forms.TabPage tabThamSo;
        private System.Windows.Forms.Button btnUpdateTS;
        private System.Windows.Forms.DataGridView dgvTS;
    }
}