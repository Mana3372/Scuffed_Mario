using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace testgame
{
    public partial class testgame : Form
    {
        const int jumpmax = 15;
        int jumpdist = 0;
        int jumpreturn = 15;
        int health = 5;

        //form initilization
        public testgame()
        {
            InitializeComponent();
            //buffering
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            //prevent resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //add items onto the background
            skybox.Controls.Add(floor);
            skybox.Controls.Add(scuffed_mario);
            skybox.Controls.Add(coin1);
            skybox.Controls.Add(coin2);
            skybox.Controls.Add(label1);
            skybox.Controls.Add(label2);
            skybox.Controls.Add(danger1);
            skybox.Controls.Add(danger2);
            skybox.Controls.Add(danger3);
            /*skybox.Controls.Add(block1);
            skybox.Controls.Add(block2);
            skybox.Controls.Add(block3);*/
            //make items transparent around image
            floor.BackColor = Color.Transparent;
            scuffed_mario.BackColor = Color.Transparent;
            coin2.BackColor = Color.Transparent;
            coin1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            danger1.BackColor = Color.Transparent;
            danger2.BackColor = Color.Transparent;
            danger3.BackColor = Color.Transparent;
            this.Focus(); //deprecated

            //apply difficulty settings on load
            if (MarioGameMenu.difficulty == 0)
            {
                danger2.Location = new Point(1000, 1000);
                danger3.Location = new Point(1000, 1000);
            }
            if (MarioGameMenu.difficulty == 0 || MarioGameMenu.difficulty == 1)
            {
                danger3.Location = new Point(1000, 1000);
            }
        }

        //jumping on Spacebar
        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3;
            if (jumpdist < jumpmax)
            {
                scuffed_mario.Top += -10;
                jumpdist++;
            }
            else
            {
                timer1.Dispose();
                jumpdist = 0;
                timer2.Start();
            }
        }

        //falling back onto the ground
        void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 30;
            if (jumpreturn > 0)
            {
                scuffed_mario.Top += 10;
                jumpreturn--;
            }
            else
            {
                timer2.Dispose();
                jumpreturn = 15;
            }
        }

        //traveling forwards on D
        void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 40;
            floor.Left += -15;
            coin2.Left += -15;
            coin1.Left += -15;
            danger1.Left += -15;
            danger2.Left += -15;
            danger3.Left += -15;
            /*block1.Left += -15;
            block2.Left += -15;
            block3.Left += -15;*/
            //move coins and dangers once they reach past X = 0
            if (coin1.Left <= -15)
                Coins(coin1);
            if (coin2.Left <= -15)
                Coins(coin2);
            if (danger1.Left <= -15)
                DangerPos(danger1);
            if (danger2.Left <= -15)
                DangerPos(danger2);
            if (danger3.Left <= -15)
                DangerPos2(danger3);
            if (danger3.Left <= -15)
                DangerPos3(danger3);
            //move floor to simulate walking
            if (floor.Left <= -1)
                floor.Left = -4;
        }

        //constant background control for collisions
        void timer4_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            //collision coin
            if (DoesIntersect(scuffed_mario, coin1) == true)
            {
                Score();
                Coins(coin1);
            }
            if (DoesIntersect(scuffed_mario, coin2) == true)
            {
                Score();
                Coins(coin2);
            }
            //collision dangers
            if (DoesIntersect(scuffed_mario, danger1) == true)
                TakeDamage(danger1);
            if (DoesIntersect(scuffed_mario, danger2) == true)
                TakeDamage(danger2);
            if (DoesIntersect(scuffed_mario, danger3) == true)
                TakeDamage(danger3);
            //collision block
            /*if (DoesIntersect(scuffed_mario, block1) == true)
            {
                BlockCollision(scuffed_mario, block1);
            }
            if (DoesIntersect(scuffed_mario, block2) == true)
            {
                BlockCollision(scuffed_mario, block2);
            }
            if (DoesIntersect(scuffed_mario, block3) == true)
            {
                BlockCollision(scuffed_mario, block3);
            }*/
            //collision accidental trap
            /*if (DoesIntersect(scuffed_mario, block1) == true)
            {
                TrapCollision(scuffed_mario, block1);
            }*/
        }

        //traveling backwards on A
        void timer5_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 40;
            floor.Left += +15;
            coin2.Left += +15;
            coin1.Left += +15;
            /*block1.Left += +15;
            block2.Left += +15;
            block3.Left += +15;*/
            //move coins once they reach past X = 0
            if (coin1.Left <= +15)
                Coins(coin1);
            if (coin2.Left <= +15)
                Coins(coin2);
            //move floor to simulate walking
            if (floor.Left != -1)
                floor.Left = +4;
        }

        //collision control
        public bool DoesIntersect(Control c1, Control c2)
        {
            return (Math.Min(c1.Bounds.Right, c2.Bounds.Right) >= Math.Max(c1.Bounds.Left, c2.Bounds.Left) &&
                    Math.Min(c1.Bounds.Bottom, c2.Bounds.Bottom) >= Math.Max(c1.Bounds.Top, c2.Bounds.Top));
        }

        //score counter update form1
        /*private void OnScoreUpdate(object sender, int score)
        {
            label1.Text = $"Score: {MarioGameMenu.scorept}";
        }*/

        public void Score()
        {
            MarioGameMenu.scorept++;
            label1.Text = $"Score: {MarioGameMenu.scorept}";
            //MarioGameMenu.IntegerUpdated += OnScoreUpdate;
            //( as MarioGameMenu).IntegerUpdated.Invoke(this, MarioGameMenu.scorept);
        }

        //Coins position and in future avoid collision with Blocks
        void Coins(Control coin)
        {
            Random rnd = new Random();
            int rndY = rnd.Next(120, 279);
            coin.Top = rndY;
            int rndX = rnd.Next(450, 600);
            coin.Left = rndX;
        }

        //danger positions
        void DangerPos(Control danger)
        {
            Random rnd = new Random();
            int rndX = rnd.Next(400, 900);
            danger.Left = rndX;
        } //nuclear trash trap

        void DangerPos2(Control danger)
        {
            Random rnd = new Random();
            int rndX = rnd.Next(400, 900);
            danger.Left = rndX;
        } //ufo trap

        void DangerPos3(Control danger)
        {
            Random rnd = new Random();
            int rndX = rnd.Next(400, 2000);
            danger.Left = rndX;
        } //spike trap

        //Collisioncheck for Blocks with player
        /*void BlockCollision(Control chara, Control block)
        {
            if (chara.Bounds.IntersectsWith(block.Bounds) && chara.Bounds.Bottom >= block.Bounds.Bottom)
            {
                chara.Location = new Point(chara.Location.X, block.Bounds.Top - 82);
            }
        }*/

        //collision with dangers
        void TakeDamage(Control danger)
        {
            health--;
            if (health == 4)
            {
                heart5.Visible = false;
                if (danger == danger1)
                    DangerPos(danger);
                if (danger == danger2)
                    DangerPos2(danger);
                if (danger == danger3)
                    DangerPos3(danger);
            }
            else if (health == 3)
            {
                heart4.Visible = false;
                if (danger == danger1)
                    DangerPos(danger);
                if (danger == danger2)
                    DangerPos2(danger);
                if (danger == danger3)
                    DangerPos3(danger);
            }
            else if (health == 2)
            {
                heart3.Visible = false;
                if (danger == danger1)
                    DangerPos(danger);
                if (danger == danger2)
                    DangerPos2(danger);
                if (danger == danger3)
                    DangerPos3(danger);
            }
            else if (health == 1)
            {
                heart2.Visible = false;
                if (danger == danger1)
                    DangerPos(danger);
                if (danger == danger2)
                    DangerPos2(danger);
                if (danger == danger3)
                    DangerPos3(danger);
            }
            else if (health == 0)
            {
                heart1.Visible = false;
                floor.Visible = false;
                scuffed_mario.Visible = false;
                coin2.Visible = false;
                coin1.Visible = false;
                label1.Visible = false;
                danger1.Visible = false;
                danger2.Visible = false;
                danger3.Visible = false;
                skybox.Image = global::testgame.Properties.Resources.rickroll_roll;
                label2.Visible = true;
            }
        }

        //lol
        void TrapCollision(Control chara, Control trap)
        {
            if (chara.Bottom != trap.Top)
            {
                chara.Location = new Point(trap.Location.X, trap.Location.Y);
            }
        }

        //keyinputs
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(timer1.Enabled == false && timer2.Enabled == false)
                if (e.KeyChar == ' ')
                    timer1.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //stop walking forwards
            if (e.KeyCode == Keys.D)
            {
                timer3.Dispose();
            }
            //stop walking backwards
            if (e.KeyCode == Keys.A)
            {
                timer5.Dispose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //walk forwards
            if (e.KeyCode == Keys.D)
            {
                timer3.Start();
                timer4.Start();
            }
            //walk backwards
            if (e.KeyCode == Keys.A)
            {
                timer5.Start();
                timer4.Start();
            }
        }
    }
}
