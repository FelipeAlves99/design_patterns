namespace chain_responsibility.Solution
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