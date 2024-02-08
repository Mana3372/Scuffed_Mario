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
        //public static event EventHandler<int> IntegerUpdated;
        public MarioGameMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResizeRedraw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new testgame();
            m.Show();
            timer1.Start();
            label1.Text = $"Score: {scorept}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            label1.Text = $"Score: {scorept}";
        }
    }
}
