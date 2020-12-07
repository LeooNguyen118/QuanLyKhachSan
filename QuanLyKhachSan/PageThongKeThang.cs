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
    public partial class PageThongKeThang : UserControl
    {
        public PageThongKeThang()
        {
            InitializeComponent();
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.ShowUpDown = true;
            LoadData();
        }
        void LoadData()
        {
            string date = dtpThang.Value.ToString("MM/yyyy");
            try
            {
                int sum = 0;
                string where = "ThoiGian LIKE '" + date + "'";
                DataTable dt = SQLConnection.SelectWhere("*", "DOANHTHU_Thang", where);
                lvThongKe.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string _ID_DTNgay = dr["ID_DTNGay"].ToString();
                    int tongPhong = 0;
                    int tongDV = 0;
                    int tongCong = 0;
                    string wherePDP = "";
                    string whereNgay = "ID_DTNGay = " + _ID_DTNgay;
                    DataTable dtNgay = SQLConnection.SelectWhere("*", "DOANHTHU_Ngay", whereNgay);
                    foreach (DataRow drN in dtNgay.Rows)
                    {
                        wherePDP = "IDPhieuDatPhong = " + drN["IDPhieuDatPhong"].ToString();
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
                        int tongTien = tienDV + tienPhong - discount;

                        tongPhong += tienPhong;
                        tongDV += tienDV;
                        tongCong += tongTien;
                        sum += tongCong;    
                    }

                    ListViewItem i = new ListViewItem(SQLConnection.SelectOne("ThoiGian", "DOANHTHU_Ngay", whereNgay));
                    i.SubItems.Add(tongPhong.ToString());
                    i.SubItems.Add(tongDV.ToString());
                    i.SubItems.Add(tongCong.ToString());
                    lvThongKe.Items.Add(i);
                }
                lblTongCong.Text = "Tổng cộng: " + sum;
            }
            catch
            {

            }
        }
        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
