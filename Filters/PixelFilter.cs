using System;
using MyPhotoshop.Data;
using MyPhotoshop.Filters.Parameters;

namespace MyPhotoshop.Filters
{
    public class PixelFilter<T> : ParametrizedFilter<T> 
        where T: IParameters, new()
    {
        private string _name;
        private Func<Pixel, T, Pixel> _processor;

        public PixelFilter(string name, Func<Pixel, T, Pixel> processor)
        {
            _name = name;
            _processor = processor;
        }

        /// <summary>
        /// Этот метод принимает фотографию, которую надо обрабатывать, и численные значения всех параметров
        /// Длина массива parameters в точности равна длине массива, возвращаемого методом GetParameters
        /// </summary>
        /// <param name="original"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public override Photo Process(Photo original, T parameters)
        {
            var result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                    result[x, y] = _processor(original[x, y], parameters);

            return result;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
