namespace template_method
{
    public class ISS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}