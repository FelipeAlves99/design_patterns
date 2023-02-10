namespace strategy_pattern
{
    public class ICMS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}