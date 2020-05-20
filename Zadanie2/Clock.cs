using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Zadanie2
{
    public enum Type
    {
        Analog,
        Digital
    }

    public partial class Clock : UserControl
    {
        Type type;

        Color handSecondsColor;
        Color handMinutesColor;
        Color handHoursColor;
        Color clockFaceColor;
        Color fontColor;

        SolidBrush fontBrush;

        Pen penSeconds;
        Pen penMinutes;
        Pen penHours;
        Pen penFace;

        int radiusFace;
        int radiusSeconds;
        int radiusMinutes;
        int radiusHours;
        int centerX;
        int centerY;

        Point secondsEndPoint;
        Point minutesEndPoint;
        Point hoursEndPoint;
        Point center;

        Timer timer;
        public Clock()
        {
            InitializeComponent();

            radiusFace = 50;
            type = Type.Analog;

            handSecondsColor = Color.Red;
            handMinutesColor = Color.Black;
            handHoursColor = Color.Green;
            clockFaceColor = Color.Gold;
            fontColor = Color.Black;
            fontBrush = new SolidBrush(fontColor);

            penSeconds = new Pen(handSecondsColor);
            penMinutes = new Pen(handMinutesColor);
            penHours = new Pen(handHoursColor);
            penFace = new Pen(clockFaceColor);

            penSeconds.Width = 3;
            penMinutes.Width = 4;
            penHours.Width = 4;

            secondsEndPoint = calculateSecondsEndPoint(DateTime.Now.Second, radiusSeconds, center);
            minutesEndPoint = calculateSecondsEndPoint(DateTime.Now.Minute, radiusMinutes, center);
            hoursEndPoint = calculateHoursEndPoint(DateTime.Now.Hour, DateTime.Now.Minute, radiusHours, center);

            UpdateSize();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (type.Equals(Type.Analog))
            {
                secondsEndPoint = calculateSecondsEndPoint(DateTime.Now.Second, radiusSeconds, center);
                minutesEndPoint = calculateSecondsEndPoint(DateTime.Now.Minute, radiusMinutes, center);
                hoursEndPoint = calculateHoursEndPoint(DateTime.Now.Hour, DateTime.Now.Minute, radiusHours, center);
            }
            
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (type.Equals(Type.Analog))
            {
                UpdateSize();
                penFace.Color = clockFaceColor;
                penHours.Color = handHoursColor;
                penMinutes.Color = handMinutesColor;
                penSeconds.Color = handSecondsColor;

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(penFace, new Rectangle(0, 0, radiusFace, radiusFace));
                e.Graphics.DrawLine(penSeconds, center, secondsEndPoint);
                e.Graphics.DrawLine(penMinutes, center, minutesEndPoint);
                e.Graphics.DrawLine(penHours, center, hoursEndPoint);
            }
            else
            {
                UpdateSize();
                fontBrush.Color = fontColor;
                penFace.Color = clockFaceColor;
                var box = new Rectangle(0, 0, radiusFace * 2, radiusFace);
                var centerPoint = new PointF(centerX / 8, (float)(centerY / 1.5));
                e.Graphics.DrawRectangle(penFace, box);
                e.Graphics.DrawString(DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second,
                    new Font("Arial", box.Width/8), fontBrush, centerPoint);
            }
            
            Update();
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (type.Equals(Type.Analog))
            {
                radiusFace = Size.Width - 1;
                UpdateSize();
                radiusSeconds = (int)(radiusFace / 2.2);
                radiusMinutes = (int)(radiusFace / 2.3);
                radiusHours = (int)(radiusFace / 3);
                centerX = Size.Width / 2;
                centerY = Size.Height / 2;
                center = new Point(centerX, centerY);
            }
            else
            {
                radiusFace = Size.Height - 1;
                centerX = Size.Width / 2;
                centerY = Size.Height / 2;
                UpdateSize();
            }

            Invalidate();
            base.OnResize(e);
        }

        private void UpdateSize()
        {
            if (type.Equals(Type.Analog))
            {
                Size = new Size(radiusFace + 1, radiusFace + 1);
            }
            else
            {
                Size = new Size(radiusFace * 2 + 1, radiusFace + 1);
            }
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private Point calculateSecondsEndPoint(int seconds, float radius, Point center)
        {
            seconds *= 6;
            int x;
            int y;
            if (seconds >= 0 && seconds <= 180)
            {
                x = (int)(center.X + radius * Math.Sin(Math.PI * seconds / 180));
                y = (int)(center.Y - radius * Math.Cos(Math.PI * seconds / 180));
            }
            else
            {
                x = (int)(center.X - radius * -Math.Sin(Math.PI * seconds / 180));
                y = (int)(center.Y - radius *  Math.Cos(Math.PI * seconds / 180));
            }
            return new Point(x, y);
        }

        private Point calculateHoursEndPoint(int hours, int minutes, float radius, Point center)
        {
            hours = (int)((hours * 30) + (minutes * 0 / 5));
            int x;
            int y;
            if (hours >= 0 && hours <= 180)
            {
                x = (int)(center.X + radius * Math.Sin(Math.PI * hours / 180));
                y = (int)(center.Y - radius * Math.Cos(Math.PI * hours / 180));
            }
            else
            {
                x = (int)(center.X - radius * -Math.Sin(Math.PI * hours / 180));
                y = (int)(center.Y - radius * Math.Cos(Math.PI * hours / 180));
            }
            return new Point(x, y);
        }

        [Category ("Clock Property")]
        public Type ClockType
        {
            get { return type; }
            set
            {
                type = value;
                Invalidate();
            }
        }

        [Category ("Digital Clock")]
        public Color FontColor
        {
            get{ return fontColor; }
            set
            {
                fontColor = value;
                Invalidate();
            }
        }

        [Category ("Digital Clock")]
        public Color FaceColor
        {
            get { return clockFaceColor; }
            set
            {
                clockFaceColor = value;
                Invalidate();
            }
        }

        [Category ("Analog Clock")]
        public Color SecondHandColor
        {
            get { return handSecondsColor; }
            set
            {
                handSecondsColor = value;
                Invalidate();
            }
        }

        [Category("Analog Clock")]
        public Color MinuteHandColor
        {
            get { return handMinutesColor; }
            set
            {
                handMinutesColor = value;
                Invalidate();
            }
        }

        [Category("Analog Clock")]
        public Color HourHandColor
        {
            get { return handHoursColor; }
            set
            {
                handHoursColor = value;
                Invalidate();
            }
        }

        [Category("Analog Clock")]
        public Color AnalogClockFaceColor
        {
            get { return clockFaceColor; }
            set
            {
                clockFaceColor = value;
                Invalidate();
            }
        }
    }
}
