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
    partial class PageServiceRoomInfo : UserControl
    {
        Service service;
        public Service Service
        {
            set
            {
                service = value;
                VisibleSwitch(true);
                lblName.Text = service.Name;
                lblGia.Text = service.Price.ToString();
                btnAction.Text = "Đặt Dịch Vụ";
            }
        }
        public PageServiceRoomInfo()
        {
            InitializeComponent();
            VisibleSwitch(false);
        }
        void VisibleSwitch(bool b)
        {
            lblEmpty.Visible = !b;
            lblName.Visible = b;
            lblGia.Visible = b;
            lblTName.Visible = b;
            lblTGia.Visible = b;
            btnAction.Visible = b;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            (new DatService(service)).Show();
        }
    }
}
