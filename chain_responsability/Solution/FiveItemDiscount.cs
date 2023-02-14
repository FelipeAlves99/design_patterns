namespace chain_responsability.Solution
{
    public class FiveItemDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Discount(Budget budget)
        {
            if (budget.Items.Count > 5)
                return budget.Value * 0.1;

            return NextDiscount.Discount(budget);
        }
    }
}