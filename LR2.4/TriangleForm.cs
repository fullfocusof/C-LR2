using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2._4
{
    public partial class TriangleForm : Form
    {
        Graphics Graph;
        Pen MyPen;
        int cntClicks = 0;
        int xTemp1, yTemp1, xTemp2 , yTemp2;
        public TriangleForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Red, 5);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            cntClicks++;
            switch (cntClicks)
            {
                case 1:
                    {
                        xTemp1 = e.X;
                        yTemp1 = e.Y;
                    }
                break;

                case 2: 
                    {
                        Graph.DrawLine(MyPen, xTemp1, yTemp1, e.X, e.Y);
                        xTemp2 = e.X;
                        yTemp2 = e.Y;
                    }
                break;

                case 3: 
                    {
                        Graph.DrawLine(MyPen, xTemp1, yTemp1, e.X, e.Y);
                        Graph.DrawLine(MyPen, xTemp2, yTemp2, e.X, e.Y);
                        cntClicks = 0;
                    }
                break;
            }
        }
    }
}
