using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGraphic
{
    public partial class Form2 : Form
    {
        private Point pole;
        private Point center;
        private Pen pen = new Pen(Color.Red, 2);
        private float diameter = 30f;
        //private float step = Form1.;
        private float phi;
        public Form2()
        {
            InitializeComponent();
            pole = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           /* center.X = (int)((step / (Math.PI * 2)) * phi * Math.Cos(phi));
            center.Y = (int)((step / (Math.PI * 2)) * phi * Math.Sin(phi));*/
            Refresh();
            phi++;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
