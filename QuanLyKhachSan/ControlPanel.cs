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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            CreateTS();
        }

        SqlConnection con;
        SqlDataAdapter adapter;
        DataSet ds;

        bool changes = false;

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            
        }
        private void tabPhong_Enter(object sender, EventArgs e)
        {
            try
            {
                con = SQLConnection.GetConnection();
                using (con)
                {
                    con.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM PHONG", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "Phong");
                    dgvRoom.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabFood_Enter(object sender, EventArgs e)
        {
            try
            {
                con = SQLConnection.GetConnection();
                using (con)
                {
                    con.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM MonAn", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "MonAn");
                    dgvMA.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabService_Enter(object sender, EventArgs e)
        {
            try
            {
                con = SQLConnection.GetConnection();
                using (con)
                {
                    con.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM DichVu", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "DichVu");
                    dgvDV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabCoupon_Enter(object sender, EventArgs e)
        {
            try
            {
                con = SQLConnection.GetConnection();
                using (con)
                {
                    con.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM MaGiamGia", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "MaGiamGia");
                    dgvMGG.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            con = SQLConnection.GetConnection();
            using (con)
            {
                try
                {
                    con.Open();
                    string TS_LoaiPhong = SQLConnection.SelectTS("TS_LoaiPhong");
                    string[] loaiPhong = TS_LoaiPhong.Split(',');
                    bool proceed = true;
                    for (int i = 0; i < dgvRoom.Rows.Count - 1; i++)
                    {
                        proceed = loaiPhong.Any(dgvRoom.Rows[i].Cells[1].Value.ToString().Contains);
                        if (!proceed)
                            break;
                    }

                    if (proceed)
                    {
                        adapter = new SqlDataAdapter("SELECT * FROM PHONG", con);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                        cmdBuilder.GetUpdateCommand();
                        cmdBuilder.GetInsertCommand();
                        cmdBuilder.GetDeleteCommand();
                        adapter.Update(ds, "Phong");
                        MessageBox.Show("Thành công!", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changes = true;
                    }
                    else
                        MessageBox.Show("Lỗi!\n\nSai loại phòng", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi!\n\n" + ex.Message, "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateDV_Click(object sender, EventArgs e)
        {
            con = SQLConnection.GetConnection();
            using (con)
            {
                try
                {
                    con.Open();

                    bool proceed = (dgvDV.Rows.Count - 1) <= int.Parse(SQLConnection.SelectTS("TS_SLDichVu"));

                    if (proceed)
                    {
                        adapter = new SqlDataAdapter("SELECT * FROM DICHVU", con);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                        cmdBuilder.GetUpdateCommand();
                        cmdBuilder.GetInsertCommand();
                        cmdBuilder.GetDeleteCommand();
                        adapter.Update(ds, "DichVu");
                        MessageBox.Show("Thành công!", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changes = true;
                    }
                    else
                        MessageBox.Show("Lỗi!\n\nQuá số lượng dịch vụ cho phép", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!\n\n" + ex.Message, "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnUpdateMA_Click(object sender, EventArgs e)
        {
            con = SQLConnection.GetConnection();
            try
            {
                con.Open();

                bool proceed = (dgvMA.Rows.Count - 1) <= int.Parse(SQLConnection.SelectTS("TS_SLMonAn"));

                if (proceed)
                {

                    adapter = new SqlDataAdapter("SELECT * FROM MONAN", con);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                    cmdBuilder.GetUpdateCommand();
                    cmdBuilder.GetInsertCommand();
                    cmdBuilder.GetDeleteCommand();
                    adapter.Update(ds, "MonAn");
                    MessageBox.Show("Thành công!", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changes = true;
                }
                else
                    MessageBox.Show("Lỗi!\n\nQuá số lượng món ăn cho phép", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            changes = true;
        }

        private void btnUpdateMGG_Click(object sender, EventArgs e)
        {
            con = SQLConnection.GetConnection();
            try
            {
                con.Open();
                adapter = new SqlDataAdapter("SELECT * FROM MAGIAMGIA", con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                cmdBuilder.GetUpdateCommand();
                cmdBuilder.GetInsertCommand();
                cmdBuilder.GetDeleteCommand();
                adapter.Update(ds, "MaGiamGia");
                MessageBox.Show("Thành công!", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changes = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (changes)
            {
                DialogResult result = MessageBox.Show("Để cập nhật lại dữ liệu, chương trình sẽ khởi động lại", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
           
        }

        private void tabThamSo_Enter(object sender, EventArgs e)
        {
            try
            {
                con = SQLConnection.GetConnection();
                using (con)
                {
                    con.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM THAMSO", con);
                    ds = new DataSet();
                    adapter.Fill(ds, "ThamSo");
                    dgvTS.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CreateTS()
        {
            con = SQLConnection.GetConnection();
            using (con)
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from THAMSO", con);
                int result = int.Parse(sqlCommand.ExecuteScalar().ToString());
                if (result == 0)
                {
                    string insCol = "TS_LoaiPhong, TS_SLDichVu, TS_SLMonAn, TS_DoiPhongPhat, TS_SoLanDoiPhong";
                    string insVal = "'A,B,C', 5, 5, 30, 1";
                    SQLConnection.Insert("ThamSo", insCol, insVal);
                }
            }
        }


        private void btnUpdateTS_Click(object sender, EventArgs e)
        {
            con = SQLConnection.GetConnection();
            try
            {
                con.Open();
                adapter = new SqlDataAdapter("SELECT * FROM THAMSO", con);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                cmdBuilder.GetUpdateCommand();
                adapter.Update(ds, "ThamSo");
                MessageBox.Show("Thành công!", "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changes = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!\n\n" + ex.Message, "Control Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
