using System;
using System.Collections.Generic;
using System.Media;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class scene : Form
    {
        //SoundPlayer coinSound = new SoundPlayer(@"D:\C#\SnakeGame\coinSound.wav");
        //SoundPlayer selectSound = new SoundPlayer(@"D:\C#\SnakeGame\selectSound.wav");
        bool right = false;
        bool left = false;
        bool up = false;
        bool down = false;
        bool movement = true;
        public int punke = 0;
        public int v;
        public int zähler = 0;
        public scene()
        {
            InitializeComponent();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmrBewegung.Start();
            tmrMünze.Start();
            txtbMove.Focus();
            tmrBewegung.Interval = 20;
            this.ptbSnake.Visible = true;
            btnStart.Visible = false;
            ptbArrow.Visible = false;
            ptbTitle.Visible = false;
            pbCoin.Visible = true;
            v = 5;
            
            //selectSound.Load();
            //selectSound.Play();
        }
        private void TmrBewegung_Tick(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)  //Geht durch alle komponenten
            {
                if(x is PictureBox && (string)x.Tag == "TagCoin") //Prüft ob x ein Picturebox ist und den Tag "TagCoin" hat
                {
                    if (ptbSnake.Bounds.IntersectsWith(x.Bounds)) //Wenn der Spieler den Coin trifft...
                    {
                        var rand = new Random();
                        int xPosition = rand.Next(20,450);
                        int yPosition = rand.Next(50, 450);
                        pbCoin.Location = new Point(xPosition,yPosition);
                        punke++;
                        lblPunkte.Text = "Münzen: " + punke;
                        //coinSound.Load();
                        //coinSound.Play();
                        //Geschwindigkeitserhöhung
                        switch (punke)
                        {
                            case 5:
                                v = 5;
                                break;
                            case 10:
                                v = 6;
                                break;
                            case 15:
                                v = 7;
                                break;
                            case 20:
                                v = 8;
                                break;
                            case 25:
                                v = 9;
                                break;
                            case 30:
                                v = 10;
                                break;
                            case 35:
                                v = 11;
                                break;
                            case 40:
                                v = 12;
                                break;
                            case 50:
                                v = 13;
                                break;
                            case 60:
                                v = 14;
                                break;
                            case 70:
                                v = 16;
                                break;
                            case 80:
                                v = 18;
                                break;
                            case 90:
                                v = 20;
                                break;
                            case 100:
                                v = 25;
                                break;
                        }
                    }
                }
            }
            if (!up && !left && !right && !down && ptbSnake.Left < 425)
            {
                this.ptbSnake.Image = Snake.Images[3];
                this.ptbSnake.Location = new Point(this.ptbSnake.Location.X + v, this.ptbSnake.Location.Y + 0);      
            }
            else if (left && ptbSnake.Left > 16)
            {
                ptbSnake.Size = new Size(60, 30);
                this.ptbSnake.Image = Snake.Images[1];
                this.ptbSnake.Location = new Point(this.ptbSnake.Location.X - v, this.ptbSnake.Location.Y + 0);
            }
            else if (up && ptbSnake.Top > 16)
            {
                ptbSnake.Size = new Size(30,60);
                this.ptbSnake.Image = Snake1.Images[0];
                this.ptbSnake.Location = new Point(this.ptbSnake.Location.X + 0, this.ptbSnake.Location.Y - v);
            }
            else if (down && ptbSnake.Top < 423)
            {
                ptbSnake.Size = new Size(30,60);
                this.ptbSnake.Image = Snake1.Images[1];
                this.ptbSnake.Location = new Point(this.ptbSnake.Location.X + 0, this.ptbSnake.Location.Y + v);
            }
            else if (right && ptbSnake.Left < 425)
            {
                ptbSnake.Size = new Size(60,30);
                this.ptbSnake.Image = Snake.Images[3];
                this.ptbSnake.Location = new Point(this.ptbSnake.Location.X + v, this.ptbSnake.Location.Y + 0);
            }
            else
            {
                tmrBewegung.Stop();
                ptbSnake.Visible = false;
                lblFail.Visible = true;
                failBackground.Size = new Size(600,600);
                failBackground.Visible = true;
                lblPunkte.Visible = false;
                lblFail.Text = "Du hast Verloren!\nDu hast " + punke + " Münzen gesammelt!";
                btnRetry.Visible = true;
                btnEnd.Visible = true;
            }
        }
        private void TxtbMove_KeyDown(object sender, KeyEventArgs e)
        {
            if (movement)
            {
                if (e.KeyCode == Keys.Up)
                {
                    down = false;
                    right = false;
                    left = false;
                    up = true;
                }
                if (e.KeyCode == Keys.Left)
                {
                    left = true;
                    down = false;
                    right = false;
                    up = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    down = true;
                    up = false;
                    right = false;
                    left = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    right = true;
                    down = false;
                    up = false;
                    left = false;
                }
            }
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            //selectSound.Load();
            //selectSound.Play();
            Application.Restart();
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            //selectSound.Load();
            //selectSound.Play();
            Application.Exit();
        }
        private void timerMünze_Tick(object sender, EventArgs e)
        {
            //Animation der Münze

            pbCoin.Image = Coin.Images[zähler];
            zähler++;
            if (zähler > 5) { zähler = 0; }
        }

        private void PtbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}