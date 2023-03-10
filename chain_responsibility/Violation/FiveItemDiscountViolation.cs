using chain_responsibility;

namespace chain_responsibility.Violation
{
    public class FiveItemDiscountViolation
    {
        public double Discount(Budget budget)
        {
            if (budget.Items.Count > 5)
            {
                return budget.Value * 0.1;
            }

            return 0;
        }
    }
}