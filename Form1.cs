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
                if (hours >= 0 && hours <= 24)
                {
                    this.hours = hours;
                }
                else
                    throw new Exception("!(hours >= 0 && hours <= 24)");
            }
            public Time(int hours, int minutes)
            {
                if (hours >= 0 && hours < 24)
                {
                    this.hours = hours;
                }
                else
                    throw new Exception("!(hours >= 0 && hours <= 24)");
                if (minutes >= 0 && minutes < 60)
                {
                    this.minutes = minutes;
                }
                else
                    throw new Exception("!(minutes>=0 && minutes<=60)");
            }
            private int hours = 12;
            private int minutes = 0;

            public void increashours()
            {
                if (hours == 23)
                {
                    hours = 0;
                }
                else
                {
                    hours++;
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
                if (hours >= 0 && hours < 24)
                {
                    this.hours = hours;
                }
                else
                    throw new Exception("!(hours >= 0 && hours <= 24)");
                if(minutes>=0 && minutes <60)
                {
                    this.minutes = minutes;
                }
                else
                    throw new Exception("!(minutes>=0 && minutes<=60)");
            }

        }
        Time regularTime;
        int custIndex = 1;
        class Customer
        {
            private int number;
            private Time start;
            private Time stop;
            private string status;

            public Customer()
            {

            }
            public Customer(int number)
            {
                this.number = number;
            }
            public Customer(Time start, Time stop)
            {
                this.start = start;
                this.stop = stop;
            }

            public void setTimeStart(Time start)
            {
                this.start = start;
            }
            public Customer(String status)
            {
                this.status = status;
            }

            public void setStatus(int number)
            {
                String status = "";
                if (number == 0)
                {
                    status = number + "Отказ";
                }
                else status = number + "Принято";

            }

            public String getStatus(String status)
            {
                return status;
            }
        }
        public Form1()
        {
            InitializeComponent();
            stsp_dgv.Rows.Add();
            regularTime = new Time(9, 0);

            ListKas1.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas1.DrawItem += ListKas1_DrawItem;
            ListKas2.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas2.DrawItem += ListKas2_DrawItem;
            ListKas3.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas3.DrawItem += ListKas3_DrawItem;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Name_kas1.Text += "\nКлиент";
        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            regularTime = new Time(9, 0);
            regularTime_timer.Enabled = true;
            addClient_timer.Enabled = true;
        }
        private void regularTime_timer_Tick_1(object sender, EventArgs e)
        {
            regularTime.increaseminute();
            
            time_label.Text = "Time: " + regularTime.getTime();
            door_label.Text = "Door: " + "Open";
        }

        private void ListKas1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, ListKas1.Items[e.Index].ToString(), e.Font,
                e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }
        private void ListKas2_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, ListKas2.Items[e.Index].ToString(), e.Font,
                           e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }

        private void ListKas3_DrawItem(object sender, DrawItemEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, ListKas3.Items[e.Index].ToString(), e.Font,
                                      e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
        }

        private void addClient_timer_Tick(object sender, EventArgs e)
        {
            addCust();
            Random x = new Random();
            int n = x.Next(100, 500);
            addClient_timer.Interval = n;
        }
        private void addCust()
        {
            Customer cust = new Customer(custIndex);
            cust.setTimeStart(regularTime);
            ListBox[] listbox = new ListBox[3];
            listbox[0] = ListKas1;
            listbox[1] = ListKas2;
            listbox[2] = ListKas3;
            int minqueu = ListKas1.Items.Count;
            int minIndex = 0;
            if (minqueu > ListKas2.Items.Count)
            {
                minqueu = ListKas2.Items.Count;
                minIndex = 1;
            }
            if (minqueu > ListKas3.Items.Count)
            {
                minqueu = ListKas3.Items.Count;
                minIndex = 2;
            }
            if (minqueu < 6)
            {
                listbox[minIndex].Items.Add(custIndex);
            }
            else
            {

            }
                custIndex++;
            
        }

        private void kas1_timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
