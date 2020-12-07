using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            pageHome.BringToFront();
            timerClock.Enabled = true;
        }

        public void BringPage(string pageName)
        {
            switch (pageName)
            {
                case "roomServ":
                    pageServiceRoom.BringToFront();
                    break;
                case "foodServ":
                    pageServiceFood.BringToFront();
                    break;
            }
            
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSideNav_Click(object sender, EventArgs e)
        {
            pnlSide.Height = ((Button)sender).Height;
            pnlSide.Top = ((Button)sender).Top;
            switch (((Button)sender).Name)
            {
                case "btnRoom":
                    pageRoom.BringToFront();
                    
                    break;
                case "btnHome":
                    pageHome.BringToFront();
                    break;
                case "btnCustomer":
                    pageCustomer.BringToFront();
                    break;
                case "btnService":
                    pageServices.BringToFront();
                    pageServices.ParentF = this;
                    break;
                case "btnDiscount":
                    pageDiscount.BringToFront();
                    break;
                case "btnCharts":
                    pageThongKe.BringToFront();
                    break;
            }
        }

        private void btnSideNav_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(6, 27, 34);
        }

        private void btnSideNav_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                pnlTop.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void Index_Activated(object sender, EventArgs e)
        {
            pnlContent.Refresh();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerClock.Enabled = false;
        }
    }
}
