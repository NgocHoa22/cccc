//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace tinhtiennuoc
//{
//    public partial class bill : Form
//    {
//        private System.Windows.Forms.Label lblName;
//        private System.Windows.Forms.Label lblPhone;
//        private System.Windows.Forms.Label lblTep;
//        private System.Windows.Forms.Label lblCu;
//        private System.Windows.Forms.Label lblMoi;
//        private System.Windows.Forms.Label lblTong;
//        private System.Windows.Forms.Label lblTien;

//        private string name;
//        private string phone;
//        private string tep;
//        private string cu;
//        private string moi;
//        private string tong;
//        private string tien;

//        public bill(string name, string phone, string tep, string cu, string moi, string tong, string tien)
//        {
//            InitializeComponent();

//            this.name = name;
//            this.phone = phone;
//            this.tep = tep;
//            this.cu = cu;
//            this.moi = moi;
//            this.tong = tong;
//            this.tien = tien;
//        }

//        private void InitializeComponent()
//        {
//            this.lblctname = new System.Windows.Forms.Label();
//            this.lblctphone = new System.Windows.Forms.Label();
//            this.lbllast = new System.Windows.Forms.Label();
//            this.lblthis = new System.Windows.Forms.Label();
//            this.lblusewt = new System.Windows.Forms.Label();
//            this.txtctname = new System.Windows.Forms.TextBox();
//            this.txtctphone = new System.Windows.Forms.TextBox();
//            this.txtlast = new System.Windows.Forms.TextBox();
//            this.txtthis = new System.Windows.Forms.TextBox();
//            this.txtusewt = new System.Windows.Forms.TextBox();
//            this.txtTotal = new System.Windows.Forms.TextBox();
//            this.lbltotal = new System.Windows.Forms.Label();
//            this.btpay = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // lblctname
//            // 
//            this.lblctname.AutoSize = true;
//            this.lblctname.Location = new System.Drawing.Point(38, 47);
//            this.lblctname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblctname.Name = "lblctname";
//            this.lblctname.Size = new System.Drawing.Size(169, 27);
//            this.lblctname.TabIndex = 0;
//            this.lblctname.Text = "Customer name:";
//            // 
//            // lblctphone
//            // 
//            this.lblctphone.AutoSize = true;
//            this.lblctphone.Location = new System.Drawing.Point(38, 119);
//            this.lblctphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblctphone.Name = "lblctphone";
//            this.lblctphone.Size = new System.Drawing.Size(178, 27);
//            this.lblctphone.TabIndex = 1;
//            this.lblctphone.Text = "Phone Customer:";
//            // 
//            // lbllast
//            // 
//            this.lbllast.AutoSize = true;
//            this.lbllast.Location = new System.Drawing.Point(38, 190);
//            this.lbllast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lbllast.Name = "lbllast";
//            this.lbllast.Size = new System.Drawing.Size(193, 27);
//            this.lbllast.TabIndex = 0;
//            this.lbllast.Text = "LastMonth usages:";
//            // 
//            // lblthis
//            // 
//            this.lblthis.AutoSize = true;
//            this.lblthis.Location = new System.Drawing.Point(38, 262);
//            this.lblthis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblthis.Name = "lblthis";
//            this.lblthis.Size = new System.Drawing.Size(192, 27);
//            this.lblthis.TabIndex = 1;
//            this.lblthis.Text = "ThisMonth usages:";
//            // 
//            // lblusewt
//            // 
//            this.lblusewt.AutoSize = true;
//            this.lblusewt.Location = new System.Drawing.Point(38, 331);
//            this.lblusewt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblusewt.Name = "lblusewt";
//            this.lblusewt.Size = new System.Drawing.Size(173, 27);
//            this.lblusewt.TabIndex = 0;
//            this.lblusewt.Text = "Consump Water:";
//            // 
//            // txtctname
//            // 
//            this.txtctname.Location = new System.Drawing.Point(249, 47);
//            this.txtctname.Name = "txtctname";
//            this.txtctname.Size = new System.Drawing.Size(320, 35);
//            this.txtctname.TabIndex = 2;
//            // 
//            // txtctphone
//            // 
//            this.txtctphone.Location = new System.Drawing.Point(249, 111);
//            this.txtctphone.Name = "txtctphone";
//            this.txtctphone.Size = new System.Drawing.Size(320, 35);
//            this.txtctphone.TabIndex = 2;
//            // 
//            // txtlast
//            // 
//            this.txtlast.Location = new System.Drawing.Point(249, 182);
//            this.txtlast.Name = "txtlast";
//            this.txtlast.Size = new System.Drawing.Size(320, 35);
//            this.txtlast.TabIndex = 2;
//            // 
//            // txtthis
//            // 
//            this.txtthis.Location = new System.Drawing.Point(249, 254);
//            this.txtthis.Name = "txtthis";
//            this.txtthis.Size = new System.Drawing.Size(320, 35);
//            this.txtthis.TabIndex = 2;
//            // 
//            // txtusewt
//            // 
//            this.txtusewt.Location = new System.Drawing.Point(249, 331);
//            this.txtusewt.Name = "txtusewt";
//            this.txtusewt.Size = new System.Drawing.Size(320, 35);
//            this.txtusewt.TabIndex = 2;
//            // 
//            // txtTotal
//            // 
//            this.txtTotal.Location = new System.Drawing.Point(267, 432);
//            this.txtTotal.Name = "txtTotal";
//            this.txtTotal.Size = new System.Drawing.Size(227, 35);
//            this.txtTotal.TabIndex = 2;
//            // 
//            // lbltotal
//            // 
//            this.lbltotal.AutoSize = true;
//            this.lbltotal.Location = new System.Drawing.Point(146, 440);
//            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lbltotal.Name = "lbltotal";
//            this.lbltotal.Size = new System.Drawing.Size(102, 27);
//            this.lbltotal.TabIndex = 0;
//            this.lbltotal.Text = "Total bill:";
//            // 
//            // btpay
//            // 
//            this.btpay.Location = new System.Drawing.Point(330, 474);
//            this.btpay.Name = "btpay";
//            this.btpay.Size = new System.Drawing.Size(107, 31);
//            this.btpay.TabIndex = 3;
//            this.btpay.Text = "Pay";
//            this.btpay.UseVisualStyleBackColor = true;
//            // 
//            // bill
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
//            this.ClientSize = new System.Drawing.Size(709, 599);
//            this.Controls.Add(this.btpay);
//            this.Controls.Add(this.txtTotal);
//            this.Controls.Add(this.txtusewt);
//            this.Controls.Add(this.txtthis);
//            this.Controls.Add(this.txtlast);
//            this.Controls.Add(this.txtctphone);
//            this.Controls.Add(this.txtctname);
//            this.Controls.Add(this.lbltotal);
//            this.Controls.Add(this.lblusewt);
//            this.Controls.Add(this.lblthis);
//            this.Controls.Add(this.lbllast);
//            this.Controls.Add(this.lblctphone);
//            this.Controls.Add(this.lblctname);
//            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.Name = "bill";
//            this.Text = "bill";
//            this.Load += new System.EventHandler(this.bill_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        private void Bill_Load(object sender, EventArgs e)
//        {
//            lblName.Text = $"Name: {name}";
//            lblPhone.Text = $"Phone: {phone}";
//            lblTep.Text = $"Tep: {tep}";
//            lblCu.Text = $"Old Reading: {cu}";
//            lblMoi.Text = $"New Reading: {moi}";
//            lblTong.Text = $"Total Usage: {tong}";
//            lblTien.Text = $"Total Bill: {tien}";
//        }

//        private Label lblctname;
//        private Label lblctphone;
//        private Label lbllast;
//        private Label lblthis;
//        private Label lblusewt;
//        private TextBox txtctname;
//        private TextBox txtctphone;
//        private TextBox txtlast;
//        private TextBox txtthis;
//        private TextBox txtusewt;
//        private TextBox txtTotal;
//        private Label lbltotal;
//        private Button btpay;
//    }
//}
