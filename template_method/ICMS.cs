namespace template_method
{
    public class ICMS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}