using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class PageRoom : UserControl
    {
        string chuaDat = "Chưa đặt";
        string daDat = "Đã đặt";
        
        public PageRoom()
        {
            InitializeComponent();
            cbLoaiPhong.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            pageRoomInfo.BringToFront();
            pageRoomInfo.ParentF = this;
        }

        void LoadData()
        {
            DataTable dt = SQLConnection.Select("*", "Phong");
            foreach (DataRow dr in dt.Rows)
            {
                string loai = dr["IDPhong"].ToString().Remove(1);
                string phong = dr["IDPhong"].ToString().Substring(1);
                ListViewItem i = new ListViewItem(phong);
                i.SubItems.Add(loai);
                switch (dr["TinhTrang"].ToString())
                {
                    case "True":
                        i.SubItems.Add(daDat);
                        break;
                    case "False":
                        i.SubItems.Add(chuaDat);
                        break;
                }
                i.SubItems.Add(dr["GiaPhong"].ToString());
                lvDSPhong.Items.Add(i);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDSPhong.Items.Clear();
            LoadData();
            switch (cbLoaiPhong.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    foreach(ListViewItem item in lvDSPhong.Items)
                    {
                        if (item.SubItems[1].Text != "A")
                            lvDSPhong.Items.Remove(item);
                    }
                    break;
                case 2:
                    foreach (ListViewItem item in lvDSPhong.Items)
                    {
                        if (item.SubItems[1].Text != "B")
                            lvDSPhong.Items.Remove(item);
                    }
                    break;
                case 3:
                    foreach (ListViewItem item in lvDSPhong.Items)
                    {
                        if (item.SubItems[1].Text != "C")
                            lvDSPhong.Items.Remove(item);
                    }
                    break;
            }
            switch (cbStatus.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    foreach (ListViewItem item in lvDSPhong.Items)
                    {

                        if (item.SubItems[2].Text != chuaDat)
                            lvDSPhong.Items.Remove(item);
                    }
                    break;
                case 2:
                    foreach (ListViewItem item in lvDSPhong.Items)
                    {
                        if (item.SubItems[2].Text != daDat)
                            lvDSPhong.Items.Remove(item);
                    }
                    break;
            }
        }

        private void lvDSPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSPhong.SelectedItems.Count == 0)
                return;
            ListViewItem item = lvDSPhong.SelectedItems[0];
            bool status;
            if (item.SubItems[2].Text == chuaDat)
                status = false;
            else
                status = true;
            Room room = new Room(item.Text, item.SubItems[1].Text, status, item.SubItems[3].Text);
            pageRoomInfo.Room = room;
        }

        public void Reload()
        {
            lvDSPhong.Items.Clear();
            cbLoaiPhong.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            pageRoomInfo.BringToFront();
            LoadData();
            pageRoomInfo.ParentF = this;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
