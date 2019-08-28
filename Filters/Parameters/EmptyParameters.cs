namespace MyPhotoshop.Filters.Parameters
{
    public class EmptyParameters : IParameters
    {
        public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public void SetValues(double[] values)
        {
            
        }
    }
}
