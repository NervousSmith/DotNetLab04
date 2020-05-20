using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class TrafficLights : UserControl
    {
        Color red;
        Color yellow;
        Color green;

        Pen redPen;
        Pen yellowPen;
        Pen greenPen;

        SolidBrush solidBrushRed;
        SolidBrush solidBrushYellow;
        SolidBrush solidBrushGreen;

        int state;
        int radius;

        public TrafficLights()
        {
            InitializeComponent();

            state = 0;
            radius = 20;

            red = Color.Red;
            yellow = Color.Yellow;
            green = Color.Green;

            redPen = new Pen(red);
            yellowPen = new Pen(yellow);
            greenPen = new Pen(green);

            solidBrushRed = new SolidBrush(red);
            solidBrushYellow = new SolidBrush(yellow);
            solidBrushGreen = new SolidBrush(green);

            UpdateSize();
        }

        private void UpdateSize()
        {
            Size = new Size(radius, radius * 3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(state == 0)
            {
                e.Graphics.FillEllipse(solidBrushRed, new Rectangle(0, 0, radius, radius));
                e.Graphics.FillEllipse(solidBrushYellow, new Rectangle(0, radius, radius, radius));
                e.Graphics.FillEllipse(solidBrushGreen, new Rectangle(0, radius * 2, radius, radius));
            } else if(state == 1)
            {
                e.Graphics.FillEllipse(solidBrushRed, new Rectangle(0, 0, radius, radius));
                e.Graphics.DrawEllipse(yellowPen, new Rectangle(0, radius, radius, radius));
                e.Graphics.DrawEllipse(greenPen, new Rectangle(0, radius * 2, radius, radius));
            } else if(state == 2)
            {
                e.Graphics.FillEllipse(solidBrushRed, new Rectangle(0, 0, radius, radius));
                e.Graphics.FillEllipse(solidBrushYellow, new Rectangle(0, radius, radius, radius));
                e.Graphics.DrawEllipse(greenPen, new Rectangle(0, radius * 2, radius, radius));
            } else if(state == 3)
            {
                e.Graphics.DrawEllipse(redPen, new Rectangle(0, 0, radius, radius));
                e.Graphics.DrawEllipse(yellowPen, new Rectangle(0, radius, radius, radius));
                e.Graphics.FillEllipse(solidBrushGreen, new Rectangle(0, radius * 2, radius, radius));
            }

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            radius = Size.Width;
            UpdateSize();

            Invalidate();
            base.OnResize(e);
        }


        [Category("Traffic Lights Property")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                UpdateSize();
                Invalidate();
            } 
        }
        [Category("Traffic Lights Property")]
        public Color CircleColor1
        {
            get { return red; }
            set
            {
                red = value;
                redPen = new Pen(red);
                solidBrushRed = new SolidBrush(red);
                Invalidate();
            }
        }

        [Category("Traffic Lights Property")]
        public Color CircleColor2
        {
            get { return yellow; }
            set
            {
                yellow = value;
                yellowPen = new Pen(yellow);
                solidBrushYellow = new SolidBrush(yellow);
                Invalidate();
            }
        }

        [Category("Traffic Lights Property")]
        public Color CircleColor3
        {
            get { return green; }
            set
            {
                green = value;
                greenPen = new Pen(green);
                solidBrushGreen = new SolidBrush(green);
                Invalidate();
            }
        }

        [Category("Traffic Lights Property")]
        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Invalidate();
            }
        }

        private void TrafficLights_Load(object sender, EventArgs e)
        {

        }
    }
}
