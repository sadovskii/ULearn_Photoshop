using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters.Parameters
{
    public abstract class ParametrizedFilter : IFilter
    {
        private IParameters _parameters;

        public ParametrizedFilter(IParameters parameters)
        {
            _parameters = parameters;
        }

        public ParameterInfo[] GetParameters()
        {
            return _parameters.GetParameters();
        }

        public Photo Process(Photo original, double[] values)
        {
            _parameters.SetValues(values);
            return Process(original, _parameters);
        }

        public abstract Photo Process(Photo original, IParameters parameters);
    }
}
