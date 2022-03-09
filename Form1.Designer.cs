
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speed_trackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accepted_label = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.stopbox = new System.Windows.Forms.ComboBox();
            this.startbox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refuse_label = new System.Windows.Forms.Label();
            this.door_label = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.stsp_dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_label = new System.Windows.Forms.Label();
            this.Simul_text = new System.Windows.Forms.Label();
            this.Simul_lable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stsp_dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.accepted_label);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.stopbox);
            this.panel1.Controls.Add(this.startbox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.refuse_label);
            this.panel1.Controls.Add(this.door_label);
            this.panel1.Controls.Add(this.Start_btn);
            this.panel1.Controls.Add(this.Pause_btn);
            this.panel1.Controls.Add(this.stsp_dgv);
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Controls.Add(this.Simul_text);
            this.panel1.Controls.Add(this.Simul_lable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 705);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.speed_trackBar);
            this.panel4.Location = new System.Drawing.Point(0, 379);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 133);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(229, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(175, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "1/4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "1/2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Speed";
            // 
            // speed_trackBar
            // 
            this.speed_trackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.speed_trackBar.Location = new System.Drawing.Point(0, 77);
            this.speed_trackBar.Margin = new System.Windows.Forms.Padding(1);
            this.speed_trackBar.Maximum = 4;
            this.speed_trackBar.Name = "speed_trackBar";
            this.speed_trackBar.Size = new System.Drawing.Size(256, 56);
            this.speed_trackBar.TabIndex = 15;
            this.speed_trackBar.Value = 2;
            this.speed_trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Location = new System.Drawing.Point(-11, 363);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 10);
            this.panel3.TabIndex = 16;
            // 
            // accepted_label
            // 
            this.accepted_label.AutoSize = true;
            this.accepted_label.BackColor = System.Drawing.Color.Blue;
            this.accepted_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.accepted_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepted_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accepted_label.Location = new System.Drawing.Point(0, 313);
            this.accepted_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.accepted_label.Name = "accepted_label";
            this.accepted_label.Size = new System.Drawing.Size(232, 47);
            this.accepted_label.TabIndex = 11;
            this.accepted_label.Text = "Accepted: 0";
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
            this.btn_stop.Location = new System.Drawing.Point(0, 519);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(259, 62);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
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
            this.stopbox.Location = new System.Drawing.Point(121, 181);
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
            this.startbox.Location = new System.Drawing.Point(-4, 181);
            this.startbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startbox.Name = "startbox";
            this.startbox.Size = new System.Drawing.Size(124, 35);
            this.startbox.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-4, 140);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(124, 43);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Начало";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(140, 43);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Конец";
            // 
            // refuse_label
            // 
            this.refuse_label.AutoSize = true;
            this.refuse_label.BackColor = System.Drawing.Color.Blue;
            this.refuse_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.refuse_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refuse_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refuse_label.Location = new System.Drawing.Point(0, 266);
            this.refuse_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refuse_label.Name = "refuse_label";
            this.refuse_label.Size = new System.Drawing.Size(214, 47);
            this.refuse_label.TabIndex = 5;
            this.refuse_label.Text = "Refusal: 0";
            // 
            // door_label
            // 
            this.door_label.AutoSize = true;
            this.door_label.BackColor = System.Drawing.Color.Blue;
            this.door_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.door_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.door_label.Location = new System.Drawing.Point(0, 219);
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
            this.Start_btn.Location = new System.Drawing.Point(0, 581);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(259, 62);
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
            this.Pause_btn.Location = new System.Drawing.Point(0, 643);
            this.Pause_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(259, 62);
            this.Pause_btn.TabIndex = 2;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = false;
            this.Pause_btn.Click += new System.EventHandler(this.Pause_btn_Click);
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
            this.stsp_dgv.Location = new System.Drawing.Point(0, 141);
            this.stsp_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stsp_dgv.MultiSelect = false;
            this.stsp_dgv.Name = "stsp_dgv";
            this.stsp_dgv.RowHeadersVisible = false;
            this.stsp_dgv.RowHeadersWidth = 51;
            this.stsp_dgv.Size = new System.Drawing.Size(259, 78);
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
            this.time_label.Location = new System.Drawing.Point(0, 94);
            this.time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(115, 47);
            this.time_label.TabIndex = 0;
            this.time_label.Text = "Time:";
            // 
            // Simul_text
            // 
            this.Simul_text.AutoSize = true;
            this.Simul_text.BackColor = System.Drawing.Color.Blue;
            this.Simul_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.Simul_text.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simul_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Simul_text.Location = new System.Drawing.Point(0, 47);
            this.Simul_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Simul_text.Name = "Simul_text";
            this.Simul_text.Size = new System.Drawing.Size(104, 47);
            this.Simul_text.TabIndex = 12;
            this.Simul_text.Text = "Stop";
            // 
            // Simul_lable
            // 
            this.Simul_lable.AutoSize = true;
            this.Simul_lable.BackColor = System.Drawing.Color.Blue;
            this.Simul_lable.Dock = System.Windows.Forms.DockStyle.Top;
            this.Simul_lable.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simul_lable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Simul_lable.Location = new System.Drawing.Point(0, 0);
            this.Simul_lable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Simul_lable.Name = "Simul_lable";
            this.Simul_lable.Size = new System.Drawing.Size(237, 47);
            this.Simul_lable.TabIndex = 14;
            this.Simul_lable.Text = "Simulation:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.ListKas3);
            this.panel2.Controls.Add(this.ListKas2);
            this.panel2.Controls.Add(this.ListKas1);
            this.panel2.Controls.Add(this.dgv_klient);
            this.panel2.Controls.Add(this.Name_klient);
            this.panel2.Controls.Add(this.Name_kas3);
            this.panel2.Controls.Add(this.Name_kas2);
            this.panel2.Controls.Add(this.Name_kas1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 705);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(896, -16);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 732);
            this.panel5.TabIndex = 17;
            // 
            // ListKas3
            // 
            this.ListKas3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas3.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListKas3.Font = new System.Drawing.Font("Arial Narrow", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListKas3.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas3.FormattingEnabled = true;
            this.ListKas3.ItemHeight = 77;
            this.ListKas3.Location = new System.Drawing.Point(661, 100);
            this.ListKas3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas3.Name = "ListKas3";
            this.ListKas3.Size = new System.Drawing.Size(199, 539);
            this.ListKas3.TabIndex = 7;
            this.ListKas3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas3_DrawItem);
            // 
            // ListKas2
            // 
            this.ListKas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas2.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListKas2.Font = new System.Drawing.Font("Arial Narrow", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ListKas2.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas2.FormattingEnabled = true;
            this.ListKas2.ItemHeight = 77;
            this.ListKas2.Location = new System.Drawing.Point(356, 100);
            this.ListKas2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas2.Name = "ListKas2";
            this.ListKas2.Size = new System.Drawing.Size(199, 541);
            this.ListKas2.TabIndex = 6;
            this.ListKas2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas2_DrawItem);
            // 
            // ListKas1
            // 
            this.ListKas1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListKas1.BackColor = System.Drawing.Color.SkyBlue;
            this.ListKas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListKas1.Font = new System.Drawing.Font("Arial Narrow", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ListKas1.ForeColor = System.Drawing.Color.DarkOrange;
            this.ListKas1.FormattingEnabled = true;
            this.ListKas1.ItemHeight = 77;
            this.ListKas1.Location = new System.Drawing.Point(52, 100);
            this.ListKas1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListKas1.Name = "ListKas1";
            this.ListKas1.Size = new System.Drawing.Size(199, 541);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_klient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_klient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klient.Location = new System.Drawing.Point(940, 94);
            this.dgv_klient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_klient.Name = "dgv_klient";
            this.dgv_klient.ReadOnly = true;
            this.dgv_klient.RowHeadersVisible = false;
            this.dgv_klient.RowHeadersWidth = 51;
            this.dgv_klient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_klient.Size = new System.Drawing.Size(470, 569);
            this.dgv_klient.TabIndex = 4;
            // 
            // Name_klient
            // 
            this.Name_klient.AutoSize = true;
            this.Name_klient.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.Name_klient.Location = new System.Drawing.Point(933, 9);
            this.Name_klient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_klient.Name = "Name_klient";
            this.Name_klient.Size = new System.Drawing.Size(193, 55);
            this.Name_klient.TabIndex = 3;
            this.Name_klient.Text = "Клиенты";
            // 
            // Name_kas3
            // 
            this.Name_kas3.AutoSize = true;
            this.Name_kas3.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.Name_kas3.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas3.Location = new System.Drawing.Point(653, 0);
            this.Name_kas3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas3.Name = "Name_kas3";
            this.Name_kas3.Size = new System.Drawing.Size(207, 55);
            this.Name_kas3.TabIndex = 2;
            this.Name_kas3.Text = "Касса №3";
            // 
            // Name_kas2
            // 
            this.Name_kas2.AutoSize = true;
            this.Name_kas2.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.Name_kas2.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas2.Location = new System.Drawing.Point(348, 0);
            this.Name_kas2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas2.Name = "Name_kas2";
            this.Name_kas2.Size = new System.Drawing.Size(207, 55);
            this.Name_kas2.TabIndex = 1;
            this.Name_kas2.Text = "Касса №2";
            // 
            // Name_kas1
            // 
            this.Name_kas1.AutoSize = true;
            this.Name_kas1.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.Name_kas1.ForeColor = System.Drawing.Color.GreenYellow;
            this.Name_kas1.Location = new System.Drawing.Point(43, 0);
            this.Name_kas1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_kas1.Name = "Name_kas1";
            this.Name_kas1.Size = new System.Drawing.Size(207, 55);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).EndInit();
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
        private System.Windows.Forms.Label refuse_label;
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
        private System.Windows.Forms.Label accepted_label;
        private System.Windows.Forms.Label Simul_text;
        private System.Windows.Forms.Label Simul_lable;
        private System.Windows.Forms.TrackBar speed_trackBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

