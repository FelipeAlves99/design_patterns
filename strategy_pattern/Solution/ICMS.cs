namespace strategy_pattern.Solution
{
    public class ICMS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}