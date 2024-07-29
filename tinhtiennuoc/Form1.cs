using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhtiennuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            thongtinsudung thongtinsudung = new thongtinsudung();
            thongtinsudung.Show();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            //string lvtien;
            string lvname = txtname.Text;
            string lvphone = txtphone.Text;
            string lvtep = cbbtep.Text;
            string lvcu = txtcu.Text;
            string lvmoi = txtmoi.Text;
            double lvtong;
            double tiennuoc;
            double tienthue;
            if (txtname.Text == "")
            {
                MessageBox.Show(
                    "Please Enter Name",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            if (txtphone.Text == "")
            {
                MessageBox.Show(
                    "Please Enter Phone",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            if (cbbtep.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please selected file",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            if (txtcu.Text == "")
            {
                MessageBox.Show(
                    "Please enter the number of countries this month",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            if (txtmoi.Text == "")
            {
                MessageBox.Show(
                    "Please enter the number of countries last month",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                double cu = double.Parse(txtcu.Text);
                double moi = double.Parse(txtmoi.Text);
                lvtong = moi - cu;
                double lvtien = 0;
                if (cbbtep.SelectedIndex == 0)
                {
                    if (lvtong < 10)
                    {

                        tiennuoc = lvtong * 5.973;
                        tienthue = tiennuoc * 0.10;
                        lvtien = tiennuoc + tienthue;
                    }
                    else if (lvtong <= 20)
                    {
                        tiennuoc = 10 * 5.973 + (lvtong - 10) * 7.052;
                        tienthue = tiennuoc * 0.10;
                        lvtien  = tiennuoc + tienthue;
                    }
                    else if (lvtong <= 30)
                    {
                        tiennuoc = 10 * 5.973 + 10 * 7.052 + (lvtong - 20) * 8.699;
                        tienthue = tiennuoc * 0.10;
                        lvtien = tienthue + tiennuoc;
                    }
                    else
                    {
                        tiennuoc = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (lvtong - 30) * 15.929;
                        tienthue = lvtong * 0.10;
                        lvtien = tienthue + tiennuoc;
                    }
                }
                else if (cbbtep.SelectedIndex == 1)
                {
                    lvtien = lvtong * 9.955;
                }
                else if (cbbtep.SelectedIndex == 2)
                {
                    lvtien = lvtong * 11.615;
                }
                else
                {
                    lvtien = lvtong * 22.068;
                }
                ListViewItem item = new ListViewItem(lvname);
                item.SubItems.Add(lvphone);
                item.SubItems.Add(lvtep);
                item.SubItems.Add(lvcu);
                item.SubItems.Add(lvmoi);
                item.SubItems.Add(lvtong.ToString());
                item.SubItems.Add(lvtien.ToString("N3") + " VND");
                lv.Items.Add(item);
                txtname.Text = "";
                txtphone.Text = "";
                cbbtep.SelectedIndex = -1;
                txtcu.Text = "";
                txtmoi.Text = "";
            }
        }
        private void btreset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to Reset",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                txtphone.Text = "";
                txtname.Text = "";
                txtcu.Text = "";
                txtmoi.Text = "";
                cbbtep.SelectedIndex = -1;
                lv.Items.Clear();
            }
        }

        private void btesc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to ESC",
                "confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtcu_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbthongtin_Enter(object sender, EventArgs e)
        {

        }

        private void txtmoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You want to delete",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                if (lv.SelectedItems.Count > 0)
                {
                    lv.Items.Remove(lv.SelectedItems[0]);
                }
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if(lv.SelectedItems.Count > 0)
            {
                var item = lv.SelectedItems[0];
                txtname.Text = item.SubItems[0].Text;
                txtphone.Text = item.SubItems[1].Text;
                cbbtep.SelectedIndex = -1;
                txtcu.Text = item.SubItems[3].Text;
                txtmoi.Text = item.SubItems[4].Text;
            }
            if (lv.SelectedItems.Count > 0)
            {
                lv.Items.Remove(lv.SelectedItems[0]);
            }
        }

        private void bttc_Click(object sender, EventArgs e)
        {
            if(txtcode.Text == "123")
            {
                btxoa.Visible = true;
                btedit.Visible = true;
                btreset.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lv.SelectedItems.Count > 0)
            {
                var item = lv.SelectedItems[0];
                string name = item.SubItems[0].Text;
                string phone = item.SubItems[1].Text;
                string tep = item.SubItems[2].Text;
                string cu = item.SubItems[3].Text;
                string moi = item.SubItems[4].Text;
                string tong = item.SubItems[5].Text;
                string tien = item.SubItems[6].Text;

                billwt billForm = new billwt(name, phone, tep, cu, moi, tong, tien);
                billForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an item to view the bill", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
