using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BounceWithTimer
{
    public partial class Form1 : Form
    {
        public Point point = new Point(x: 1, y: 24);
        public bool dx = true;
        Graphics bouncePainter = null;
        Pen spherePainter = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Starter_Click(object sender, EventArgs e)
        {
            BouncingTimer.Enabled = true;
        }

        private void BouncingTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
            bouncePainter = this.CreateGraphics();
            if (point.X == 263)
            {
                dx = false;
            }
            else
                if (point.X == 1)
                {
                    dx = true;
                }
            if (dx)
            {
                point.X = point.X + 1;
                bouncePainter.DrawEllipse(spherePainter, point.X, point.Y, 20, 20);                
            }
            else
                if (!dx)
                {
                    point.X = point.X - 1;
                    bouncePainter.DrawEllipse(spherePainter, point.X, point.Y, 20, 20);
                }
        }
    }
}
