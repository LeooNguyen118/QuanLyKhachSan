using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Service
    {
        string name;
        int price;
        string id;
        bool type;
        //type: true: Dịch vụ, false: Món ăn

        public Service(string name, int price, string id, bool type)
        {
            this.name = name;
            this.price = price;
            this.id = id;
            this.type = type;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Id { get => id; set => id = value; }
        public bool Type { get => type; set => type = value; }
    }
}
