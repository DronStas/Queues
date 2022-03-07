
namespace Queues
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.stopbox = new System.Windows.Forms.ComboBox();
            this.startbox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.door_label = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.stsp_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListKas3 = new System.Windows.Forms.ListBox();
            this.ListKas2 = new System.Windows.Forms.ListBox();
            this.ListKas1 = new System.Windows.Forms.ListBox();
            this.dgv_klient = new System.Windows.Forms.DataGridView();
            this.Name_klient = new System.Windows.Forms.Label();
            this.Name_kas3 = new System.Windows.Forms.Label();
            this.Name_kas2 = new System.Windows.Forms.Label();
            this.Name_kas1 = new System.Windows.Forms.Label();
            this.regularTime_timer = new System.Windows.Forms.Timer(this.components);
            this.addClient_timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kas1_timer = new System.Windows.Forms.Timer(this.components);
            this.kas2_timer = new System.Windows.Forms.Timer(this.components);
            this.kas3_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stsp_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.stopbox);
            this.panel1.Controls.Add(this.startbox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.door_label);
            this.panel1.Controls.Add(this.Start_btn);
            this.panel1.Controls.Add(this.Pause_btn);
            this.panel1.Controls.Add(this.stsp_dgv);
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 711);
            this.panel1.TabIndex = 0;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_stop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Font = new System.Drawing.Font("Forte", 25.8F);
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stop.Location = new System.Drawing.Point(0, 525);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(267, 62);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            // 
            // stopbox
            // 
            this.stopbox.FormattingEnabled = true;
            this.stopbox.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.stopbox.Location = new System.Drawing.Point(125, 87);
            this.stopbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopbox.Name = "stopbox";
            this.stopbox.Size = new System.Drawing.Size(140, 35);
            this.stopbox.TabIndex = 9;
            // 
            // startbox
            // 
            this.startbox.FormattingEnabled = true;
            this.startbox.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.startbox.Location = new System.Drawing.Point(0, 87);
            this.startbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startbox.Name = "startbox";
            this.startbox.Size = new System.Drawing.Size(124, 35);
            this.startbox.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 43);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Начало";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 43);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Конец";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Refusal:";
            // 
            // door_label
            // 
            this.door_label.AutoSize = true;
            this.door_label.BackColor = System.Drawing.Color.Blue;
            this.door_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.door_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.door_label.Location = new System.Drawing.Point(0, 125);
            this.door_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.door_label.Name = "door_label";
            this.door_label.Size = new System.Drawing.Size(239, 47);
            this.door_label.TabIndex = 4;
            this.door_label.Text = "Door: Close";
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Start_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Start_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_btn.FlatAppearance.BorderSize = 0;
            this.Start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_btn.Font = new System.Drawing.Font("Forte", 25.8F);
            this.Start_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start_btn.Location = new System.Drawing.Point(0, 587);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(267, 62);
            this.Start_btn.TabIndex = 3;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Pause_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause_btn.Font = new System.Drawing.Font("Forte", 25.8F);
            this.Pause_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pause_btn.Location = new System.Drawing.Point(0, 649);
            this.Pause_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(267, 62);
            this.Pause_btn.TabIndex = 2;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = false;
            // 
            // stsp_dgv
            // 
            this.stsp_dgv.AllowUserToAddRows = false;
            this.stsp_dgv.AllowUserToDeleteRows = false;
            this.stsp_dgv.AllowUserToResizeColumns = false;
            this.stsp_dgv.AllowUserToResizeRows = false;
            this.stsp_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stsp_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.stsp_dgv.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.stsp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stsp_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.stsp_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.stsp_dgv.Location = new System.Drawing.Point(0, 47);
            this.stsp_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stsp_dgv.MultiSelect = false;
            this.stsp_dgv.Name = "stsp_dgv";
            this.stsp_dgv.RowHeadersVisible = false;
            this.stsp_dgv.RowHeadersWidth = 51;
            this.stsp_dgv.Size = new System.Drawing.Size(267, 78);
            this.stsp_dgv.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Начало";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Конец";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Blue;
            this.time_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.time_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_label.Location = new System.Drawing.Point(0, 0);
            this.time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(115, 47);
            this.time_label.TabIndex = 0;
            this.time_label.Text = "Time:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.ListKas3);
            this.panel2.Controls.Add(this.ListKas2);
            this.panel2.Controls.Add(this.ListKas1);
            this.panel2.Controls.Add(this.dgv_klient);
            this.panel2.Controls.Add(this.Name_klient);
            this.panel2.Controls.Add(this.Name_kas3);
            this.panel2.Controls.Add(this.Name_kas2);
            this.panel2.Controls.Add(this.Name_kas1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1414, 711);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ListKas3
            // 
            this.ListKas3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas3.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListKas3.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListKas3.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas3.FormattingEnabled = true;
            this.ListKas3.ItemHeight = 69;
            this.ListKas3.Location = new System.Drawing.Point(661, 100);
            this.ListKas3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas3.Name = "ListKas3";
            this.ListKas3.Size = new System.Drawing.Size(199, 552);
            this.ListKas3.TabIndex = 7;
            this.ListKas3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas3_DrawItem);
            // 
            // ListKas2
            // 
            this.ListKas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas2.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListKas2.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListKas2.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas2.FormattingEnabled = true;
            this.ListKas2.ItemHeight = 69;
            this.ListKas2.Location = new System.Drawing.Point(356, 100);
            this.ListKas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas2.Name = "ListKas2";
            this.ListKas2.Size = new System.Drawing.Size(199, 554);
            this.ListKas2.TabIndex = 6;
            this.ListKas2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas2_DrawItem);
            // 
            // ListKas1
            // 
            this.ListKas1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas1.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListKas1.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListKas1.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas1.FormattingEnabled = true;
            this.ListKas1.ItemHeight = 69;
            this.ListKas1.Location = new System.Drawing.Point(52, 100);
            this.ListKas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas1.Name = "ListKas1";
            this.ListKas1.Size = new System.Drawing.Size(199, 554);
            this.ListKas1.TabIndex = 5;
            this.ListKas1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas1_DrawItem);
            // 
            // dgv_klient
            // 
            this.dgv_klient.AllowUserToAddRows = false;
            this.dgv_klient.AllowUserToDeleteRows = false;
            this.dgv_klient.AllowUserToResizeColumns = false;
            this.dgv_klient.AllowUserToResizeRows = false;
            this.dgv_klient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_klient.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_klient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_klient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klient.Location = new System.Drawing.Point(941, 100);
            this.dgv_klient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_klient.Name = "dgv_klient";
            this.dgv_klient.ReadOnly = true;
            this.dgv_klient.RowHeadersVisible = false;
            this.dgv_klient.RowHeadersWidth = 51;
            this.dgv_klient.Size = new System.Drawing.Size(460, 549);
            this.dgv_klient.TabIndex = 4;
            // 
            // Name_klient
            // 
            this.Name_klient.AutoSize = true;
            this.Name_klient.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_klient.Location = new System.Drawing.Point(931, 34);
            this.Name_klient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_klient.Name = "Name_klient";
            this.Name_klient.Size = new System.Drawing.Size(124, 35);
            this.Name_klient.TabIndex = 3;
            this.Name_klient.Text = "Клиенты";
            // 
            // Name_kas3
            // 
            this.Name_kas3.AutoSize = true;
            this.Name_kas3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_kas3.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas3.Location = new System.Drawing.Point(655, 34);
            this.Name_kas3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas3.Name = "Name_kas3";
            this.Name_kas3.Size = new System.Drawing.Size(134, 35);
            this.Name_kas3.TabIndex = 2;
            this.Name_kas3.Text = "Касса №3";
            // 
            // Name_kas2
            // 
            this.Name_kas2.AutoSize = true;
            this.Name_kas2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_kas2.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas2.Location = new System.Drawing.Point(349, 34);
            this.Name_kas2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas2.Name = "Name_kas2";
            this.Name_kas2.Size = new System.Drawing.Size(134, 35);
            this.Name_kas2.TabIndex = 1;
            this.Name_kas2.Text = "Касса №2";
            // 
            // Name_kas1
            // 
            this.Name_kas1.AutoSize = true;
            this.Name_kas1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_kas1.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas1.Location = new System.Drawing.Point(45, 28);
            this.Name_kas1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas1.Name = "Name_kas1";
            this.Name_kas1.Size = new System.Drawing.Size(134, 35);
            this.Name_kas1.TabIndex = 0;
            this.Name_kas1.Text = "Касса №1";
            // 
            // regularTime_timer
            // 
            this.regularTime_timer.Tick += new System.EventHandler(this.regularTime_timer_Tick_1);
            // 
            // addClient_timer
            // 
            this.addClient_timer.Interval = 1000;
            this.addClient_timer.Tick += new System.EventHandler(this.addClient_timer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // kas1_timer
            // 
            this.kas1_timer.Tick += new System.EventHandler(this.kas1_timer_Tick);
            // 
            // kas2_timer
            // 
            this.kas2_timer.Tick += new System.EventHandler(this.kas2_timer_Tick);
            // 
            // kas3_timer
            // 
            this.kas3_timer.Tick += new System.EventHandler(this.kas3_timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Accepted:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stsp_dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.DataGridView stsp_dgv;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ListKas1;
        private System.Windows.Forms.DataGridView dgv_klient;
        private System.Windows.Forms.Label Name_klient;
        private System.Windows.Forms.Label Name_kas3;
        private System.Windows.Forms.Label Name_kas2;
        private System.Windows.Forms.Label Name_kas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox ListKas3;
        private System.Windows.Forms.ListBox ListKas2;
        private System.Windows.Forms.Timer regularTime_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label door_label;
        private System.Windows.Forms.Timer addClient_timer;
        private System.Windows.Forms.ComboBox stopbox;
        private System.Windows.Forms.ComboBox startbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer kas1_timer;
        private System.Windows.Forms.Timer kas2_timer;
        private System.Windows.Forms.Timer kas3_timer;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label1;
    }
}

