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
    public partial class PageThongKeCongNo : UserControl
    {
        public PageThongKeCongNo()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                int sum = 0;
                string where = "DaThanhToan = 0";
                DataTable dt = SQLConnection.SelectWhere("*", "PhieuDatPhong", where);
                lvThongKe.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string _IDPhieuDatPhong = dr["IDPhieuDatPhong"].ToString();
                    string wherePDP = "IDPhieuDatPhong = " + _IDPhieuDatPhong;
                    string tenKH = SQLConnection.SelectOne("TenKhachHang", "KhachHang", wherePDP);
                    int tienPhong = int.Parse(dr["TongCong"].ToString()) + int.Parse(dr["PhiDoiPhong"].ToString());
                    int tienDV = int.Parse(dr["Phi_DichVu"].ToString()) + int.Parse(dr["Phi_MonAn"].ToString());

                    int valCoupon;
                    if (SQLConnection.isExist("MaGiamGia", "IDMaGiamGia", SQLConnection.SelectOne("IDMaGiamGia", "PhieuDatPhong", wherePDP)))
                    {
                        valCoupon = int.Parse(SQLConnection.SelectOne("HieuQua", "MaGiamGia", "IDMaGiamGia = N'" + dr["IDMaGiamGia"].ToString() + "'"));
                    }
                    else
                    {
                        valCoupon = 0;
                    }
                    int discount = (tienPhong + tienDV) * valCoupon / 100;

                    int tongCong = (tienDV + tienPhong - discount) - int.Parse(dr["SoTienCoc"].ToString());

                    sum += tongCong;
                    ListViewItem i = new ListViewItem(dr["NgayDi"].ToString());
                    i.SubItems.Add(dr["IDPhong"].ToString());
                    i.SubItems.Add(tenKH);
                    i.SubItems.Add(dr["SoTienCoc"].ToString());
                    i.SubItems.Add(tongCong.ToString());
                    lvThongKe.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
