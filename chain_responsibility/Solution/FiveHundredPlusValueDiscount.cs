using chain_responsibility;

namespace chain_responsibility.Solution
{
    public class FiveHundredPlusValueDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Discount(Budget budget)
        {
            if (budget.Value > 500)
                return budget.Value * 0.07;

            return NextDiscount.Discount(budget);
        }
    }
}