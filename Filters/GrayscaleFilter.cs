using MyPhotoshop.Data;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop.Filters
{
    public class GrayscaleFilter : PixelFilter<EmptyParameters>
    {
        public override string ToString() => "Серый";

        public override Pixel ChangeRule(Pixel pixel, EmptyParameters parameters)
        {
            return pixel.Grayscale();
        }
    }
}