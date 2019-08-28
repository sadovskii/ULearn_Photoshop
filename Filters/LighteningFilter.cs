using MyPhotoshop.Data;
using MyPhotoshop.Filters;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop
{
	public class LighteningFilter : PixelFilter
	{
        public LighteningFilter() : base(new LighteningParameters()) { }

        public override string ToString () => "Осветление/затемнение";
		
        public override Pixel ChangeRule(Pixel pixel, IParameters parameters) => pixel * (parameters as LighteningParameters).Coefficient;
    }
}

