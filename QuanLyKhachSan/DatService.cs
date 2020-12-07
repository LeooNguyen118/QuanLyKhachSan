using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DatService : Form
    {
        Service service;
        internal Service Service { get => service; set => service = value; }
        public DatService() { }

        internal DatService(Service service)
        {
            this.service = service;
            InitializeComponent();
            LoadCBPhong();
            cbLoaiPV.SelectedIndex = service.Type ? 0 : 1;
            cbNamePV.SelectedIndex = cbNamePV.FindStringExact(service.Name);
        }


        void LoadCBPhong()
        {
            string where = "TinhTrang = 1";
            DataTable dt = SQLConnection.SelectWhere("*", "Phong", where);
            cbSoPhong.DataSource = dt;
            cbSoPhong.DisplayMember = "IDPhong";
            cbSoPhong.ValueMember = "IDPhong";
            try
            {
                cbSoPhong.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Chưa có phòng nào được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
            }
        }
        
        private void cbLoaiPV_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (cbLoaiPV.SelectedIndex)
            {
                case 0:
                    DataTable dt = SQLConnection.Select("*", "DichVu");
                    cbNamePV.DataSource = dt;
                    cbNamePV.DisplayMember = "TenDichVu";
                    cbNamePV.ValueMember = "IDDichVu";
                    break;
                case 1:
                    dt = SQLConnection.Select("*", "MonAn");
                    cbNamePV.DataSource = dt;
                    cbNamePV.DisplayMember = "TenMonAn";
                    cbNamePV.ValueMember = "IDMonAn";
                    break;
            }
            Calculate();
        }

        private void cbNamePV_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Calculate();
        }
        private void numSoLuong_ValueChanged(object sender, System.EventArgs e)
        {
            Calculate();
        }
        void Calculate()
        {
            switch (cbLoaiPV.SelectedIndex)
            {
                case 0:
                    DataTable dt = SQLConnection.Select("*", "DichVu");
                    foreach (DataRow dr in dt.Rows)
                    {
                       
                        if (dr["IDDichVu"].ToString() == cbNamePV.SelectedValue.ToString())
                        {
                            lblThanhTien.Text = (int.Parse(dr["DonGiaDV"].ToString()) * numSoLuong.Value).ToString();
                            break;
                        }   
                    }
                    break;
                case 1:
                    dt = SQLConnection.Select("*", "MonAn");
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["IDMonAn"].ToString() == cbNamePV.SelectedValue.ToString())
                        {
                            lblThanhTien.Text = (int.Parse(dr["DonGiaMA"].ToString()) * numSoLuong.Value).ToString();
                            break;
                        }
                    }
                    break;
            }

        }

        private void btnXacNhan_Click(object sender, System.EventArgs e)
        {
            string _IDPhieuDatPhong = SQLConnection.SelectOne("IDPhieuDatPhong", "PhieuDatPhong", "IDPhong = N'" + cbSoPhong.Text + "'");
            
            if(cbLoaiPV.SelectedIndex == 0)
            {
                string insCol = "IDDichVu, IDPhieuDatPhong, SoLuong, ThanhTien, IDDatDV";
                string insVal = cbNamePV.SelectedValue.ToString() + ", " +
                    "" + _IDPhieuDatPhong + ", " + numSoLuong.Value + ", " +
                    "" + lblThanhTien.Text + ", " + SQLConnection.IncrID("Add_DichVu", "IDDatDV");
                SQLConnection.Insert("Add_DichVu", insCol, insVal);
            }
            else
            {
                string insCol = "IDMonAn, IDPhieuDatPhong, SoLuong, ThanhTien, IDDatMA";
                string insVal = cbNamePV.SelectedValue.ToString() + ", " +
                    "" + _IDPhieuDatPhong + ", " + numSoLuong.Value + ", " +
                    "" + lblThanhTien.Text + ", " + SQLConnection.IncrID("Add_MonAn", "IDDatMA");
                SQLConnection.Insert("Add_MonAn", insCol, insVal);
            }
            LoadGioHang();
        }

        void LoadGioHang()
        {
            lvGioHang.Items.Clear();
            int tongCong = 0;
            int dichVu = 0;
            int monAn = 0;
            string where = "IDPhieuDatPhong = " + SQLConnection.SelectOne("IDPhieuDatPhong", "PhieuDatPhong", "IDPhong = N'" + cbSoPhong.Text + "'");
            DataTable dt = SQLConnection.SelectWhere("*", "Add_DichVu", where);
            foreach (DataRow dr in dt.Rows)
            {
                string ten = SQLConnection.SelectOne("TenDichVu", "DichVu", "IDDichVu = " + dr["IDDichVu"].ToString());
                ListViewItem i = new ListViewItem(ten);
                i.SubItems.Add(dr["SoLuong"].ToString());
                i.SubItems.Add(dr["ThanhTien"].ToString());
                dichVu += int.Parse(dr["ThanhTien"].ToString());
                tongCong += int.Parse(dr["ThanhTien"].ToString());
                i.SubItems.Add("DV");
                i.SubItems.Add(dr["IDDatDV"].ToString());
                lvGioHang.Items.Add(i);
            }
            dt = SQLConnection.SelectWhere("*", "Add_MonAn", where);
            foreach (DataRow dr in dt.Rows)
            {
                string ten = SQLConnection.SelectOne("TenMonAn", "MonAn", "IDMonAn = " + dr["IDMonAn"].ToString());
                ListViewItem i = new ListViewItem(ten);
                i.SubItems.Add(dr["SoLuong"].ToString());
                i.SubItems.Add(dr["ThanhTien"].ToString());
                monAn += int.Parse(dr["ThanhTien"].ToString());
                tongCong += int.Parse(dr["ThanhTien"].ToString());
                i.SubItems.Add("MA");
                i.SubItems.Add(dr["IDDatMA"].ToString());
                lvGioHang.Items.Add(i);
            }
            lblTongCong.Text = tongCong.ToString();

            SQLConnection.Update("PhieuDatPhong", "Phi_DichVu = " + dichVu + ", Phi_MonAn = " + monAn,
                where);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGioHang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lvGioHang.SelectedItems[0];
                string _IDItem = item.SubItems[4].Text;
                MessageBox.Show(_IDItem);
                bool _type = item.SubItems[3].Text == "DV" ? true : false;
                if (_type)
                {
                    string where = "IDDatDV = " +_IDItem;
                    SQLConnection.Delete("Add_DichVu", where);
                }
                else
                {
                    string where = "IDDatMA = " + _IDItem;
                    SQLConnection.Delete("Add_MonAn", where);
                }
                LoadGioHang();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
