using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_8_To_do_list
{
    public partial class clsTimer : Form
    {
        public clsTimer()
        {
            InitializeComponent();
        }



        DateTime def;
        DateTime timenow = DateTime.Now;

        private void clsTimer_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ErrorProvider noty = new ErrorProvider();
            if (string.IsNullOrEmpty(txtbTitel.Text))
            {
                noty.SetError(txtbTitel, "Text Should have a value!");

                txtbTitel.Focus();

            }
            else
            {
                timenow = DateTime.Now;
                TimeSpan tasktime = new TimeSpan(Convert.ToInt16(nudHours.Value)
                , Convert.ToInt16(nudMinutes.Value),
                Convert.ToInt16(nudSecond.Value));

                def = timenow.Add(tasktime);

                timer1.Start();
            }

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            timenow = DateTime.Now;
            TimeSpan dt = def - timenow;

             string formattedTimeDifference = dt.ToString(@"hh\:mm\:ss");
             lblTime.Text= formattedTimeDifference;

            
            if (dt.TotalSeconds<=0)
            {          
                
                timer1.Stop();  
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                notifyIcon1.BalloonTipTitle = "Hi";
                notifyIcon1.BalloonTipText = txtbTitel.Text;
                notifyIcon1.ShowBalloonTip(1000);

            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            TimeSpan tim = TimeSpan.Zero;

            nudHours.Value = 0;
            nudMinutes.Value = 0;
            nudSecond.Value = 0;

            string formattedTimeDifference = tim.ToString(@"hh\:mm\:ss");
            lblTime.Text = formattedTimeDifference;

            txtbTitel.Text = "";
        }
    }
}
