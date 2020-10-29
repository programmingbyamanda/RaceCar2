using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceCar2
{
    public partial class RaceCar2 : Form
    {
        public RaceCar2()
        {
            InitializeComponent();
            GameOver.Visible = false;
            pictureBox10.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Enemy1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Enemy2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Enemy3.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            Enemy(gameSpeed);
            gameover();
        }

        Random r = new Random();
        int x, y;

        void Enemy(int speed)
        {
            if (Enemy1.Top >= 500)
            {
                x = r.Next(10,200);
                //y = r.Next(0, 400);
                Enemy1.Location = new Point(x,0);
            }
            else
            {
                Enemy1.Top += speed;
            }


            if (Enemy2.Top >= 500)
            {
                x = r.Next(201, 440);
                //y = r.Next(0, 400);
                Enemy2.Location = new Point(x, 0);
            }
            else
            {
                Enemy2.Top += speed;
            }

            if (Enemy3.Top >= 500)
            {
                x = r.Next(201, 400);
                //y = r.Next(0, 400);
                Enemy3.Location = new Point(x, 0);
            }
            else
            {
                Enemy3.Top += speed;
            }


        }

        void gameover()
        {
            if(pictureBox10.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }

            if (pictureBox10.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }

            if (pictureBox10.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }

        }

        void MoveLine(int speed)
        {
            if(pictureBox1.Top>=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
           //pictureBox2
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            //pictureBox3
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            //pictureBox4
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

            //pictureBox7
            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }

            //pictureBox8

            if (pictureBox8.Top >= 500)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }

            //pictureBox9

            if (pictureBox9.Top >= 500)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += speed;
            }
    }
        int gameSpeed = 0;
        public void RaceCar2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox10.Left > 10)
                {
                    pictureBox10.Left +=-8;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox10.Right <= 460)
                {
                    pictureBox10.Left += 8;
                }
            }
       
            if(e.KeyCode==Keys.Up)
            {
                if(gameSpeed<21)
                {
                    gameSpeed++;
                }
            }
            if(e.KeyCode==Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        
        
        }

      

    }
}
