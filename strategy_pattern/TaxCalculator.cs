namespace strategy_pattern
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, ITaxType taxType)
        {
            double taxValue = taxType.Calculate(budget);
            Console.WriteLine(taxValue);
        }
    }
}