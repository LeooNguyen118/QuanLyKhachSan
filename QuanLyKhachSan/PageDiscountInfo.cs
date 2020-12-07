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
    partial class PageDiscountInfo : UserControl
    {
        Discount discount;
        public Discount Discount
        {
            set
            {
                discount = value;
                VisibleSwitch(true);
                lblMaGG.Text = "Mã giảm giá: " + discount.MaGiamGia;
                lblHieuQua.Text = "Mô tả: " + discount.MoTa;
                lblExpiryDate.Text = "Ngày hết hạn: " + discount.Expiry.ToString("MM/dd/yyyy"); ;
            }
        }
        public PageDiscountInfo()
        {
            InitializeComponent();
            VisibleSwitch(false);
        }
        
        void VisibleSwitch(bool b)
        {
            lblEmpty.Visible = !b;
            lblMaGG.Visible = b;
            lblHieuQua.Visible = b;
            lblExpiryDate.Visible = b;
        }
    }
}
