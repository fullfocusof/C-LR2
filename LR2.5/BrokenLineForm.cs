using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2._5
{
    public partial class BrokenLineForm : Form
    {
        Graphics Graph;
        Pen MyPen;
        Random Rand;
        int startX, startY, x,y;
        bool draw = false;

        public BrokenLineForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            Rand = new Random();
            MyPen = new Pen(Color.Red, 3);
        }

        private void BrokenLineForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(draw)
            {
                Graph.DrawLine(MyPen, startX, startY, e.X, e.Y);
            }

            draw = !draw;
            startX = e.X; 
            startY = e.Y;
            x = e.X;
            y = e.Y;
        }

        private void BrokenLineForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(draw)
            {
                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }
    }
}
