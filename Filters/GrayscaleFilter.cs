using System;
using MyPhotoshop.Data;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop.Filters
{
    public class GrayscaleFilter : PixelFilter
    {
        public GrayscaleFilter() : base(new EmptyParameters()) { }


        public override string ToString() => "Серый";

        public override Pixel ChangeRule(Pixel pixel, IParameters parameters)
        {
            return pixel.Grayscale();
        }
    }
}
