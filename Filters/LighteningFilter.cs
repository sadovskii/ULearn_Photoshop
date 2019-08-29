using MyPhotoshop.Data;
using MyPhotoshop.Filters;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter<LighteningParameters>
    {
        public override string ToString () => "Осветление/затемнение";
		
        public override Pixel ChangeRule(Pixel pixel, LighteningParameters parameters) => pixel * parameters.Coefficient;
    }
}

