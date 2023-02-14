namespace chain_responsability.Solution
{
    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            IDiscount d1 = new FiveItemDiscount();
            IDiscount d2 = new FiveHundredPlusValueDiscount();
            IDiscount d3 = new NoDiscount();

            //Setup the chain of responsibility
            d1.NextDiscount = d2;
            d2.NextDiscount = d3;

            //Call the first chain class and the class decides if needs to continue the chain
            return d1.Discount(budget);
        }
    }
}