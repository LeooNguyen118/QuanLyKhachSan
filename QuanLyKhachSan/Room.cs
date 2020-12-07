using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class Room
    {
        string roomID;
        string roomType;
        bool roomStatus;
        int price;

        public Room(string roomID, string roomType, bool roomStatus, string price)
        {
            this.roomID = roomID;
            this.roomType = roomType;
            this.roomStatus = roomStatus;
            this.price = int.Parse(price);
        }

        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public bool RoomStatus { get => roomStatus; set => roomStatus = value; }
        public int Price { get => price; set => price = value; }
    }
}
