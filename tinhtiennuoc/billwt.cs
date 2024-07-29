using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhtiennuoc
{
    public partial class billwt : Form
    {
        private string name;
        private string phone;
        private string tep;
        private string cu;
        private string moi;
        private string tong;
        private string tien;
        public billwt(string name)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qr qr = new qr();
            qr.Show();
            this.Hide();
        }
        public billwt(string name, string phone, string tep, string cu, string moi, string tong, string tien)
        {
            InitializeComponent();
            this.name = name;
            this.phone = phone;
            this.tep = tep;
            this.cu = cu;
            this.moi = moi;
            this.tong = tong;
            this.tien = tien;
        }

        private void billwt_Load(object sender, EventArgs e)
        {

        }
    }
}
