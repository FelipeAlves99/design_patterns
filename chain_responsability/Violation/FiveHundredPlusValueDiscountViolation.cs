namespace chain_responsability.Violation
{
    public class FiveHundredPlusValueDiscountViolation
    {
        public double Discount(Budget budget)
        {
            if (budget.Value > 500)
            {
                return budget.Value * 0.07;
            }
            return 0;
        }
    }
}