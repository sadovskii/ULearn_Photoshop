namespace MyPhotoshop.Filters.Parameters
{
    public abstract class ParametrizedFilter<T> : IFilter  
        where T: IParameters, new()
    {
        public ParameterInfo[] GetParameters()
        {
            return new T().GetParameters();
        }

        public Photo Process(Photo original, double[] values)
        {
            var _parameters = new T();
            _parameters.SetValues(values);
            return Process(original, _parameters);
        }

        public abstract Photo Process(Photo original, T parameters);
    }
}
