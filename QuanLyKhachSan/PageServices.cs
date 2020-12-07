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
    public partial class PageServices : UserControl
    {
        Index _parent;

        public Index ParentF { get => _parent; set => _parent = value; }

        public PageServices()
        {
            InitializeComponent();
        }

        private void pnlService_Click(object sender, EventArgs e)
        {
            _parent.BringPage("roomServ");
        }

        private void pnlFood_Click(object sender, EventArgs e)
        {
            _parent.BringPage("foodServ");
        }

    }
}
