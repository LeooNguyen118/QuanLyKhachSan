using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThanhToan : Form
    {
        int tongCong = 0;
        int giamGia = 0;
        int doanhthu = 0;
        string _IDPhieuDatPhong = "";
        string soPhongDat;
        string _IDKhachHang = "";

        public ThanhToan(string soPhong)
        {
            InitializeComponent();
            if (SQLConnection.isExist("PhieuDatPhong", "IDPhong", soPhong))
            {
                FillData(soPhong);
            }
        }

        void FillData(string soPhong)
        {
            soPhongDat = soPhong;
            string where = "IDPHONG LIKE '" + soPhong +"'";
            DataTable dt = SQLConnection.SelectWhere("*", "PhieuDatPhong", where);
            DataRow dr = dt.Rows[0];
            GetData_KH(dr["IDKhachHang"].ToString());
            _IDKhachHang = dr["IDKhachHang"].ToString();
            lblSoPhong.Text = "Số phòng: " + dr["IDPhong"].ToString();
            lblNgayDi.Text = "Ngày đi: " + dr["NgayDi"].ToString();
            lblNgayDen.Text = "Ngày đến: " + dr["NgayDen"].ToString();

            
            lblTienPhong.Text = "Tổng tiền phòng: " + dr["TongCong"].ToString();
            if (int.Parse(dr["PhiDoiPhong"].ToString()) > 0)
            {
                lblTienPhong.Text += " + " + dr["PhiDoiPhong"].ToString();
            }
            tongCong += int.Parse(dr["TongCong"].ToString()) + int.Parse(dr["PhiDoiPhong"].ToString());
            

            lblTienService.Text = "Tổng tiền dịch vụ: " + dr["Phi_DichVu"].ToString();
            tongCong += int.Parse(dr["Phi_DichVu"].ToString());
            lblTienFood.Text = "Tổng tiền món ăn: " + dr["Phi_MonAn"].ToString();
            tongCong += int.Parse(dr["Phi_MonAn"].ToString());

            doanhthu += tongCong;

            lblDatCoc.Text = "Đặt cọc: " + dr["SoTienCoc"].ToString();
            giamGia += int.Parse(dr["SoTienCoc"].ToString());
            int valCoupon;
            if (SQLConnection.isExist("MaGiamGia", "IDMaGiamGia", dr["IDMaGiamGia"].ToString()))
            {
                valCoupon = int.Parse(SQLConnection.SelectOne("HieuQua", "MaGiamGia", "IDMaGiamGia = N'" + dr["IDMaGiamGia"].ToString() + "'"));
            }
            else
            {
                valCoupon = 0;
            }
            int discount = tongCong * valCoupon / 100;
            lblGiamGia.Text = "Giảm giá: " + discount.ToString();
            giamGia += discount;

            lblThanhTien.Text = (tongCong - giamGia).ToString("N0",
                System.Globalization.CultureInfo.GetCultureInfo("de"));

            doanhthu -= discount;

            _IDPhieuDatPhong = dr["IDPhieuDatPhong"].ToString();
            GetData_PV(dr["IDPhieuDatPhong"].ToString());
        }

        void GetData_KH(string idKH)
        {
            string where = "IDKhachHang LIKE '" + idKH + "'";
            DataTable dt = SQLConnection.SelectWhere("*", "KhachHang", where);
            DataRow dr = dt.Rows[0];
            lblTenKH.Text = "Tên Khách Hàng: " + dr["TenKhachHang"].ToString();
            lblCMND.Text = "CMND: " + dr["CMND"].ToString();
        }
        void GetData_PV(string idPDP)
        {
            lvService.Items.Clear();
            lvFood.Items.Clear();
            string where = "IDPhieuDatPhong = " + idPDP + "";
            DataTable dt = SQLConnection.SelectWhere("*", "Add_DichVu", where);
            foreach (DataRow dr in dt.Rows)
            {
                string ten = SQLConnection.SelectOne("TenDichVu", "DichVu", "IDDichVu = " + dr["IDDichVu"].ToString());
                ListViewItem i = new ListViewItem(ten);
                i.SubItems.Add(dr["SoLuong"].ToString());
                i.SubItems.Add(dr["ThanhTien"].ToString());
                i.SubItems.Add("DV");
                i.SubItems.Add(dr["IDDatDV"].ToString());
                lvService.Items.Add(i);
            }

            dt = SQLConnection.SelectWhere("*", "Add_MonAn", where);
            foreach (DataRow dr in dt.Rows)
            {
                string ten = SQLConnection.SelectOne("TenMonAn", "MonAn", "IDMonAn = " + dr["IDMonAn"].ToString());
                ListViewItem i = new ListViewItem(ten);
                i.SubItems.Add(dr["SoLuong"].ToString());
                i.SubItems.Add(dr["ThanhTien"].ToString());
                i.SubItems.Add("MA");
                i.SubItems.Add(dr["IDDatMA"].ToString());
                lvFood.Items.Add(i);
            }
        }
        void InsertDTNgay()
        {
            string ngayDi = Convert.ToDateTime(SQLConnection.SelectOne("NgayDi", "PhieuDatPhong", "IDPhieuDatPhong = " + _IDPhieuDatPhong))
                .ToString("MM/dd/yyyy");
            
            SqlConnection con = SQLConnection.GetConnection();
            using (con)
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM DoanhThu_Ngay WHERE ThoiGian = '" + ngayDi + "'", con);
                int result = int.Parse(sqlCommand.ExecuteScalar().ToString());
                
                int id;
                if (result == 0)
                {
                    id = SQLConnection.IncrID("DoanhThu_Ngay", "ID_DTNgay");
                }
                else
                {
                    id = int.Parse(SQLConnection.SelectOne("ID_DTNgay", "DoanhThu_Ngay", "ThoiGian = '" + ngayDi + "'"));
                }
                string insCol = "ID_DTNgay, ThoiGian, IDPhieuDatPhong";
                string insVal = id + ", '" + ngayDi + "', " + _IDPhieuDatPhong;

                SQLConnection.Insert("DoanhThu_Ngay", insCol, insVal);
            }
        }

        void CreateDTThang()
        {
            string dateDTNgay = Convert.ToDateTime(SQLConnection.SelectOne("ThoiGian", "DoanhThu_Ngay", "IDPhieuDatPhong = " + _IDPhieuDatPhong))
                .ToString("MM/yyyy");
            string _ID_DTNgay = SQLConnection.SelectOne("ID_DTNgay", "DoanhThu_Ngay", "IDPhieuDatPhong = " + _IDPhieuDatPhong);

            SqlConnection con = SQLConnection.GetConnection();
            using (con)
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM DoanhThu_Thang WHERE ThoiGian LIKE '" + dateDTNgay + "'", con);
                int result = int.Parse(sqlCommand.ExecuteScalar().ToString());
                if (result == 0)
                {
                    int id = SQLConnection.IncrID("DoanhThu_Thang", "ID_DTThang");
                    string insCol = "ID_DTThang, ThoiGian, ID_DTNgay";
                    string insVal = id + ", '" + dateDTNgay + "', " + _ID_DTNgay;
                    SQLConnection.Insert("DoanhThu_Thang", insCol, insVal);
                }
                else
                {
                    sqlCommand = new SqlCommand("SELECT COUNT(*) FROM DoanhThu_Thang WHERE ID_DTNgay = "+ _ID_DTNgay, con);
                    result = int.Parse(sqlCommand.ExecuteScalar().ToString());
                    if (result == 0)
                    {
                        int id = int.Parse(SQLConnection.SelectOne("ID_DTThang", "DoanhThu_Thang", "ThoiGian LIKE '" + dateDTNgay + "'"));
                        string insCol = "ID_DTThang, ThoiGian, ID_DTNgay";
                        string insVal = id + ", '" + dateDTNgay + "', " + _ID_DTNgay;
                        SQLConnection.Insert("DoanhThu_Thang", insCol, insVal);
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SQLConnection.Update("PhieuDatPhong", "DaThanhToan = 1", "IDPhieuDatPhong = " + _IDPhieuDatPhong);
            SQLConnection.Update("Phong", "TinhTrang = 0", "IDPHONG LIKE '" + soPhongDat + "'");
            SQLConnection.Update("KhachHang", "IDPhieuDatPhong = NULL", "IDKhachHang LIKE '" + _IDKhachHang + "'");
            try
            {
                SQLConnection.Delete("Add_DichVu", "IDPhieuDatPhong = " + _IDPhieuDatPhong);
                SQLConnection.Delete("Add_MonAn", "IDPhieuDatPhong = " + _IDPhieuDatPhong);
            }
            catch { }
            InsertDTNgay();
            CreateDTThang();
            DialogResult result = MessageBox.Show("Thanh toán thành công!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
