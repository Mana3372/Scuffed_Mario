namespace testgame
{
    partial class testgame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.danger2 = new System.Windows.Forms.PictureBox();
            this.danger1 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.scuffed_mario = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.skybox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scuffed_mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skybox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score: ";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // danger2
            // 
            this.danger2.BackColor = System.Drawing.Color.Transparent;
            this.danger2.Image = global::testgame.Properties.Resources.bootleg_ufo;
            this.danger2.Location = new System.Drawing.Point(758, 192);
            this.danger2.Name = "danger2";
            this.danger2.Size = new System.Drawing.Size(100, 50);
            this.danger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger2.TabIndex = 9;
            this.danger2.TabStop = false;
            // 
            // danger1
            // 
            this.danger1.BackColor = System.Drawing.Color.Transparent;
            this.danger1.Image = global::testgame.Properties.Resources.bootleg_radioactive;
            this.danger1.Location = new System.Drawing.Point(514, 287);
            this.danger1.Name = "danger1";
            this.danger1.Size = new System.Drawing.Size(102, 72);
            this.danger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.danger1.TabIndex = 8;
            this.danger1.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = global::testgame.Properties.Resources.bootleg_coin1;
            this.coin1.Location = new System.Drawing.Point(260, 237);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(39, 37);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 7;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = global::testgame.Properties.Resources.bootleg_coin1;
            this.coin2.Location = new System.Drawing.Point(368, 237);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(38, 37);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 6;
            this.coin2.TabStop = false;
            // 
            // scuffed_mario
            // 
            this.scuffed_mario.BackColor = System.Drawing.Color.Transparent;
            this.scuffed_mario.Image = global::testgame.Properties.Resources.scuffed_mario;
            this.scuffed_mario.Location = new System.Drawing.Point(85, 277);
            this.scuffed_mario.Name = "scuffed_mario";
            this.scuffed_mario.Size = new System.Drawing.Size(58, 82);
            this.scuffed_mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scuffed_mario.TabIndex = 3;
            this.scuffed_mario.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Image = global::testgame.Properties.Resources.grass;
            this.floor.Location = new System.Drawing.Point(0, 356);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(805, 104);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 2;
            this.floor.TabStop = false;
            // 
            // skybox
            // 
            this.skybox.Image = global::testgame.Properties.Resources.bootleg_nightsky;
            this.skybox.Location = new System.Drawing.Point(0, 0);
            this.skybox.Name = "skybox";
            this.skybox.Size = new System.Drawing.Size(805, 452);
            this.skybox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.skybox.TabIndex = 4;
            this.skybox.TabStop = false;
            // 
            // testgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.danger2);
            this.Controls.Add(this.danger1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scuffed_mario);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.skybox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "testgame";
            this.Text = "Scuffed Bootleg Mario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.danger2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scuffed_mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skybox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox scuffed_mario;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox skybox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.PictureBox danger1;
        private System.Windows.Forms.PictureBox danger2;
    }
}

