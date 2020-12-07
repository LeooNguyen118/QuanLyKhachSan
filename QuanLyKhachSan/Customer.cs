using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Customer
    {
        string name, cmnd, phone, mail;
        bool type;
        string _id;

        public Customer(string name, string cmnd, string phone, string mail, bool type, string id)
        {
            this.name = name;
            this.cmnd = cmnd;
            this.phone = phone;
            this.mail = mail;
            this.type = type;
            this._id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Mail { get => mail; set => mail = value; }
        public bool Type { get => type; set => type = value; }
        public string Id { get => _id; set => _id = value; }
    }
}
