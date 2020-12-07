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
    public partial class PageDiscount : UserControl
    {
        public PageDiscount()
        {
            InitializeComponent();
            pageDiscountInfo.BringToFront();
            LoadData();
        }

        void LoadData()
        {
            DataTable dt = SQLConnection.Select("*", "MaGiamGia");
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem i = new ListViewItem(dr["IDMaGiamGia"].ToString());
                i.SubItems.Add(dr["MoTa"].ToString());
                i.SubItems.Add(dr["HanSuDung"].ToString());
                i.SubItems.Add(dr["HieuQua"].ToString());
                lvDSMGG.Items.Add(i);
            }
        }

        private void lvDSMGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSMGG.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvDSMGG.SelectedItems[0];
            Discount discount = new Discount(item.Text, item.SubItems[1].Text, Convert.ToDateTime(item.SubItems[2].Text), item.SubItems[3].Text);
            pageDiscountInfo.Discount = discount;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
