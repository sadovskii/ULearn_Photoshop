using System;
using System.Security.Cryptography.X509Certificates;

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
        private double alpha;

        public double Alpha
        {
            get { return alpha; }
            set { alpha = Check(value); }
        }

        private double red;
        public double Red
        {
            get { return red; }
            set { red = Check(value); }
        }

        private double green;
        public double Green
        {
            get { return green; }
            set { green = Check(value); }
        }

        private double blue;
        public double Blue
        {
            get { return blue; }
            set { blue = Check(value); }
        }

        public Pixel(double red, double green, double blue, double alpha)
        {
            this.alpha = this.red = this.green = this.blue = 0;

            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public static Pixel operator* (Pixel pixel, double param)
        {
            pixel.Blue = Trim(pixel.Blue * param);
            pixel.Green = Trim(pixel.Green * param);
            pixel.Red = Trim(pixel.Red * param);


            return pixel;
        }

        public static Pixel operator *(double param, Pixel pixel) =>  pixel * param;

        public static double Trim(double value)
        {
            if (value > 1) return 1;
            if (value < 0) return 0;

            return value;
        }

        public Pixel Grayscale()
        {
            Red = Blue = Green = (red + green + blue) / 3;
            return this;
        }

        private double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }

    }
}