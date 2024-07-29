namespace tinhtiennuoc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbtep = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmoi = new System.Windows.Forms.TextBox();
            this.txtcu = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthaotac = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btesc = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btmoform = new System.Windows.Forms.Button();
            this.bttinh = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.lvname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btedit = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbthongtin.SuspendLayout();
            this.grbthaotac.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.White;
            this.grbthongtin.Controls.Add(this.lblphone);
            this.grbthongtin.Controls.Add(this.label6);
            this.grbthongtin.Controls.Add(this.cbbtep);
            this.grbthongtin.Controls.Add(this.txtphone);
            this.grbthongtin.Controls.Add(this.txtmoi);
            this.grbthongtin.Controls.Add(this.txtcu);
            this.grbthongtin.Controls.Add(this.txtname);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.label2);
            this.grbthongtin.Controls.Add(this.label1);
            this.grbthongtin.Location = new System.Drawing.Point(207, 19);
            this.grbthongtin.Margin = new System.Windows.Forms.Padding(4);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Padding = new System.Windows.Forms.Padding(4);
            this.grbthongtin.Size = new System.Drawing.Size(1215, 287);
            this.grbthongtin.TabIndex = 0;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Information";
            this.grbthongtin.Enter += new System.EventHandler(this.grbthongtin_Enter);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(25, 123);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(84, 28);
            this.lblphone.TabIndex = 13;
            this.lblphone.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer File:";
            // 
            // cbbtep
            // 
            this.cbbtep.FormattingEnabled = true;
            this.cbbtep.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.cbbtep.Location = new System.Drawing.Point(193, 172);
            this.cbbtep.Name = "cbbtep";
            this.cbbtep.Size = new System.Drawing.Size(229, 36);
            this.cbbtep.TabIndex = 2;
            this.cbbtep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(193, 117);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(229, 35);
            this.txtphone.TabIndex = 1;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtmoi
            // 
            this.txtmoi.Location = new System.Drawing.Point(881, 116);
            this.txtmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtmoi.Name = "txtmoi";
            this.txtmoi.Size = new System.Drawing.Size(229, 35);
            this.txtmoi.TabIndex = 4;
            this.txtmoi.TextChanged += new System.EventHandler(this.txtmoi_TextChanged);
            // 
            // txtcu
            // 
            this.txtcu.Location = new System.Drawing.Point(881, 61);
            this.txtcu.Margin = new System.Windows.Forms.Padding(4);
            this.txtcu.Name = "txtcu";
            this.txtcu.Size = new System.Drawing.Size(229, 35);
            this.txtcu.TabIndex = 3;
            this.txtcu.TextChanged += new System.EventHandler(this.txtcu_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(193, 69);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(229, 35);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Water volume this month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Water volume last month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grbthaotac
            // 
            this.grbthaotac.BackColor = System.Drawing.Color.Silver;
            this.grbthaotac.Controls.Add(this.button1);
            this.grbthaotac.Controls.Add(this.btedit);
            this.grbthaotac.Controls.Add(this.btxoa);
            this.grbthaotac.Controls.Add(this.btesc);
            this.grbthaotac.Controls.Add(this.btreset);
            this.grbthaotac.Controls.Add(this.btmoform);
            this.grbthaotac.Controls.Add(this.bttinh);
            this.grbthaotac.Location = new System.Drawing.Point(483, 314);
            this.grbthaotac.Margin = new System.Windows.Forms.Padding(4);
            this.grbthaotac.Name = "grbthaotac";
            this.grbthaotac.Padding = new System.Windows.Forms.Padding(4);
            this.grbthaotac.Size = new System.Drawing.Size(675, 149);
            this.grbthaotac.TabIndex = 1;
            this.grbthaotac.TabStop = false;
            this.grbthaotac.Text = "Operation";
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btxoa.Location = new System.Drawing.Point(187, 79);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(125, 38);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Delete";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Visible = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btesc
            // 
            this.btesc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btesc.Location = new System.Drawing.Point(318, 80);
            this.btesc.Name = "btesc";
            this.btesc.Size = new System.Drawing.Size(123, 37);
            this.btesc.TabIndex = 4;
            this.btesc.Text = "Esc";
            this.btesc.UseVisualStyleBackColor = false;
            this.btesc.Click += new System.EventHandler(this.btesc_Click);
            // 
            // btreset
            // 
            this.btreset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btreset.Location = new System.Drawing.Point(445, 80);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(125, 38);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = false;
            this.btreset.Visible = false;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btmoform
            // 
            this.btmoform.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btmoform.Location = new System.Drawing.Point(187, 35);
            this.btmoform.Name = "btmoform";
            this.btmoform.Size = new System.Drawing.Size(383, 38);
            this.btmoform.TabIndex = 1;
            this.btmoform.Text = "View Customer File Information";
            this.btmoform.UseVisualStyleBackColor = false;
            this.btmoform.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttinh
            // 
            this.bttinh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bttinh.Location = new System.Drawing.Point(7, 35);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(155, 82);
            this.bttinh.TabIndex = 0;
            this.bttinh.Text = "Prepare the bill";
            this.bttinh.UseVisualStyleBackColor = false;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // lv
            // 
            this.lv.BackColor = System.Drawing.Color.White;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvname,
            this.lvphone,
            this.lvtep,
            this.lvcu,
            this.lvmoi,
            this.lvtong,
            this.lvtien});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(20, 470);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1595, 378);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // lvname
            // 
            this.lvname.Text = "Name";
            this.lvname.Width = 227;
            // 
            // lvphone
            // 
            this.lvphone.Text = "Phone";
            this.lvphone.Width = 219;
            // 
            // lvtep
            // 
            this.lvtep.Text = "Customer File";
            this.lvtep.Width = 234;
            // 
            // lvcu
            // 
            this.lvcu.Text = "Water volume last month";
            this.lvcu.Width = 259;
            // 
            // lvmoi
            // 
            this.lvmoi.Text = "Water volume this month";
            this.lvmoi.Width = 264;
            // 
            // lvtong
            // 
            this.lvtong.Text = "Amount of Water Used";
            this.lvtong.Width = 240;
            // 
            // lvtien
            // 
            this.lvtien.Text = "Total Money";
            this.lvtien.Width = 319;
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btedit.Location = new System.Drawing.Point(189, 123);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(123, 37);
            this.btedit.TabIndex = 6;
            this.btedit.Text = "Edit";
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Visible = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(1430, 46);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.Size = new System.Drawing.Size(176, 35);
            this.txtcode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1425, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Code:";
            // 
            // bttc
            // 
            this.bttc.Location = new System.Drawing.Point(1430, 94);
            this.bttc.Name = "bttc";
            this.bttc.Size = new System.Drawing.Size(176, 42);
            this.bttc.TabIndex = 5;
            this.bttc.Text = "Truy Cập";
            this.bttc.UseVisualStyleBackColor = true;
            this.bttc.Click += new System.EventHandler(this.bttc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(318, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Print bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1618, 860);
            this.ControlBox = false;
            this.Controls.Add(this.bttc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.grbthaotac);
            this.Controls.Add(this.grbthongtin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng Dụng Tính Tiền Nước";
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.grbthaotac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmoi;
        private System.Windows.Forms.TextBox txtcu;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox grbthaotac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbtep;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvcu;
        private System.Windows.Forms.ColumnHeader lvmoi;
        private System.Windows.Forms.ColumnHeader lvtong;
        private System.Windows.Forms.ColumnHeader lvtien;
        private System.Windows.Forms.Button btmoform;
        private System.Windows.Forms.Button btesc;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.ColumnHeader lvname;
        private System.Windows.Forms.ColumnHeader lvphone;
        private System.Windows.Forms.ColumnHeader lvtep;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttc;
        private System.Windows.Forms.Button button1;
    }
}

