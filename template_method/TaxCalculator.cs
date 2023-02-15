namespace template_method
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, ITaxType taxType)
        {
            double taxValue = taxType.Calculate(budget);
            Console.WriteLine("Violation Tax Value: " + taxValue);
        }
    }
}