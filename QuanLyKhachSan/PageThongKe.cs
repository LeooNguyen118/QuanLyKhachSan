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
    public partial class PageThongKe : UserControl
    {
        public PageThongKe()
        {
            InitializeComponent();
            cbStatType.SelectedIndex = 0;
            pageThongKeNgay.BringToFront();
        }

        private void cbStatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStatType.SelectedIndex)
            {
                case 0:
                    pageThongKeNgay.BringToFront();
                    break;
                case 1:
                    pageThongKeThang.BringToFront();
                    break;
                case 2:
                    pageThongKeCongNo.BringToFront();
                    break;

            }
        }
    }
}
