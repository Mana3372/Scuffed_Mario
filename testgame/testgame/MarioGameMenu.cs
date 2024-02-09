using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgame
{
    public partial class MarioGameMenu : Form
    {
        public static int scorept = 0;
        public static int difficulty;
        //public static event EventHandler<int> IntegerUpdated;
        public MarioGameMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResizeRedraw = false;
        }

        //start the game in form 2 on start
        private void button1_Click(object sender, EventArgs e)
        {
            var m = new testgame();
            m.Show();
            timer1.Start();
            label1.Text = $"Score: {scorept}";
        }

        //close enviroment on exit
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //timer to update score on form1(doesnt work)
        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            label1.Text = $"Score: {scorept}";
        }

        //chose difficulty 0 and update button status
        private void button3_Click(object sender, EventArgs e)
        {
            difficulty = 0;
            button1.Enabled = true;
            button1.Visible = true;

            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
        }

        //chose difficulty 1 and update button status
        private void button4_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            button1.Enabled = true;
            button1.Visible = true;

            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
        }

        //chose difficulty 2 and update button status
        private void button5_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            button1.Enabled = true;
            button1.Visible = true;

            button3.Enabled = false;
            button3.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            button5.Enabled = false;
            button5.Visible = false;
        }
    }
}
