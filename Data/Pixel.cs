namespace MyPhotoshop.Data
{
    public class Pixel
    {
        public double Red { get; set; }
        public double Green { get; set; }
        public double Blue { get; set; }

        public Pixel(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static Pixel operator* (Pixel pixel, double param)
        {
            pixel.Blue *= param;
            pixel.Green *= param;
            pixel.Red *= param;

            return pixel;
        }
    }
}
