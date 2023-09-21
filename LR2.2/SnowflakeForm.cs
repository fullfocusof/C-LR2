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
            MyPen = new Pen(Color.White, 30);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            if (e.Button == MouseButtons.Left)
            {
                Graph.DrawLine(MyPen, x, y, x + 5, y);
                Graph.DrawLine(MyPen, x, y, x, y + 5);
                Graph.DrawLine(MyPen, x + 3, y + 3, x, y);
                Graph.DrawLine(MyPen, x + 3, y, x, y + 3);
            }
        }
    }
}
