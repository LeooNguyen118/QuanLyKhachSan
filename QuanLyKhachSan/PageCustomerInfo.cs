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
    partial class PageCustomerInfo : UserControl
    {
        Customer customer;
        public Customer Customer
        {
            set
            {
                customer = value;
                VisibleSwitch(true);
                tbName.Text = customer.Name;
                tbCMND.Text = customer.Cmnd;
                if (!customer.Type)
                {
                    cbType.SelectedIndex = 0;  
                }
                else
                {
                    cbType.SelectedIndex = 1;
                }
                btnAction.Text = "Sửa thông tin";
                tbSDT.Text = customer.Phone;
                tbEmail.Text = customer.Mail;
            }
        }

        public PageCustomer ParentF { get => _parent; set => _parent = value; }

        public PageCustomerInfo()
        {
            InitializeComponent();
            VisibleSwitch(false);
        }
        void VisibleSwitch(bool b)
        {
            lblEmpty.Visible = !b;
            tbCMND.Visible = b;
            tbEmail.Visible = b;
            tbName.Visible = b;
            tbSDT.Visible = b;
            cbType.Visible = b;
            lblTCMND.Visible = b;
            lblEmail.Visible = b;
            lblTName.Visible = b;
            lblTSDT.Visible = b;
            lblTType.Visible = b;
            btnAction.Visible = b;
        }

        PageCustomer _parent;
        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbCMND.Text.All(char.IsDigit) && tbSDT.Text.All(char.IsDigit))
                {
                    int type = cbType.SelectedIndex == 0 ? 0 : 1;

                    string updateVal = "TenKhachHang = N'" + tbName.Text + "', CMND = N'" + tbCMND.Text + "', "
                        + "SDT = N'" + tbSDT.Text + "', Mail = N'" + tbEmail.Text + "', " + "LoaiKhachHang = " + type;
                    string updateWhere = "IDKhachHang LIKE '" + customer.Id + "'";
                    SQLConnection.Update("KhachHang", updateVal, updateWhere);
                    MessageBox.Show("Thành Công!", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _parent.Reload();
                }
                else
                    MessageBox.Show("Hãy kiểm tra lại các trường vừa nhập\n\nError: Sai định dạng", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hãy kiểm tra lại các trường vừa nhập\n\nError: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
