using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double wx = 0, wy = 0;
        public double speed = 2f, zoom = 2f, zoomSpeed = 0.001d;
        public int res = 5;
        public Bitmap frame;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                res -= 1;
            }
            if (e.KeyCode == Keys.E)
            {
                res += 1;
            }

            if (e.KeyCode == Keys.Add)
            {
                zoom -= zoomSpeed / zoom;
                Draw();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                zoom += zoomSpeed / zoom;
                Draw();
            }
            if (e.KeyCode == Keys.Up)
            {
                wy -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Down)
            {
                wy += speed * (5 - Math.Abs(zoom));
            }

            if (e.KeyCode == Keys.Left)
            {
                wx -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Right)
            {
                wx += speed * (5 - Math.Abs(zoom));
            }


            if (e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                Draw();
            }
            
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
                Draw();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zoom -= zoomSpeed / zoom;
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw();
        }


        public void Draw()
        {
            if (res <= 0)
            {
                res = 1;
            }

            var taskList = new List<Task>();
            frame = new Bitmap(Width / res, Height / res);
            for (int x = 0; x < Width/res; x++)
            {
                for (int y = 0; y < Height/res; y++)
                {
                    double a = (double)((x + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
                    double b = (double)((y + (wy / res / zoom)) - ((Height / 2d) / res)) / (double)(Height / zoom / res);

                    Numbers c = new Numbers(a, b);
                    Numbers z = new Numbers(0, 0);


                    int it = 0;
                    taskList.Add(Task.Run(() => {
                        do
                        {
                            it++;
                            z.Sqr();
                            z.Add(c);
                            if (z.Magn() > 2.0d)
                            {
                                break;
                            }
                        } while (it < 100);


                        frame.SetPixel(x, y, Color.FromArgb((byte)(it * 2.55f), (byte)(it * 2.55f), (byte)(it * 2.55f)));
                    }));
                }
            }

            Task.WaitAll(taskList.ToArray());
            pictureBox1.Image = frame;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }



    public class Numbers {
        public double a;
        public double b;

        public Numbers(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Sqr()
        {
            double tmp = (a * a) - (b * b);
            b = 2.0d * a * b;
            a = tmp;
        }

        public double Magn()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Numbers c)
        {
            a += c.a;
            b += c.b;
        }
        
    }

}
