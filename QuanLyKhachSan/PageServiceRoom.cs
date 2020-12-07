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
    public partial class PageServiceRoom : UserControl
    {
        public PageServiceRoom()
        {
            InitializeComponent();
            pageServiceRoomInfo.BringToFront();
            LoadData();
        }
        void LoadData()
        {
            lvDSDV.Items.Clear();
            DataTable dt = SQLConnection.Select("*", "DichVu");
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem i = new ListViewItem(dr["TenDichVu"].ToString());
                i.SubItems.Add(dr["DonGiaDV"].ToString());
                i.SubItems.Add(dr["IDDichVu"].ToString());
                lvDSDV.Items.Add(i);
            }
        }

        private void lvDSDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSDV.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvDSDV.SelectedItems[0];
            Service service = new Service
                (item.Text, int.Parse(item.SubItems[1].Text), item.SubItems[2].Text, true);
            pageServiceRoomInfo.Service = service;
        }
    }
}
