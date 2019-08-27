using System;
using System.Security.Cryptography.X509Certificates;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
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

        private readonly Func<int, int> aaa = x => x * x;

        public Pixel(double red, double green, double blue)
        {
            this.red = this.green = this.blue = 0;

            Red = red;
            Green = green;
            Blue = blue;
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

        private double Check(double value)
        {
            Func<int, int> aaa = x => x * x;

            var b = aaa(2);


            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }
    }
}