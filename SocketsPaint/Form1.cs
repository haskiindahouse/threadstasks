using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace SocketsPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool _isDrawing = false;
        Point _startPosition = Point.Empty;
        Bitmap bmp = new Bitmap(500, 500);
        bool isReserving = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPosition = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing)
                return;

            _startPosition = e.Location;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillEllipse(Brushes.Red, new Rectangle(_startPosition.X, _startPosition.Y, 4, 4));
            }

            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, new Point(0, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 5000;
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            Console.WriteLine("client connected!!");
            NetworkStream ns = client.GetStream();
            Thread thread = new Thread(o => ReceiveData((TcpClient)o, ref bmp));
            thread.Start(client);
        }


        static void ReceiveData(TcpClient client, ref Bitmap bmp)
        {
            NetworkStream ns = client.GetStream();
            BinaryFormatter bin = new BinaryFormatter();
            bmp = (Bitmap)bin.Deserialize(ns);
        }
    }
}
