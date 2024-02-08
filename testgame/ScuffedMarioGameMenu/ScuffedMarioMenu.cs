using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScuffedMarioGameMenu
{
    public partial class ScuffedMarioMenu : Form
    {
        public ScuffedMarioMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //start the mario game
        private void button1_Click(object sender, EventArgs e)
        {
            var m = new testgame();
            m.Show();
        }

        //exit program
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
