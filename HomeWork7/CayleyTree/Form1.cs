using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        
        double th1;
        double th2;
        double per1;
        double per2;
        

        void drawLine(Pen pen, double x0, double x1, double y0, double y1)
        {
            
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void drawCayleyTree(Pen pen, int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;

            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(pen, x0, x1, y0, y1);

            drawCayleyTree(pen, n - 1, x1, y1, length * per1, th + th1);
            drawCayleyTree(pen, n - 1, x1, y1, length * per2, th - th2);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Refresh();

            if (graphics == null) this.graphics = this.splitContainer1.Panel2.CreateGraphics();

            int n = decimal.ToInt32(this.depth.Value);

            this.th1 = decimal.ToInt32(this.ThLeft.Value) * Math.PI / 180;
            this.th2 = decimal.ToInt32(this.ThRight.Value) * Math.PI / 180;

            this.per1 = decimal.ToDouble(this.perLeft.Value);
            this.per2 = decimal.ToDouble(this.perRight.Value);

            double length = decimal.ToDouble(this.Length.Value);

            Pen pen = new Pen(this.Color.BackColor);

           

            drawCayleyTree(pen, n, 290, 450, length, -Math.PI / 2);
        }

    
    }
}
