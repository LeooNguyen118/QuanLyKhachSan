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
    public partial class PageRoomInfo : UserControl
    {
        Room room;
        bool actionButtonType;
        public Room Room
        {
            set
            {
                room = value;
                VisibleSwitch(true);
                lblSoPhong.Text = room.RoomID;
                lblLoaiPhong.Text = room.RoomType;
                if (room.RoomStatus)
                {
                    lblStatus.Text = "Có người";
                    btnAction.Text = "Trả Phòng";
                    btnDoiPhong.Visible = true;
                    actionButtonType = true;
                }
                else
                {
                    lblStatus.Text = "Còn trống";
                    btnAction.Text = "Đặt Phòng";
                    btnDoiPhong.Visible = false;
                    actionButtonType = false;
                }
                lblGia.Text = room.Price.ToString(); 
            }
        }

        public PageRoom ParentF { get => _parent; set => _parent = value; }

        public PageRoomInfo()
        {
            InitializeComponent();
            VisibleSwitch(false);
            btnDoiPhong.Visible = false;
        }
        void VisibleSwitch(bool b)
        {
            lblEmpty.Visible = !b;
            lblTLoaiPhong.Visible = b;
            lblTSoPhong.Visible = b;
            lblTStatus.Visible = b;
            lblTGia.Visible = b;
            lblLoaiPhong.Visible = b;
            lblSoPhong.Visible = b;
            lblStatus.Visible = b;
            lblGia.Visible = b;
            btnAction.Visible = b;
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnAction":
                    if (actionButtonType)
                    {
                        ThanhToan thanhToan = new ThanhToan(room.RoomType + room.RoomID);
                        thanhToan.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                        thanhToan.Show();
                    }
                    else
                    {
                        DatPhong datPhong = new DatPhong(room.RoomType + room.RoomID);
                        datPhong.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                        datPhong.Show();
                    }
                    break;
                case "btnDoiPhong":
                    DoiPhong DoiPhong = new DoiPhong(room.RoomType + room.RoomID);
                    DoiPhong.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                    DoiPhong.Show();
                    break;
            }
        }

        PageRoom _parent;
        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Reload();
        }
    }
}
