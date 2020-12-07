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
    public partial class PageCustomer : UserControl
    {
        public PageCustomer()
        {
            InitializeComponent();
            pageCustomerInfo.BringToFront();
            LoadData();
            pageCustomerInfo.ParentF = this;
        }
        void LoadData()
        {
            lvDSKH.Items.Clear();
            DataTable dt = SQLConnection.Select("*", "KhachHang");
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem i = new ListViewItem(dr["CMND"].ToString());
                i.SubItems.Add(dr["TenKhachHang"].ToString());
                i.SubItems.Add(dr["IDKhachHang"].ToString());
                lvDSKH.Items.Add(i);
            }
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            LoadData();
            foreach (ListViewItem item in lvDSKH.Items)
            {
                if (!item.SubItems[0].Text.StartsWith(tbCMND.Text))
                    lvDSKH.Items.Remove(item);
            }
        }
        public void Reload()
        {
            LoadData();
            pageCustomerInfo.ParentF = this;
        }

        private void lvDSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSKH.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvDSKH.SelectedItems[0];
            string where = "IDKhachHang LIKE '" + item.SubItems[2].Text.ToString() + "'";
            DataTable dt = SQLConnection.SelectWhere("*", "KhachHang", where);
            Customer customer;
            foreach (DataRow dr in dt.Rows)
            {
                bool type = dr["LoaiKhachHang"].ToString() == "False" ? false : true;
                customer = new Customer(dr["TenKhachHang"].ToString(),
                    dr["CMND"].ToString(), dr["SDT"].ToString(), dr["Mail"].ToString(), type, dr["IDKhachHang"].ToString());
                pageCustomerInfo.Customer = customer;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
