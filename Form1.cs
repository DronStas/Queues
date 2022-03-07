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

            public Time()
            {
            }

            private int hours = 12;
            private int minutes = 0;
                
            public void Serch(String startbox)
            {
                string sb = "";
                int sh,sm;
                int i;
                for (i = 0; i<startbox.Length;i++)
                {
                    if (startbox[i].ToString() != ":")
                        sb += startbox[i].ToString();
                    else break;
                }
                
                sh = Convert.ToInt32(sb);
                sb = "";
                for (int j = i+1;j<startbox.Length;j++)
                {
                    sb += startbox[j].ToString();                    
                }
                sm = Convert.ToInt32(sb);
                hours = sh;
                minutes = sm;
            }
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
            public String toString()
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

            public int getHours() { return hours; }
            public int getMinute() { return minutes; }

        }
        Time regularTime;
        Time stopTime;
        Time startTime;
        int custIndex = 1;
        ListBox[] listbox = new ListBox[3];
        Timer[] kas_timer = new Timer[3];
        Label[] kas_label = new Label[3];
        
        class Customer
        {
            private int number;
            private Time start=new Time();
            private Time stop = new Time();
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
            public Customer(String status)
            {
                this.status = status;
            }
            public int getNumber()
            {
                return number;
            }
            public String getTimeStart()
            {
                return start.toString();
            }
            public String getTimeStop()
            {
                return stop.toString();
            }
            public void setTimeStart(Time start)
            {
                this.start.setTime(start.getHours(), start.getMinute());
            }
            public void setTimeStop(Time stop)
            {
                this.stop.setTime(stop.getHours(),stop.getMinute());
            }
            public void setStatus(int number)
            {
                if (number == 0)
                {
                    status = "Отказ";
                }
                else status = "Принято - " + number;
            }

            public String getStatus()
            {
                return status;
            }
        }
        Queue<Customer>[] custQueue = new Queue<Customer>[3];
        public Form1()
        {
            InitializeComponent();
            stsp_dgv.Rows.Add();
            regularTime = new Time();
            

            custQueue[0] = new Queue<Customer>();
            custQueue[1] = new Queue<Customer>();
            custQueue[2] = new Queue<Customer>();

            listbox[0] = ListKas1;
            listbox[1] = ListKas2;
            listbox[2] = ListKas3;

            kas_timer[0] = kas1_timer;
            kas_timer[1] = kas2_timer;
            kas_timer[2] = kas3_timer;

            kas_label[0] = Name_kas1;
            kas_label[1] = Name_kas2;
            kas_label[2] = Name_kas3;

            dgv_klient.Columns.Add("0", "№");
            dgv_klient.Columns.Add("1", "Пришел");
            dgv_klient.Columns.Add("2", "Ушел");
            dgv_klient.Columns.Add("3", "Статус");

            ListKas1.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas1.DrawItem += ListKas1_DrawItem;
            ListKas2.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas2.DrawItem += ListKas2_DrawItem;
            ListKas3.DrawMode = DrawMode.OwnerDrawFixed;
            ListKas3.DrawItem += ListKas3_DrawItem;
        }
        private void Start_btn_Click(object sender, EventArgs e)
        {
            regularTime.Serch(startbox.Text);

            startTime = new Time();
            startTime.Serch(startbox.Text);
            stopTime = new Time();
            stopTime.Serch(stopbox.Text);

            regularTime_timer.Enabled = true;
            addClient_timer.Enabled = true;

            
        }
        private void regularTime_timer_Tick_1(object sender, EventArgs e)
        {
            regularTime.increaseminute();
            time_label.Text = "Time: " + regularTime.toString();
            if (regularTime.getHours() > startTime.getHours());
            else
            {
                if (regularTime.getHours() == startTime.getHours())
                {
                    if (regularTime.getMinute() >= startTime.getMinute())
                    {

                    }
                    else
                    {
                        door_label.Text = "Door: " + "Close";
                        addClient_timer.Enabled = false;
                    }
                }
                else
                {
                    door_label.Text = "Door: " + "Close";
                    addClient_timer.Enabled = false;
                }
            }
            if (regularTime.getHours() < stopTime.getHours())
            {
                door_label.Text = "Door: " + "Open";
            }
            else
            {
                if (regularTime.getHours() == stopTime.getHours())
                {
                    if (regularTime.getMinute() <= stopTime.getMinute())
                    {
                        door_label.Text = "Door: " + "Open";
                    }
                    else
                    {
                        door_label.Text = "Door: " + "Close";
                        addClient_timer.Enabled = false;
                    }
                }
                else
                {
                    door_label.Text = "Door: " + "Close";
                    addClient_timer.Enabled = false;
                }
            }

            for(int i = 0; i < 3; i++)
            {
                Random x = new Random();
                int n = x.Next(5000, 10000);
                if (custQueue[i].Count != 0&& kas_timer[i].Enabled!=true)
                {
                    kas_timer[i].Interval = n;
                    labael_enter(kas_label[i], i);
                }
            }
        }
        private void ListKas1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try{
                TextRenderer.DrawText(e.Graphics, ListKas1.Items[e.Index].ToString(), e.Font,
                    e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
            }catch (Exception){
                return;
            }
        }
        private void ListKas2_DrawItem(object sender, DrawItemEventArgs e)
        {
            try { 
            TextRenderer.DrawText(e.Graphics, ListKas2.Items[e.Index].ToString(), e.Font,
                           e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
            }catch (Exception){
                return;
            }
}
        private void ListKas3_DrawItem(object sender, DrawItemEventArgs e)
        {
            try { 
            TextRenderer.DrawText(e.Graphics, ListKas3.Items[e.Index].ToString(), e.Font,
                                      e.Bounds, e.ForeColor, e.BackColor, TextFormatFlags.HorizontalCenter);
            }catch (Exception){
                return;
            }
        }

        private void addClient_timer_Tick(object sender, EventArgs e)
        { 
            addCust();
            Random x = new Random();
            int n = x.Next(500,1000);
            addClient_timer.Interval = n;

        }
        private void addCust()
        {
            Customer cust = new Customer(custIndex);
            cust.setTimeStart(regularTime);
            
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
                cust.setStatus(minIndex + 1);
                custQueue[minIndex].Enqueue(cust);
                listbox[minIndex].Items.Add(custIndex);
            }
            else
            {
                cust.setStatus(0);
                cust.setTimeStop(regularTime);
                dgv_enter(cust);
            }
                custIndex++;
            
        }

        private void kas1_timer_Tick(object sender, EventArgs e)
        {
            kas_dgv(1);
        }

        private void kas2_timer_Tick(object sender, EventArgs e)
        {
            kas_dgv(2);
        }

        private void kas3_timer_Tick(object sender, EventArgs e)
        {
            kas_dgv(3);
        }
        private void kas_dgv(int kasIndex)
        {
            kasIndex--;
            Customer cust = custQueue[kasIndex].Dequeue();
            cust.setTimeStop(regularTime);

            dgv_enter(cust);
            // зеленый
            kas_label[kasIndex].ForeColor = Color.GreenYellow;
            kas_label[kasIndex].Text = "Касса №" + (kasIndex + 1);
            kas_timer[kasIndex].Enabled = false;
        }
        private void labael_enter(Label label,int Index)
        {
            Customer cust = custQueue[Index].Peek();
            label.Text = "Касса №" + (Index + 1) + "\nКлиент-" + cust.getNumber();
            listbox[Index].Items.RemoveAt(0);
            // крассный
            kas_label[Index].ForeColor = Color.DarkRed;
            kas_timer[Index].Enabled = true;
        }
        private void dgv_enter(Customer cust)
        {
            dgv_klient.Rows.Add();
            dgv_klient[0, dgv_klient.Rows.Count - 1].Value = Convert.ToString(cust.getNumber());
            dgv_klient[1, dgv_klient.Rows.Count - 1].Value = cust.getTimeStart();
            dgv_klient[2, dgv_klient.Rows.Count - 1].Value = cust.getTimeStop();
            dgv_klient[3, dgv_klient.Rows.Count - 1].Value = cust.getStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {          
            dgv_klient.Columns[0].Width = dgv_klient.Width * 3 / 20;        
            dgv_klient.Columns[1].Width = dgv_klient.Width * 6 / 20;     
            dgv_klient.Columns[2].Width = dgv_klient.Width * 6 / 20;            
            dgv_klient.Columns[3].Width = dgv_klient.Width * 5 / 20;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

            regularTime.increaseminute();
           
        }
    }
}
