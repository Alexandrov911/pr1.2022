using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._01._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            pictureBox4.BackColor = Color.White;
            Pen p = new Pen(Color.Red);
            p.Width = 3;
            
            SolidBrush b = new SolidBrush(Color.CadetBlue);
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown3.Value);
            g.FillRectangle(b, x, y, h, h);
            g.DrawRectangle(p, x, y, h, h);

            Point p1 = new Point(x , y);
            Point p2 = new Point(x + h , y + h);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(x, y+h);
            Point p4 = new Point(x +h, y );
            g.DrawLine(p, p3, p4);
            SolidBrush bs2 = new SolidBrush(Color.Green);
            g.FillEllipse(bs2, x + h / 4+h/8, y + h / 2 + h / 6, h /2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            g.FillEllipse(bs2, x + h/4+h/8, y + h / 10, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);


        }
    }
}
