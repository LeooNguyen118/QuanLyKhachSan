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
    public partial class DoiPhong : Form
    {
        string soPhongCu;
        public DoiPhong(string soPhong)
        {
            InitializeComponent();
            lblPhong.Text = "Phòng cũ: " + soPhong;
            soPhongCu = soPhong;
            string where1 = "IDPhong = N'" + soPhongCu + "'";
            if(int.Parse(SQLConnection.SelectOne("SoLanDoiPhong", "PhieuDatPhong", where1)) >= int.Parse(SQLConnection.SelectTS("TS_SoLanDoiPhong")))
            {
                MessageBox.Show("Vượt quá số lần đổi cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LockControl();
            }
        }
        void LoadCBPhong()
        {
            string where = "TinhTrang = 0";
            DataTable dt = SQLConnection.SelectWhere("*", "Phong", where);
            cbPhongMoi.DataSource = dt;
            cbPhongMoi.DisplayMember = "IDPhong";
            cbPhongMoi.ValueMember = "IDPhong";
            try
            {
                cbPhongMoi.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Hết phòng trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LockControl();
            }
        }
        void LockControl()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
        }

        int SoNgayO(DateTime checkIN, DateTime checkOUT)
        {
            try
            {
                int days = (checkOUT.Date - checkIN.Date).Days;
                return days;
            }
            catch { return 0; }
        }
        private void DoiPhong_Load(object sender, EventArgs e)
        {
            LoadCBPhong();
            lblPhi.Text = "Phí đổi phòng: " + SQLConnection.SelectTS("TS_DoiPhongPhat");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string where1 = "IDPhong = N'" + soPhongCu + "'";
                DateTime checkIn = Convert.ToDateTime(SQLConnection.SelectOne("NgayDen", "PhieuDatPhong", where1));
                DateTime checkOut = Convert.ToDateTime(SQLConnection.SelectOne("NgayDi", "PhieuDatPhong", where1));
                int diffDays = SoNgayO(checkIn, checkOut);

                string where2 = "IDPhong = N'" + cbPhongMoi.SelectedValue.ToString() + "'";
                int tongPhongMoi = diffDays * Convert.ToInt32(SQLConnection.SelectOne("GiaPhong", "Phong", where2));


                string _IDPhieuDatPhong = SQLConnection.SelectOne("IDPhieuDatPhong", "PhieuDatPhong", where1);
                string where3 = "IDPhieuDatPhong = " + _IDPhieuDatPhong;
                int phatDoiPhong = int.Parse(SQLConnection.SelectOne("PhiDoiPhong", "PhieuDatPhong", where1)) + int.Parse(SQLConnection.SelectTS("TS_DoiPhongPhat"));
                int soLanDoiPhong = int.Parse(SQLConnection.SelectOne("SoLanDoiPhong", "PhieuDatPhong", where1)) + 1;

                string val = "PhiDoiPhong = " + phatDoiPhong + ", SoLanDoiPhong = " + soLanDoiPhong + 
                    ", IDPhong = N'" + cbPhongMoi.SelectedValue.ToString() + "'" +
                    ", TongCong = " + tongPhongMoi;
                SQLConnection.Update("PhieuDatPhong", val, where3);

                string valTrong = "TinhTrang = 0";
                string valCoNguoi = "TinhTrang = 1";
                SQLConnection.Update("Phong", valTrong, where1);
                SQLConnection.Update("Phong", valCoNguoi, where2);
                MessageBox.Show("Thành Công!", "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
