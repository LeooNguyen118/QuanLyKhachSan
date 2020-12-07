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
    public partial class PageThongKeNgay : UserControl
    {
        public PageThongKeNgay()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string date = dtpNgay.Value.ToString("MM/dd/yyyy");
            try
            {
                int sum = 0;
                string where = "ThoiGian = '"+date+"'";
                DataTable dt = SQLConnection.SelectWhere("*", "DOANHTHU_NGAY", where);
                lvThongKe.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string _IDPhieuDatPhong = dr["IDPhieuDatPhong"].ToString();
                    string wherePDP = "IDPhieuDatPhong = " + _IDPhieuDatPhong;
                    string idPhong = SQLConnection.SelectOne("IDPhong", "PhieuDatPhong", wherePDP);
                    string ngayDen = SQLConnection.SelectOne("NgayDen", "PhieuDatPhong", wherePDP);
                    int tienPhong = int.Parse(SQLConnection.SelectOne("TongCong", "PhieuDatPhong", wherePDP)) 
                        + int.Parse(SQLConnection.SelectOne("PhiDoiPhong", "PhieuDatPhong", wherePDP));
                    int tienDV = int.Parse(SQLConnection.SelectOne("Phi_MonAn", "PhieuDatPhong", wherePDP))
                        + int.Parse(SQLConnection.SelectOne("Phi_DichVu", "PhieuDatPhong", wherePDP));

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

                    int tongCong = tienDV + tienPhong - discount;
                    sum += tongCong;
                    ListViewItem i = new ListViewItem(idPhong);
                    i.SubItems.Add(ngayDen);
                    i.SubItems.Add(tienPhong.ToString());
                    i.SubItems.Add(tienDV.ToString());
                    i.SubItems.Add(tongCong.ToString());
                    lvThongKe.Items.Add(i);
                }

                lblTongCong.Text = "Tổng cộng: " + sum;
            }
            catch
            {

            }
        }
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
