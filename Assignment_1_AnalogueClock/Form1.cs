using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_AnalogueClock
{
    public partial class Form1 : Form
    {
        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;

        //center
        int cx, cy;

        Bitmap bmp;
        Graphics g;

        private void button1_Click(object sender, EventArgs e)
        {
            int txtHoursInput;
            int txtMinutesInput;

            if (validateHoursMinutes())
            {
                txtHoursInput = Convert.ToInt32(txtHours.Text);
                txtMinutesInput = Convert.ToInt32(txtMinutes.Text);
                setHoursMinute(txtHoursInput, txtMinutesInput);
                txtCalculatedAngle.Text = calcAngle(txtHoursInput, txtMinutesInput).ToString();
            }
        }

        public Boolean validateHoursMinutes()
        {
            Boolean ret = true;
            int parsedValue;

            if (txtHours.Text == "")
            {
                MessageBox.Show("Hours must be filled in.");
                ret = false;
            }

            if (txtMinutes.Text == "")
            {
                MessageBox.Show("Minutes must be filled in.");
                ret = false;
            }

            if (!int.TryParse(txtHours.Text, out parsedValue))
            {
                MessageBox.Show("Hours must be a number.");
                ret = false;
            }

            if (!int.TryParse(txtMinutes.Text, out parsedValue))
            {
                MessageBox.Show("Minutes must be a number.");
                ret = false;
            }

            if (txtHours.Text != "" && int.TryParse(txtHours.Text, out parsedValue))
            {
                if (Convert.ToInt32(txtHours.Text) > 12 || Convert.ToInt32(txtHours.Text) <= 0)
                {
                    MessageBox.Show("Hours must be between 1 and 12.");
                    ret = false;
                }
            }

            if (txtMinutes.Text != "" && int.TryParse(txtMinutes.Text, out parsedValue))
            {
                if (Convert.ToInt32(txtMinutes.Text) > 60 || Convert.ToInt32(txtMinutes.Text) < 0)
                {
                    MessageBox.Show("Hours must be between 1 and 12.");
                    ret = false;
                }
            }

            return ret;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backcolor
            this.BackColor = Color.White;

            setHoursMinute(12, 00);
        }

        public void setHoursMinute(int Hours, int Minute)
        {
            //create graphics
            g = Graphics.FromImage(bmp);

            int[] handCoord = new int[2];

            //clear
            g.Clear(Color.White);

            //draw circle
            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

            //draw figure
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //minute hand
            handCoord = msCoord(Minute, minHAND);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //hour hand
            handCoord = hrCoord(Hours % 12, Minute, hrHAND);
            g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //load bmp in picturebox1
            pictureBox1.Image = bmp;

            //dispose
            g.Dispose();
        }

        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        static double calcAngle(double h, double m)
        {
            double hourInDegrees = (h * 30) + (m * 30.0 / 60);
            double minuteInDegrees = m * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }

            return diff;
        }
    }
}
