using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Discount
    {
        string maGiamGia;
        string hieuQua;
        DateTime expiry;
        string moTa;

        public Discount(string maGiamGia, string moTa, DateTime expiry, string hieuQua)
        {
            this.maGiamGia = maGiamGia;
            this.moTa = moTa;
            this.expiry = expiry;
            this.hieuQua = hieuQua;
        }

        public string MaGiamGia { get => maGiamGia; set => maGiamGia = value; }
        public string HieuQua { get => hieuQua; set => hieuQua = value; }
        public DateTime Expiry { get => expiry; set => expiry = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
