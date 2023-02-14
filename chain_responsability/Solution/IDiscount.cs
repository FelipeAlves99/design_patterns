namespace chain_responsability.Solution
{
    public interface IDiscount
    {
        IDiscount NextDiscount { get; set; }

        public double Discount(Budget budget);
    }
}