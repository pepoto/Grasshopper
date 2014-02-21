using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGraphics
{
    public partial class Form1 : Form
    {
        bool beep = false;
        bool up;
        bool down;
        bool left;
        bool right;

        int counter = 0;
        int step = 10;

        Random rn = new Random();

        Rectangle[] targets;
        int targetNumber = 5;

        Bitmap cre;

        Bitmap background;
        Bitmap dragonImage;
        

        Rectangle r = new Rectangle(0,0,30,30);
        // proba



        Timer t;
        //string back = @"../../cr.jpg";
        string mon = @"../../ELM.gif";
        string dragon = @"../../dragon.gif";
        string monkey = @"../../monkey.gif";
        static string media = @"../../elmerlaugh.wav";
        Graphics g;
        Graphics gc;


        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(media);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            targets = new Rectangle[targetNumber];
            for (int i = 0; i < targetNumber; i++)
            {
                targets[i] = new Rectangle(rn.Next(1, this.Width-50), rn.Next(1, this.Height-50), 50, 50);
            }

            background = new Bitmap(this.Width, this.Height);

            t = new Timer();
            t.Interval = 1;
            t.Tick += t_Tick;
            cre = new Bitmap(mon);
            dragonImage = new Bitmap(dragon);
            g = CreateGraphics();

        
            gc = Graphics.FromImage(background);

            //g.DrawImage(cre,r);
            g.DrawImage(dragonImage, r);
            
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (beep) Console.Beep();
            if (up) r.Y -= step;
            if (down) r.Y += step;
            if (left) r.X -= step;
            if (right) r.X += step;

            g.DrawImage(Draw(), new Point(0, 0));


            for (int i = 0; i < targetNumber; i++)
            {
                if (targets[i].IntersectsWith(r) && (!targets[i].IsEmpty))
                {
                    targets[i] = new Rectangle(0, 0, 0, 0);
                    counter++;
                    r.Width += 10;
                    r.Height += 10;
                    sp.Play();
                }
            }

        }

        public Bitmap Draw()
        {
            gc.Clear(Color.YellowGreen);
            gc.DrawImage(cre, r);

            foreach (Rectangle target in targets)
            {
                gc.DrawImage(dragonImage, target);

            }
            

            gc.DrawString(counter.ToString(), new Font("Arial", 12), Brushes.Aqua, new Point(10, 10));
            return background;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B) beep = true;
            if (e.KeyCode == Keys.W) up = true;
            if (e.KeyCode == Keys.S) down = true;
            if (e.KeyCode == Keys.A) left = true;
            if (e.KeyCode == Keys.D) right = true;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B) beep = false;
            if (e.KeyCode == Keys.W) up = false;
            if (e.KeyCode == Keys.S) down = false;
            if (e.KeyCode == Keys.A) left = false;
            if (e.KeyCode == Keys.D) right = false;
        }
    }
}
