using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queues
{
    public partial class Form1 : Form
    {
        class Time
        {
            public Time(int hours)
            {
                this.hours = hours;
            }
            public Time(int hours, int minutes)
            {
                this.hours = hours;
                this.minutes = minutes;
            }
            private int hours = 12;
            private int minutes = 0;

            public void increashours()
            {
                if (hours == 23)
                {
                    hours = 0;
                }
            }
            public void increaseminute()
            {
                if (minutes == 59)
                {
                    minutes = 0;
                    increashours();
                }
                else
                {
                    minutes++;
                }
            }
            public String getTime()
            {
                String strTime = "";
                if (hours < 10)
                {
                    strTime += "0" + hours;
                }
                else
                {
                    strTime += hours;
                }
                strTime += ":";
                if (minutes < 10)
                {
                    strTime += "0" + minutes;
                }
                else
                {
                    strTime += minutes;
                }
                return strTime;
            }
            public void setTime(int hours, int minutes)
            {
                if (hours >= 0 && hours <= 24)
                {
                    this.hours = hours;
                }
                else
                    throw new Exception("!(hours >= 0 && hours <= 24)");
                if(minutes>=0 && minutes<=60)
                {
                    this.minutes = minutes;
                }
                else
                    throw new Exception("!(minutes>=0 && minutes<=60)");
            }

        }
        Time regularTime;
        class Customer
        {

        }
        public Form1()
        {
            InitializeComponent();
            regularTime = new Time(9, 0);
            ListKas1.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas1.DrawItem += ListKas1_DrawItem;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Name_kas1.Text += "\nКлиент";
        }

        private void ListKas1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, ListKas1.Items[e.Index].ToString(), e.Font,
                e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }

        private void regularTime_timer_Tick_1(object sender, EventArgs e)
        {
            regularTime.increaseminute();
            time_label.Text = "Time: " + regularTime.getTime();
            door_label.Text = "Door: " + "Open";
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            regularTime_timer.Enabled = true;
        }
    }
}
