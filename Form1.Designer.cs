
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.door_label = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.door_label);
            this.panel1.Controls.Add(this.Start_btn);
            this.panel1.Controls.Add(this.Pause_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // door_label
            // 
            this.door_label.AutoSize = true;
            this.door_label.BackColor = System.Drawing.Color.Blue;
            this.door_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.door_label.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.door_label.Location = new System.Drawing.Point(0, 115);
            this.door_label.Name = "door_label";
            this.door_label.Size = new System.Drawing.Size(197, 38);
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
            this.Start_btn.Location = new System.Drawing.Point(0, 478);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(200, 50);
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
            this.Pause_btn.Location = new System.Drawing.Point(0, 528);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(200, 50);
            this.Pause_btn.TabIndex = 2;
            this.Pause_btn.Text = "Pause";
            this.Pause_btn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(200, 77);
            this.dataGridView1.TabIndex = 1;
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
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(94, 38);
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
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 578);
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
            this.ListKas3.ItemHeight = 57;
            this.ListKas3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ListKas3.Location = new System.Drawing.Point(496, 81);
            this.ListKas3.Name = "ListKas3";
            this.ListKas3.Size = new System.Drawing.Size(149, 399);
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
            this.ListKas2.ItemHeight = 57;
            this.ListKas2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ListKas2.Location = new System.Drawing.Point(267, 81);
            this.ListKas2.Name = "ListKas2";
            this.ListKas2.Size = new System.Drawing.Size(150, 401);
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
            this.ListKas1.ItemHeight = 57;
            this.ListKas1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ListKas1.Location = new System.Drawing.Point(39, 81);
            this.ListKas1.Name = "ListKas1";
            this.ListKas1.Size = new System.Drawing.Size(150, 401);
            this.ListKas1.TabIndex = 5;
            this.ListKas1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListKas1_DrawItem);
            // 
            // dgv_klient
            // 
            this.dgv_klient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_klient.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_klient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klient.Location = new System.Drawing.Point(703, 81);
            this.dgv_klient.Name = "dgv_klient";
            this.dgv_klient.RowHeadersVisible = false;
            this.dgv_klient.RowHeadersWidth = 51;
            this.dgv_klient.Size = new System.Drawing.Size(346, 483);
            this.dgv_klient.TabIndex = 4;
            // 
            // Name_klient
            // 
            this.Name_klient.AutoSize = true;
            this.Name_klient.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_klient.Location = new System.Drawing.Point(698, 28);
            this.Name_klient.Name = "Name_klient";
            this.Name_klient.Size = new System.Drawing.Size(101, 29);
            this.Name_klient.TabIndex = 3;
            this.Name_klient.Text = "Клиенты";
            // 
            // Name_kas3
            // 
            this.Name_kas3.AutoSize = true;
            this.Name_kas3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_kas3.Location = new System.Drawing.Point(491, 28);
            this.Name_kas3.Name = "Name_kas3";
            this.Name_kas3.Size = new System.Drawing.Size(107, 29);
            this.Name_kas3.TabIndex = 2;
            this.Name_kas3.Text = "Касса №3";
            // 
            // Name_kas2
            // 
            this.Name_kas2.AutoSize = true;
            this.Name_kas2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.Name_kas2.Location = new System.Drawing.Point(262, 28);
            this.Name_kas2.Name = "Name_kas2";
            this.Name_kas2.Size = new System.Drawing.Size(107, 29);
            this.Name_kas2.TabIndex = 1;
            this.Name_kas2.Text = "Касса №2";
            // 
            // Name_kas1
            // 
            this.Name_kas1.AutoSize = true;
            this.Name_kas1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_kas1.Location = new System.Drawing.Point(34, 23);
            this.Name_kas1.Name = "Name_kas1";
            this.Name_kas1.Size = new System.Drawing.Size(107, 29);
            this.Name_kas1.TabIndex = 0;
            this.Name_kas1.Text = "Касса №1";
            // 
            // regularTime_timer
            // 
            this.regularTime_timer.Tick += new System.EventHandler(this.regularTime_timer_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

