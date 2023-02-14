namespace chain_responsability.Violation
{
    public class DiscountCalculatorViolation
    {
        public double Calculate(Budget budget)
        {
            double discount = new FiveItemDiscountViolation().Discount(budget);

            if (discount == 0)
            {
                discount = new FiveHundredPlusValueDiscountViolation().Discount(budget);
            }

            //if(discount == 0) do extra logic

            return discount;
        }
    }
}