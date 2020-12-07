
namespace QuanLyKhachSan
{
    partial class PageHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnCP = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Unicode MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(114, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(541, 43);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chúc bạn một ngày làm việc tốt lành";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnCP);
            this.gb1.Location = new System.Drawing.Point(3, 338);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(698, 60);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            // 
            // btnCP
            // 
            this.btnCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCP.Location = new System.Drawing.Point(6, 19);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(686, 34);
            this.btnCP.TabIndex = 1;
            this.btnCP.Text = "Control Panel";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // PageHome
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gb1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "PageHome";
            this.Size = new System.Drawing.Size(704, 442);
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnCP;
    }
}
