namespace TimeZones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_update = new System.Windows.Forms.Button();
            this.rchtxtbx_no_daylight_saving = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_zone_time = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbobx_tzones = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_time_in_tz = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_daylight_name = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_timezone_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_dst_ends = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_dst_start = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_DST_setting = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_utc_offset = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_local_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_UTC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_time_info = new System.Windows.Forms.Label();
            this.lbl_local_tz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpage_TZ_list = new System.Windows.Forms.TabPage();
            this.rchtxtbx_time_zones = new System.Windows.Forms.RichTextBox();
            this.tabPage_none_daylight_tz = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_zone_time.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabpage_TZ_list.SuspendLayout();
            this.tabPage_none_daylight_tz.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(57, 9);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 29);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_local_tz_Click);
            // 
            // rchtxtbx_no_daylight_saving
            // 
            this.rchtxtbx_no_daylight_saving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_no_daylight_saving.Location = new System.Drawing.Point(3, 3);
            this.rchtxtbx_no_daylight_saving.Name = "rchtxtbx_no_daylight_saving";
            this.rchtxtbx_no_daylight_saving.Size = new System.Drawing.Size(763, 431);
            this.rchtxtbx_no_daylight_saving.TabIndex = 4;
            this.rchtxtbx_no_daylight_saving.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.42146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.578544F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 522);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 466);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_zone_time);
            this.tabControl1.Controls.Add(this.tabpage_TZ_list);
            this.tabControl1.Controls.Add(this.tabPage_none_daylight_tz);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_zone_time
            // 
            this.tabPage_zone_time.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_zone_time.Location = new System.Drawing.Point(4, 25);
            this.tabPage_zone_time.Name = "tabPage_zone_time";
            this.tabPage_zone_time.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_zone_time.Size = new System.Drawing.Size(769, 437);
            this.tabPage_zone_time.TabIndex = 0;
            this.tabPage_zone_time.Text = "Time in Zone";
            this.tabPage_zone_time.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.55814F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.44186F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 431);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbobx_tzones);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 48);
            this.panel3.TabIndex = 0;
            // 
            // cmbobx_tzones
            // 
            this.cmbobx_tzones.FormattingEnabled = true;
            this.cmbobx_tzones.Location = new System.Drawing.Point(22, 12);
            this.cmbobx_tzones.Name = "cmbobx_tzones";
            this.cmbobx_tzones.Size = new System.Drawing.Size(247, 24);
            this.cmbobx_tzones.Sorted = true;
            this.cmbobx_tzones.TabIndex = 4;
            this.cmbobx_tzones.SelectedIndexChanged += new System.EventHandler(this.cmbobx_tzones_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_time_in_tz);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(308, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 48);
            this.panel4.TabIndex = 1;
            // 
            // lbl_time_in_tz
            // 
            this.lbl_time_in_tz.AutoSize = true;
            this.lbl_time_in_tz.Location = new System.Drawing.Point(52, 15);
            this.lbl_time_in_tz.Name = "lbl_time_in_tz";
            this.lbl_time_in_tz.Size = new System.Drawing.Size(32, 17);
            this.lbl_time_in_tz.TabIndex = 5;
            this.lbl_time_in_tz.Text = "???";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_update);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(536, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 48);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel6, 3);
            this.panel6.Controls.Add(this.lbl_daylight_name);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.lbl_timezone_name);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.lbl_dst_ends);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.lbl_dst_start);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lbl_DST_setting);
            this.panel6.Controls.Add(this.lbl3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lbl_utc_offset);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.lbl_local_time);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lbl_UTC);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lbl_time_info);
            this.panel6.Controls.Add(this.lbl_local_tz);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(757, 371);
            this.panel6.TabIndex = 3;
            // 
            // lbl_daylight_name
            // 
            this.lbl_daylight_name.AutoSize = true;
            this.lbl_daylight_name.Location = new System.Drawing.Point(206, 339);
            this.lbl_daylight_name.Name = "lbl_daylight_name";
            this.lbl_daylight_name.Size = new System.Drawing.Size(16, 17);
            this.lbl_daylight_name.TabIndex = 27;
            this.lbl_daylight_name.Text = "..";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Daylight Name:";
            // 
            // lbl_timezone_name
            // 
            this.lbl_timezone_name.AutoSize = true;
            this.lbl_timezone_name.Location = new System.Drawing.Point(206, 322);
            this.lbl_timezone_name.Name = "lbl_timezone_name";
            this.lbl_timezone_name.Size = new System.Drawing.Size(16, 17);
            this.lbl_timezone_name.TabIndex = 25;
            this.lbl_timezone_name.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Time Zone Name:";
            // 
            // lbl_dst_ends
            // 
            this.lbl_dst_ends.AutoSize = true;
            this.lbl_dst_ends.Location = new System.Drawing.Point(206, 168);
            this.lbl_dst_ends.Name = "lbl_dst_ends";
            this.lbl_dst_ends.Size = new System.Drawing.Size(16, 17);
            this.lbl_dst_ends.TabIndex = 23;
            this.lbl_dst_ends.Text = "..";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Ends On:";
            // 
            // lbl_dst_start
            // 
            this.lbl_dst_start.AutoSize = true;
            this.lbl_dst_start.Location = new System.Drawing.Point(206, 151);
            this.lbl_dst_start.Name = "lbl_dst_start";
            this.lbl_dst_start.Size = new System.Drawing.Size(16, 17);
            this.lbl_dst_start.TabIndex = 21;
            this.lbl_dst_start.Text = "..";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Started on:";
            // 
            // lbl_DST_setting
            // 
            this.lbl_DST_setting.AutoSize = true;
            this.lbl_DST_setting.Location = new System.Drawing.Point(206, 134);
            this.lbl_DST_setting.Name = "lbl_DST_setting";
            this.lbl_DST_setting.Size = new System.Drawing.Size(16, 17);
            this.lbl_DST_setting.TabIndex = 19;
            this.lbl_DST_setting.Text = "..";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(19, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(54, 17);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "Set To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Daylight Saving Time:";
            // 
            // lbl_utc_offset
            // 
            this.lbl_utc_offset.AutoSize = true;
            this.lbl_utc_offset.Location = new System.Drawing.Point(206, 261);
            this.lbl_utc_offset.Name = "lbl_utc_offset";
            this.lbl_utc_offset.Size = new System.Drawing.Size(16, 17);
            this.lbl_utc_offset.TabIndex = 16;
            this.lbl_utc_offset.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "UTC Offset:";
            // 
            // lbl_local_time
            // 
            this.lbl_local_time.AutoSize = true;
            this.lbl_local_time.Location = new System.Drawing.Point(206, 244);
            this.lbl_local_time.Name = "lbl_local_time";
            this.lbl_local_time.Size = new System.Drawing.Size(16, 17);
            this.lbl_local_time.TabIndex = 14;
            this.lbl_local_time.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Local Current Time:";
            // 
            // lbl_UTC
            // 
            this.lbl_UTC.AutoSize = true;
            this.lbl_UTC.Location = new System.Drawing.Point(206, 227);
            this.lbl_UTC.Name = "lbl_UTC";
            this.lbl_UTC.Size = new System.Drawing.Size(16, 17);
            this.lbl_UTC.TabIndex = 12;
            this.lbl_UTC.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "UTC:";
            // 
            // lbl_time_info
            // 
            this.lbl_time_info.AutoSize = true;
            this.lbl_time_info.Location = new System.Drawing.Point(19, 57);
            this.lbl_time_info.Name = "lbl_time_info";
            this.lbl_time_info.Size = new System.Drawing.Size(16, 17);
            this.lbl_time_info.TabIndex = 10;
            this.lbl_time_info.Text = "..";
            // 
            // lbl_local_tz
            // 
            this.lbl_local_tz.AutoSize = true;
            this.lbl_local_tz.Location = new System.Drawing.Point(206, 19);
            this.lbl_local_tz.Name = "lbl_local_tz";
            this.lbl_local_tz.Size = new System.Drawing.Size(16, 17);
            this.lbl_local_tz.TabIndex = 7;
            this.lbl_local_tz.Text = "..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local time zone:";
            // 
            // tabpage_TZ_list
            // 
            this.tabpage_TZ_list.Controls.Add(this.rchtxtbx_time_zones);
            this.tabpage_TZ_list.Location = new System.Drawing.Point(4, 25);
            this.tabpage_TZ_list.Name = "tabpage_TZ_list";
            this.tabpage_TZ_list.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_TZ_list.Size = new System.Drawing.Size(769, 437);
            this.tabpage_TZ_list.TabIndex = 1;
            this.tabpage_TZ_list.Text = "TimeZone List";
            this.tabpage_TZ_list.UseVisualStyleBackColor = true;
            // 
            // rchtxtbx_time_zones
            // 
            this.rchtxtbx_time_zones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_time_zones.Location = new System.Drawing.Point(3, 3);
            this.rchtxtbx_time_zones.Name = "rchtxtbx_time_zones";
            this.rchtxtbx_time_zones.Size = new System.Drawing.Size(763, 431);
            this.rchtxtbx_time_zones.TabIndex = 0;
            this.rchtxtbx_time_zones.Text = "";
            // 
            // tabPage_none_daylight_tz
            // 
            this.tabPage_none_daylight_tz.Controls.Add(this.rchtxtbx_no_daylight_saving);
            this.tabPage_none_daylight_tz.Location = new System.Drawing.Point(4, 25);
            this.tabPage_none_daylight_tz.Name = "tabPage_none_daylight_tz";
            this.tabPage_none_daylight_tz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_none_daylight_tz.Size = new System.Drawing.Size(769, 437);
            this.tabPage_none_daylight_tz.TabIndex = 2;
            this.tabPage_none_daylight_tz.Text = "No Daylight Saving Zones";
            this.tabPage_none_daylight_tz.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 44);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_version);
            this.panel7.Controls.Add(this.btn_exit);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(777, 44);
            this.panel7.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(690, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 32);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(9, 14);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(46, 17);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Time Zone Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_zone_time.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabpage_TZ_list.ResumeLayout(false);
            this.tabPage_none_daylight_tz.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RichTextBox rchtxtbx_no_daylight_saving;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_zone_time;
        private System.Windows.Forms.TabPage tabpage_TZ_list;
        private System.Windows.Forms.RichTextBox rchtxtbx_time_zones;
        private System.Windows.Forms.TabPage tabPage_none_daylight_tz;
        private System.Windows.Forms.ComboBox cmbobx_tzones;
        private System.Windows.Forms.Label lbl_time_in_tz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_local_tz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_time_info;
        private System.Windows.Forms.Label lbl_UTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_local_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_utc_offset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_dst_ends;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_dst_start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_DST_setting;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_daylight_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_timezone_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_version;
    }
}

