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
    public partial class DatPhong : Form
    {
        bool loadDone = false;
        public DatPhong(string soPhong)
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            LoadCBPhong(soPhong);
            LoadCBCMND();
            LoadCBCoupon();
            loadDone = true;
        }

        void LoadCBPhong(string soPhong)
        {
            string where = "TinhTrang = 0";
            DataTable dt = SQLConnection.SelectWhere("*", "Phong", where);
            cbSoPhong.DataSource = dt;
            cbSoPhong.DisplayMember = "IDPhong";
            cbSoPhong.ValueMember = "IDPhong";
            
            try
            {
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["IDPhong"].ToString() == soPhong)
                        break;
                    i++;
                }
                cbSoPhong.SelectedIndex = i;
            }
            catch
            {
                MessageBox.Show("Hết phòng trống");
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
            }

            LoadPhong(soPhong);
        }

        void LoadPhong(string soPhong)
        {
            string where = "IDPhong LIKE N'" + soPhong + "'";
            DataTable dt = SQLConnection.SelectWhere("*", "Phong", where);
            foreach (DataRow dr in dt.Rows)
            {
                lblLoaiPhong.Text = "Loại Phòng: " + dr["IDPhong"].ToString().Remove(1);
                dtpNgayDi.Value = DateTime.Now.AddDays(1);
                lblDonGia.Text = "Đơn Giá: " + dr["GiaPhong"].ToString();
                lblTongTien.Text = TongTien(dtpNgayDi.Value).ToString();
            }
        }


        void LoadCBCMND()
        {
            string where = "IDPhieuDatPhong IS NULL";
            DataTable dt = SQLConnection.SelectWhere("*", "KhachHang", where);
            DataRow dr = dt.NewRow();
            dr["CMND"] = "Thêm mới";
            dt.Rows.InsertAt(dr, 0);
            cbCMND.DataSource = dt;
            cbCMND.DisplayMember = "CMND";
            cbCMND.ValueMember = "IDKhachHang";
            cbCMND.SelectedIndex = 0;
        }
        void LoadCBCoupon()
        {
            string today = DateTime.Now.ToString();
            DataTable dt = SQLConnection.SelectWhere("IDMaGiamGia", "MaGiamGia", "HanSuDung >= '"+today+"'");
            DataRow dr = dt.NewRow();
            dr["IDMaGiamGia"] = "Không có";
            dt.Rows.InsertAt(dr, 0);
            cbCoupon.DataSource = dt;
            cbCoupon.DisplayMember = "IDMaGiamGia";
            cbCoupon.ValueMember = "IDMaGiamGia";
            cbCoupon.SelectedIndex = 0;
        }
        private void cbCMND_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = false;
            if (cbCMND.SelectedIndex == 0)
            {
                enable = true;
            }
            foreach (Control ctrl in gbAddKH.Controls)
            {
                ctrl.Enabled = enable;
            }
        }

        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhong(cbSoPhong.SelectedValue.ToString());
        }
        int TongTien(DateTime leave)
        {
            try
            {
                string[] donGiaText = lblDonGia.Text.Split(' ');
                int donGia = int.Parse(donGiaText[2]);
                TimeSpan diff = leave.Date - DateTime.Now.Date;
                int diffDays = diff.Days;
                if (diffDays == 0)
                    return donGia / 2;
                else if (diffDays > 0)
                    return donGia * diffDays;
                else
                    return 0;
            }
            catch { return 0; }
        }

        private void dtpNgayDi_ValueChanged(object sender, EventArgs e)
        {
            if (loadDone)
            {
                int compare = DateTime.Compare(dtpNgayDi.Value, DateTime.Now);
                if (compare < 0)
                {
                    MessageBox.Show("Không được đặt trước ngày hôm nay", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpNgayDi.Value = DateTime.Now.AddDays(1);
                }
                lblTongTien.Text = TongTien(dtpNgayDi.Value).ToString();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string _IDKhachHang = cbCMND.SelectedIndex == 0 ? tbCMND.Text : cbCMND.SelectedValue.ToString();
                bool selectedCB = cbCMND.SelectedIndex == 0 ? true : SQLConnection.isExist("KhachHang", "CMND", cbCMND.Text);
                if (selectedCB && tbCMND.Text.All(char.IsDigit) && tbSDT.Text.All(char.IsDigit) && tbDatCoc.Text.All(char.IsDigit) && tbSLNguoi.Text.All(char.IsDigit))
                {
                    if ((tbCMND.Text.Equals(string.Empty) || tbName.Text.Equals(string.Empty)) && cbCMND.SelectedIndex == 0)
                    {
                        MessageBox.Show("Hãy kiểm tra lại các trường vừa nhập\n\nError: Thiếu thông tin", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string _IDPhong = cbSoPhong.Text;
                        string _IDMaGiamGia = cbCoupon.SelectedIndex == 0 ? "NULL" : cbCoupon.Text;
                        string _IDPhieuDatPhong = SQLConnection.IncrID("PhieuDatPhong", "IDPhieuDatPhong").ToString();
                        //Insert Khách Hàng
                        if (cbCMND.SelectedIndex == 0)
                        {
                            string loaiKH = cbType.SelectedIndex == 0 ? "0" : "1";
                            string insCol_KH = "IDKhachHang, TenKhachHang, CMND, SDT, Mail, LoaiKhachHang, IDPhieuDatPhong";
                            string insVal_KH = "'" + _IDKhachHang + "', N'" + tbName.Text + "', '" + tbCMND.Text + "', '" + tbSDT.Text + "', N'" +
                                            tbEmail.Text + "', " + loaiKH + ", " + _IDPhieuDatPhong;
                            SQLConnection.Insert("KhachHang", insCol_KH, insVal_KH);
                        }
                        //Insert Phiếu đặt phòng
                        string insCol_PDP = "IDPhong, IDKhachHang, SLNguoi, NgayDen, SoTienCoc, IDMaGiamGia, NgayDi, TongCong, IDPhieuDatPhong, PhiDoiPhong, Phi_DichVu, Phi_MonAn, SoLanDoiPhong, DaThanhToan";
                        string insVal_PDP = "'" + _IDPhong + "', " + "'" + _IDKhachHang + "', " +
                            "" + tbSLNguoi.Text + ", '" + DateTime.Now.ToString() + "', " + tbDatCoc.Text + ", " +
                            "'" + _IDMaGiamGia + "', '" + dtpNgayDi.Value.ToString() + "', " + lblTongTien.Text + ", " + _IDPhieuDatPhong + ", 0, 0, 0, 0, 0";
                        SQLConnection.Insert("PhieuDatPhong", insCol_PDP, insVal_PDP);

                        if (cbCMND.SelectedIndex != 0)
                        {
                            SQLConnection.Update("KhachHang", "IDPhieuDatPhong = " + _IDPhieuDatPhong, "IDKhachHang = " + _IDKhachHang);
                        }

                        string updateVal = "TinhTrang = 1";
                        string updateWhere = "IDPhong LIKE '" + _IDPhong + "'";
                        SQLConnection.Update("Phong", updateVal, updateWhere);

                        MessageBox.Show("Thành Công!", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                }
                else
                    MessageBox.Show("Hãy kiểm tra lại các trường vừa nhập\n\nError: Sai định dạng", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy kiểm tra lại các trường vừa nhập\n\nError: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbCMND_TextChanged(object sender, EventArgs e)
        {
            if (cbCMND.Text != "Thêm mới")
                foreach (Control ctrl in gbAddKH.Controls)
                {
                    ctrl.Enabled = false;
                }
        }
    }
}
