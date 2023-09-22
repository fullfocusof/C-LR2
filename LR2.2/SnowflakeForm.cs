using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LR2._2
{
    public partial class SnowflakeForm : Form
    {
        int x, y;
        Graphics Graph;
        Pen MyPen;

        public SnowflakeForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.White, 1);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            int radius = 10; 
            //int startAngle = 0; 
            //int endAngle = 45; 

            if (e.Button == MouseButtons.Left)
            {
                Graph.DrawLine(MyPen, x - (float)0.75 * radius, y - (float)0.75 * radius, x + (float)0.75 * radius, y + (float)0.75 * radius);
                Graph.DrawLine(MyPen, x - radius, y, x + radius, y);
                Graph.DrawLine(MyPen, x, y - radius, x, y + radius);
                Graph.DrawLine(MyPen, x - (float)0.75*radius, y + (float)0.75 * radius, x + (float)0.75 * radius, y - (float)0.75 * radius);

                //for (int i = 0; i < 8; i++)

                //{
                //    Graph.DrawPie(MyPen, x - radius, y - radius, radius * 2, radius * 2, startAngle, endAngle);
                //    startAngle += endAngle;
                //    endAngle += 45;
                //}
            }
        }
    }
}
