namespace chain_responsability.Solution
{
    public class NoDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public double Discount(Budget budget)
        {
            return 0;
        }
    }
}