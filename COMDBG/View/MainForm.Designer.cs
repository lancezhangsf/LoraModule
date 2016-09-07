namespace COMDBG
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comListCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baudRateCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopBitsCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityCbx = new System.Windows.Forms.ComboBox();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoReplyCbx = new System.Windows.Forms.CheckBox();
            this.addCRCcbx = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendIntervalTimetbx = new System.Windows.Forms.TextBox();
            this.autoSendcbx = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.recStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.clearReceivebtn = new System.Windows.Forms.Button();
            this.clearSendbtn = new System.Windows.Forms.Button();
            this.receivetbx = new System.Windows.Forms.TextBox();
            this.sendtbx = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendtimer = new System.Windows.Forms.Timer(this.components);
            this.refreshbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.handshakingcbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.write_cfg = new System.Windows.Forms.Button();
            this.read_cfg = new System.Windows.Forms.Button();
            this.gb_mode = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_mode = new System.Windows.Forms.ComboBox();
            this.gb_moduleuart = new System.Windows.Forms.GroupBox();
            this.cb_modulebr = new System.Windows.Forms.ComboBox();
            this.cb_modulecheck = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_power = new System.Windows.Forms.GroupBox();
            this.cb_power = new System.Windows.Forms.ComboBox();
            this.gb_node = new System.Windows.Forms.GroupBox();
            this.cb_node = new System.Windows.Forms.ComboBox();
            this.gb_bw = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_bw = new System.Windows.Forms.ComboBox();
            this.gb_factor = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_factor = new System.Windows.Forms.ComboBox();
            this.gb_fe = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_freq = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_mode.SuspendLayout();
            this.gb_moduleuart.SuspendLayout();
            this.gb_power.SuspendLayout();
            this.gb_node.SuspendLayout();
            this.gb_bw.SuspendLayout();
            this.gb_factor.SuspendLayout();
            this.gb_fe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comListCbx
            // 
            this.comListCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comListCbx.FormattingEnabled = true;
            this.comListCbx.Location = new System.Drawing.Point(14, 35);
            this.comListCbx.Name = "comListCbx";
            this.comListCbx.Size = new System.Drawing.Size(74, 20);
            this.comListCbx.TabIndex = 7;
            this.comListCbx.SelectedIndexChanged += new System.EventHandler(this.comListCbx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baud Rate:";
            // 
            // baudRateCbx
            // 
            this.baudRateCbx.FormattingEnabled = true;
            this.baudRateCbx.Location = new System.Drawing.Point(14, 75);
            this.baudRateCbx.Name = "baudRateCbx";
            this.baudRateCbx.Size = new System.Drawing.Size(74, 20);
            this.baudRateCbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Bits:";
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.FormattingEnabled = true;
            this.dataBitsCbx.Location = new System.Drawing.Point(14, 115);
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(74, 20);
            this.dataBitsCbx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stop Bits:";
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.FormattingEnabled = true;
            this.stopBitsCbx.Location = new System.Drawing.Point(14, 155);
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(74, 20);
            this.stopBitsCbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parity:";
            // 
            // parityCbx
            // 
            this.parityCbx.FormattingEnabled = true;
            this.parityCbx.Location = new System.Drawing.Point(14, 195);
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(74, 20);
            this.parityCbx.TabIndex = 15;
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.Enabled = false;
            this.openCloseSpbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openCloseSpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCloseSpbtn.Location = new System.Drawing.Point(14, 311);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(74, 36);
            this.openCloseSpbtn.TabIndex = 17;
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            this.openCloseSpbtn.Click += new System.EventHandler(this.openCloseSpbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoReplyCbx);
            this.groupBox1.Controls.Add(this.addCRCcbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sendIntervalTimetbx);
            this.groupBox1.Controls.Add(this.autoSendcbx);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.sendHexRadiobtn);
            this.groupBox1.Controls.Add(this.sendStrRadiobtn);
            this.groupBox1.Controls.Add(this.clearReceivebtn);
            this.groupBox1.Controls.Add(this.clearSendbtn);
            this.groupBox1.Controls.Add(this.receivetbx);
            this.groupBox1.Controls.Add(this.sendtbx);
            this.groupBox1.Controls.Add(this.sendbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 355);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // autoReplyCbx
            // 
            this.autoReplyCbx.AutoSize = true;
            this.autoReplyCbx.Enabled = false;
            this.autoReplyCbx.Location = new System.Drawing.Point(14, 334);
            this.autoReplyCbx.Name = "autoReplyCbx";
            this.autoReplyCbx.Size = new System.Drawing.Size(81, 19);
            this.autoReplyCbx.TabIndex = 25;
            this.autoReplyCbx.Text = "AutoReply";
            this.autoReplyCbx.UseVisualStyleBackColor = true;
            // 
            // addCRCcbx
            // 
            this.addCRCcbx.AutoSize = true;
            this.addCRCcbx.Enabled = false;
            this.addCRCcbx.Location = new System.Drawing.Point(186, 313);
            this.addCRCcbx.Name = "addCRCcbx";
            this.addCRCcbx.Size = new System.Drawing.Size(75, 19);
            this.addCRCcbx.TabIndex = 24;
            this.addCRCcbx.Text = "Add CRC";
            this.addCRCcbx.UseVisualStyleBackColor = true;
            this.addCRCcbx.CheckedChanged += new System.EventHandler(this.addCRCcbx_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "ms";
            // 
            // sendIntervalTimetbx
            // 
            this.sendIntervalTimetbx.Location = new System.Drawing.Point(93, 311);
            this.sendIntervalTimetbx.MaxLength = 9;
            this.sendIntervalTimetbx.Name = "sendIntervalTimetbx";
            this.sendIntervalTimetbx.Size = new System.Drawing.Size(44, 21);
            this.sendIntervalTimetbx.TabIndex = 22;
            this.sendIntervalTimetbx.Text = "1000";
            this.sendIntervalTimetbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendIntervalTimetbx_KeyPress);
            // 
            // autoSendcbx
            // 
            this.autoSendcbx.AutoSize = true;
            this.autoSendcbx.Enabled = false;
            this.autoSendcbx.Location = new System.Drawing.Point(14, 313);
            this.autoSendcbx.Name = "autoSendcbx";
            this.autoSendcbx.Size = new System.Drawing.Size(79, 19);
            this.autoSendcbx.TabIndex = 21;
            this.autoSendcbx.Text = "AutoSend";
            this.autoSendcbx.UseVisualStyleBackColor = true;
            this.autoSendcbx.CheckedChanged += new System.EventHandler(this.autoSendcbx_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recHexRadiobtn);
            this.panel1.Controls.Add(this.recStrRadiobtn);
            this.panel1.Location = new System.Drawing.Point(137, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 23);
            this.panel1.TabIndex = 20;
            // 
            // recHexRadiobtn
            // 
            this.recHexRadiobtn.AutoSize = true;
            this.recHexRadiobtn.Location = new System.Drawing.Point(63, 4);
            this.recHexRadiobtn.Name = "recHexRadiobtn";
            this.recHexRadiobtn.Size = new System.Drawing.Size(47, 19);
            this.recHexRadiobtn.TabIndex = 15;
            this.recHexRadiobtn.TabStop = true;
            this.recHexRadiobtn.Text = "Hex";
            this.recHexRadiobtn.UseVisualStyleBackColor = true;
            this.recHexRadiobtn.CheckedChanged += new System.EventHandler(this.recHexRadiobtn_CheckedChanged);
            // 
            // recStrRadiobtn
            // 
            this.recStrRadiobtn.AutoSize = true;
            this.recStrRadiobtn.Checked = true;
            this.recStrRadiobtn.Location = new System.Drawing.Point(2, 4);
            this.recStrRadiobtn.Name = "recStrRadiobtn";
            this.recStrRadiobtn.Size = new System.Drawing.Size(57, 19);
            this.recStrRadiobtn.TabIndex = 14;
            this.recStrRadiobtn.TabStop = true;
            this.recStrRadiobtn.Text = "String";
            this.recStrRadiobtn.UseVisualStyleBackColor = true;
            this.recStrRadiobtn.CheckedChanged += new System.EventHandler(this.recStrRadiobtn_CheckedChanged);
            // 
            // sendHexRadiobtn
            // 
            this.sendHexRadiobtn.AutoSize = true;
            this.sendHexRadiobtn.Location = new System.Drawing.Point(200, 188);
            this.sendHexRadiobtn.Name = "sendHexRadiobtn";
            this.sendHexRadiobtn.Size = new System.Drawing.Size(47, 19);
            this.sendHexRadiobtn.TabIndex = 17;
            this.sendHexRadiobtn.TabStop = true;
            this.sendHexRadiobtn.Text = "Hex";
            this.sendHexRadiobtn.UseVisualStyleBackColor = true;
            this.sendHexRadiobtn.CheckedChanged += new System.EventHandler(this.sendHexRadiobtn_CheckedChanged);
            // 
            // sendStrRadiobtn
            // 
            this.sendStrRadiobtn.AutoSize = true;
            this.sendStrRadiobtn.Checked = true;
            this.sendStrRadiobtn.Location = new System.Drawing.Point(139, 188);
            this.sendStrRadiobtn.Name = "sendStrRadiobtn";
            this.sendStrRadiobtn.Size = new System.Drawing.Size(57, 19);
            this.sendStrRadiobtn.TabIndex = 16;
            this.sendStrRadiobtn.TabStop = true;
            this.sendStrRadiobtn.Text = "String";
            this.sendStrRadiobtn.UseVisualStyleBackColor = true;
            this.sendStrRadiobtn.CheckedChanged += new System.EventHandler(this.sendStrRadiobtn_CheckedChanged);
            // 
            // clearReceivebtn
            // 
            this.clearReceivebtn.AutoSize = true;
            this.clearReceivebtn.Location = new System.Drawing.Point(278, 13);
            this.clearReceivebtn.Name = "clearReceivebtn";
            this.clearReceivebtn.Size = new System.Drawing.Size(58, 25);
            this.clearReceivebtn.TabIndex = 11;
            this.clearReceivebtn.Text = "Clear";
            this.clearReceivebtn.UseVisualStyleBackColor = true;
            this.clearReceivebtn.Click += new System.EventHandler(this.clearReceivebtn_Click);
            // 
            // clearSendbtn
            // 
            this.clearSendbtn.Location = new System.Drawing.Point(287, 181);
            this.clearSendbtn.Name = "clearSendbtn";
            this.clearSendbtn.Size = new System.Drawing.Size(58, 25);
            this.clearSendbtn.TabIndex = 10;
            this.clearSendbtn.Text = "Clear";
            this.clearSendbtn.UseVisualStyleBackColor = true;
            this.clearSendbtn.Click += new System.EventHandler(this.clearSendbtn_Click);
            // 
            // receivetbx
            // 
            this.receivetbx.BackColor = System.Drawing.SystemColors.InfoText;
            this.receivetbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivetbx.ForeColor = System.Drawing.SystemColors.Info;
            this.receivetbx.Location = new System.Drawing.Point(7, 38);
            this.receivetbx.Multiline = true;
            this.receivetbx.Name = "receivetbx";
            this.receivetbx.ReadOnly = true;
            this.receivetbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivetbx.Size = new System.Drawing.Size(354, 140);
            this.receivetbx.TabIndex = 9;
            this.receivetbx.TabStop = false;
            this.receivetbx.TextChanged += new System.EventHandler(this.receivetbx_TextChanged);
            // 
            // sendtbx
            // 
            this.sendtbx.BackColor = System.Drawing.SystemColors.InfoText;
            this.sendtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendtbx.ForeColor = System.Drawing.SystemColors.Info;
            this.sendtbx.Location = new System.Drawing.Point(7, 207);
            this.sendtbx.Multiline = true;
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendtbx.Size = new System.Drawing.Size(354, 98);
            this.sendtbx.TabIndex = 8;
            this.sendtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendtbx_KeyPress);
            // 
            // sendbtn
            // 
            this.sendbtn.AutoSize = true;
            this.sendbtn.Enabled = false;
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(287, 311);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(58, 36);
            this.sendbtn.TabIndex = 7;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Received:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send:";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedDataToolStripMenuItem,
            this.sendDataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // receivedDataToolStripMenuItem
            // 
            this.receivedDataToolStripMenuItem.Name = "receivedDataToolStripMenuItem";
            this.receivedDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.receivedDataToolStripMenuItem.Text = "Received Data...";
            this.receivedDataToolStripMenuItem.Click += new System.EventHandler(this.receivedDataToolStripMenuItem_Click);
            // 
            // sendDataToolStripMenuItem
            // 
            this.sendDataToolStripMenuItem.Name = "sendDataToolStripMenuItem";
            this.sendDataToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sendDataToolStripMenuItem.Text = "Send Data...";
            this.sendDataToolStripMenuItem.Click += new System.EventHandler(this.sendDataToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusRx,
            this.toolStripStatusTx,
            this.statusTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(281, 17);
            this.statuslabel.Spring = true;
            this.statuslabel.Text = "Not Connected";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusRx
            // 
            this.toolStripStatusRx.ActiveLinkColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusRx.Name = "toolStripStatusRx";
            this.toolStripStatusRx.Size = new System.Drawing.Size(281, 17);
            this.toolStripStatusRx.Spring = true;
            this.toolStripStatusRx.Text = "Received:";
            this.toolStripStatusRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusTx
            // 
            this.toolStripStatusTx.Name = "toolStripStatusTx";
            this.toolStripStatusTx.Size = new System.Drawing.Size(281, 17);
            this.toolStripStatusTx.Spring = true;
            this.toolStripStatusTx.Text = "Sent:";
            this.toolStripStatusTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTimeLabel
            // 
            this.statusTimeLabel.Name = "statusTimeLabel";
            this.statusTimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statustimer
            // 
            this.statustimer.Enabled = true;
            this.statustimer.Interval = 1000;
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // autoSendtimer
            // 
            this.autoSendtimer.Interval = 1000;
            this.autoSendtimer.Tick += new System.EventHandler(this.autoSendtimer_Tick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(14, 267);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(74, 32);
            this.refreshbtn.TabIndex = 22;
            this.refreshbtn.Text = "Refersh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.handshakingcbx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.refreshbtn);
            this.groupBox2.Controls.Add(this.dataBitsCbx);
            this.groupBox2.Controls.Add(this.comListCbx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.openCloseSpbtn);
            this.groupBox2.Controls.Add(this.baudRateCbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.parityCbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stopBitsCbx);
            this.groupBox2.Location = new System.Drawing.Point(2, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 355);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM";
            // 
            // handshakingcbx
            // 
            this.handshakingcbx.FormattingEnabled = true;
            this.handshakingcbx.Location = new System.Drawing.Point(14, 235);
            this.handshakingcbx.Name = "handshakingcbx";
            this.handshakingcbx.Size = new System.Drawing.Size(74, 20);
            this.handshakingcbx.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "HandShaking:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.write_cfg);
            this.groupBox3.Controls.Add(this.read_cfg);
            this.groupBox3.Controls.Add(this.gb_mode);
            this.groupBox3.Controls.Add(this.gb_moduleuart);
            this.groupBox3.Controls.Add(this.gb_power);
            this.groupBox3.Controls.Add(this.gb_node);
            this.groupBox3.Controls.Add(this.gb_bw);
            this.groupBox3.Controls.Add(this.gb_factor);
            this.groupBox3.Controls.Add(this.gb_fe);
            this.groupBox3.Location = new System.Drawing.Point(482, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 321);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RF_Module";
            // 
            // write_cfg
            // 
            this.write_cfg.Location = new System.Drawing.Point(203, 273);
            this.write_cfg.Name = "write_cfg";
            this.write_cfg.Size = new System.Drawing.Size(141, 39);
            this.write_cfg.TabIndex = 42;
            this.write_cfg.Text = "Write Cfg";
            this.write_cfg.UseVisualStyleBackColor = true;
            // 
            // read_cfg
            // 
            this.read_cfg.Location = new System.Drawing.Point(24, 274);
            this.read_cfg.Name = "read_cfg";
            this.read_cfg.Size = new System.Drawing.Size(150, 38);
            this.read_cfg.TabIndex = 41;
            this.read_cfg.Text = "Read Cfg";
            this.read_cfg.UseVisualStyleBackColor = true;
            // 
            // gb_mode
            // 
            this.gb_mode.Controls.Add(this.label10);
            this.gb_mode.Controls.Add(this.cb_mode);
            this.gb_mode.Location = new System.Drawing.Point(12, 77);
            this.gb_mode.Name = "gb_mode";
            this.gb_mode.Size = new System.Drawing.Size(170, 59);
            this.gb_mode.TabIndex = 39;
            this.gb_mode.TabStop = false;
            this.gb_mode.Text = "RF_Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mode";
            // 
            // cb_mode
            // 
            this.cb_mode.FormattingEnabled = true;
            this.cb_mode.Location = new System.Drawing.Point(20, 24);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(91, 20);
            this.cb_mode.TabIndex = 0;
            // 
            // gb_moduleuart
            // 
            this.gb_moduleuart.Controls.Add(this.cb_modulebr);
            this.gb_moduleuart.Controls.Add(this.cb_modulecheck);
            this.gb_moduleuart.Controls.Add(this.label11);
            this.gb_moduleuart.Controls.Add(this.label12);
            this.gb_moduleuart.Location = new System.Drawing.Point(12, 195);
            this.gb_moduleuart.Name = "gb_moduleuart";
            this.gb_moduleuart.Size = new System.Drawing.Size(353, 62);
            this.gb_moduleuart.TabIndex = 40;
            this.gb_moduleuart.TabStop = false;
            this.gb_moduleuart.Text = "Module_Uart";
            // 
            // cb_modulebr
            // 
            this.cb_modulebr.FormattingEnabled = true;
            this.cb_modulebr.Location = new System.Drawing.Point(68, 24);
            this.cb_modulebr.Name = "cb_modulebr";
            this.cb_modulebr.Size = new System.Drawing.Size(73, 20);
            this.cb_modulebr.TabIndex = 1;
            // 
            // cb_modulecheck
            // 
            this.cb_modulecheck.FormattingEnabled = true;
            this.cb_modulecheck.Location = new System.Drawing.Point(224, 24);
            this.cb_modulecheck.Name = "cb_modulecheck";
            this.cb_modulecheck.Size = new System.Drawing.Size(73, 20);
            this.cb_modulecheck.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Baud Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Parity";
            // 
            // gb_power
            // 
            this.gb_power.Controls.Add(this.cb_power);
            this.gb_power.Location = new System.Drawing.Point(195, 145);
            this.gb_power.Name = "gb_power";
            this.gb_power.Size = new System.Drawing.Size(170, 47);
            this.gb_power.TabIndex = 38;
            this.gb_power.TabStop = false;
            this.gb_power.Text = "RF_Power";
            // 
            // cb_power
            // 
            this.cb_power.FormattingEnabled = true;
            this.cb_power.Location = new System.Drawing.Point(17, 16);
            this.cb_power.Name = "cb_power";
            this.cb_power.Size = new System.Drawing.Size(97, 20);
            this.cb_power.TabIndex = 0;
            // 
            // gb_node
            // 
            this.gb_node.Controls.Add(this.cb_node);
            this.gb_node.Location = new System.Drawing.Point(12, 142);
            this.gb_node.Name = "gb_node";
            this.gb_node.Size = new System.Drawing.Size(170, 47);
            this.gb_node.TabIndex = 34;
            this.gb_node.TabStop = false;
            this.gb_node.Text = "Node Addr";
            // 
            // cb_node
            // 
            this.cb_node.FormattingEnabled = true;
            this.cb_node.Location = new System.Drawing.Point(20, 16);
            this.cb_node.Name = "cb_node";
            this.cb_node.Size = new System.Drawing.Size(91, 20);
            this.cb_node.TabIndex = 0;
            // 
            // gb_bw
            // 
            this.gb_bw.Controls.Add(this.label13);
            this.gb_bw.Controls.Add(this.cb_bw);
            this.gb_bw.Location = new System.Drawing.Point(195, 80);
            this.gb_bw.Name = "gb_bw";
            this.gb_bw.Size = new System.Drawing.Size(170, 59);
            this.gb_bw.TabIndex = 37;
            this.gb_bw.TabStop = false;
            this.gb_bw.Text = "RF_Bw";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Kbs";
            // 
            // cb_bw
            // 
            this.cb_bw.FormattingEnabled = true;
            this.cb_bw.Location = new System.Drawing.Point(17, 26);
            this.cb_bw.Name = "cb_bw";
            this.cb_bw.Size = new System.Drawing.Size(91, 20);
            this.cb_bw.TabIndex = 0;
            // 
            // gb_factor
            // 
            this.gb_factor.Controls.Add(this.label14);
            this.gb_factor.Controls.Add(this.cb_factor);
            this.gb_factor.Location = new System.Drawing.Point(195, 18);
            this.gb_factor.Name = "gb_factor";
            this.gb_factor.Size = new System.Drawing.Size(170, 56);
            this.gb_factor.TabIndex = 36;
            this.gb_factor.TabStop = false;
            this.gb_factor.Text = "RF_Factor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "chips";
            // 
            // cb_factor
            // 
            this.cb_factor.FormattingEnabled = true;
            this.cb_factor.Location = new System.Drawing.Point(17, 20);
            this.cb_factor.Name = "cb_factor";
            this.cb_factor.Size = new System.Drawing.Size(91, 20);
            this.cb_factor.TabIndex = 0;
            // 
            // gb_fe
            // 
            this.gb_fe.Controls.Add(this.label15);
            this.gb_fe.Controls.Add(this.cb_freq);
            this.gb_fe.Location = new System.Drawing.Point(12, 15);
            this.gb_fe.Name = "gb_fe";
            this.gb_fe.Size = new System.Drawing.Size(170, 56);
            this.gb_fe.TabIndex = 35;
            this.gb_fe.TabStop = false;
            this.gb_fe.Text = "RF_Freq";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "Mhz";
            // 
            // cb_freq
            // 
            this.cb_freq.FormattingEnabled = true;
            this.cb_freq.Location = new System.Drawing.Point(20, 21);
            this.cb_freq.Name = "cb_freq";
            this.cb_freq.Size = new System.Drawing.Size(91, 20);
            this.cb_freq.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LORA CFG v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gb_mode.ResumeLayout(false);
            this.gb_mode.PerformLayout();
            this.gb_moduleuart.ResumeLayout(false);
            this.gb_moduleuart.PerformLayout();
            this.gb_power.ResumeLayout(false);
            this.gb_node.ResumeLayout(false);
            this.gb_bw.ResumeLayout(false);
            this.gb_bw.PerformLayout();
            this.gb_factor.ResumeLayout(false);
            this.gb_factor.PerformLayout();
            this.gb_fe.ResumeLayout(false);
            this.gb_fe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comListCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox baudRateCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopBitsCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityCbx;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton recHexRadiobtn;
        private System.Windows.Forms.RadioButton recStrRadiobtn;
        private System.Windows.Forms.Button clearReceivebtn;
        private System.Windows.Forms.Button clearSendbtn;
        private System.Windows.Forms.TextBox receivetbx;
        private System.Windows.Forms.TextBox sendtbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.RadioButton sendHexRadiobtn;
        private System.Windows.Forms.RadioButton sendStrRadiobtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRx;
        private System.Windows.Forms.ToolStripStatusLabel statusTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTx;
        private System.Windows.Forms.CheckBox autoSendcbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sendIntervalTimetbx;
        private System.Windows.Forms.Timer autoSendtimer;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox handshakingcbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox addCRCcbx;
        private System.Windows.Forms.CheckBox autoReplyCbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button write_cfg;
        private System.Windows.Forms.Button read_cfg;
        private System.Windows.Forms.GroupBox gb_mode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_mode;
        private System.Windows.Forms.GroupBox gb_moduleuart;
        private System.Windows.Forms.ComboBox cb_modulebr;
        private System.Windows.Forms.ComboBox cb_modulecheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_power;
        private System.Windows.Forms.ComboBox cb_power;
        private System.Windows.Forms.GroupBox gb_node;
        private System.Windows.Forms.ComboBox cb_node;
        private System.Windows.Forms.GroupBox gb_bw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_bw;
        private System.Windows.Forms.GroupBox gb_factor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_factor;
        private System.Windows.Forms.GroupBox gb_fe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_freq;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

