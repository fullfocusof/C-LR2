using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LR2._3
{
    public partial class EllipseForm : Form
    {
        Graphics Graph;
        Pen MyPen;
        SolidBrush MyBrush;
        Random Rand;
        Color fillColor;
        Color borderColor;
        int startX, startY;

        public EllipseForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            Rand = new Random();
        }

        private void EllipseForm_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
        }

        private void EllipseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int a = Rand.Next(256);
                int b = Rand.Next(256);
                int c = Rand.Next(256);
                int borderWidth = Rand.Next(1,10);
                MyPen = new Pen(Color.FromArgb(a, b, c), borderWidth);

                int u = Rand.Next(256);
                int o = Rand.Next(256);
                int v = Rand.Next(256);

                MyBrush = new SolidBrush(Color.FromArgb(u, o, v));

                //fillColor = Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));

                int x = Math.Min(startX, e.X);
                int y = Math.Min(startY, e.Y);
                int width = Math.Abs(startX - e.X);
                int height = Math.Abs(startY - e.Y);

                Rectangle rec = new Rectangle(x, y, width, height);

                Graph.DrawEllipse(MyPen, rec);
                Graph.FillEllipse(MyBrush, rec);

            }
        }
    }
}
