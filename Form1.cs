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
            Time(int hours)
            {
                this.hours = hours;
            }
            Time(int hours, int minutes)
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
            private int number;
            private Time start;
            private Time stop;
            private string status;
            Customer (int number)
            {
                this.number = number;
            }
            Customer (Time start, Time stop)
            {
                this.start = start;
                this.stop = stop;
            }

            
            Customer (String status)
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
        }



        private void regularTime_timer_Tick(object sender, EventArgs e)
        {
            regularTime.increaseminute();
        }
        
    

    }
}
