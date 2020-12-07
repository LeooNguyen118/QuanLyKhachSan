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
    public partial class PageServiceFood : UserControl
    {
        public PageServiceFood()
        {
            InitializeComponent();
            pageServiceFoodInfo.BringToFront();
            LoadData();
        }
        void LoadData()
        {
            lvDSFood.Items.Clear();
            DataTable dt = SQLConnection.Select("*", "MonAn");
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem i = new ListViewItem(dr["TenMonAn"].ToString());
                i.SubItems.Add(dr["DonGiaMA"].ToString());
                i.SubItems.Add(dr["IDMonAn"].ToString());
                lvDSFood.Items.Add(i);
            }
        }

        private void lvDSFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSFood.SelectedItems.Count == 0)
                return;
            ListViewItem item = lvDSFood.SelectedItems[0];
            Service service = new Service
                (item.Text, int.Parse(item.SubItems[1].Text), item.SubItems[2].Text, false);
            pageServiceFoodInfo.Service = service;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
