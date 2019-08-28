using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters.Parameters
{
    public interface IParameters
    {
        ParameterInfo[] GetParameters();
        void SetValues(double[] values);
    }
}
