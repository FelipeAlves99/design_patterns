namespace template_method.Violation
{
    public class ICPP : ITaxType
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value >= 500)
                return budget.Value * 0.07;

            return budget.Value * 0.05;
        }
    }
}