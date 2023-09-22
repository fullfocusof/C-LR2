using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class DrawLinesForm : Form
    {
        int x, y;
        Graphics Graph;
        Pen MyPen;
        Random Rand;

        public DrawLinesForm()
        {
            InitializeComponent();
            Rand = new Random();
            Graph = CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int a = Rand.Next(256);
            int b = Rand.Next(256);
            int c = Rand.Next(256);
            int width = Rand.Next(10);
            MyPen = new Pen(Color.FromArgb(a, b, c), width);
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            float[] dashValues = { 4, 5 };
            MyPen.DashPattern = dashValues;
            if(e.Button == MouseButtons.Left)
            {
                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
            }
        }
    }
}
