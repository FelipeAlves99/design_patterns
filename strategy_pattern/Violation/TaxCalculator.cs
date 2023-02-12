namespace strategy_pattern.Violation
{
    //Violation 1: use multiple if's to apply each business logic
    public class TaxCalculatorVioaltion1
    {
        public void CalculateTax(Budget budget, string taxType)
        {
            if ("ICMS".Equals(taxType))
            {
                double icms = budget.Value * 0.1;
                Console.WriteLine("Violation 1:" + icms);
            }
            else if ("ISS".Equals(taxType))
            {
                double iss = budget.Value * 0.06; ;
                Console.WriteLine("Violation 1:" + iss);
            }
            //If needed to add more taxes types, more if's are needed
            //This way the code will be harder to read and less maintainable
        }
    }

    //Violation 2: removed if usage, but we just transfered to methods
    public class TaxCalculatorVioaltion2
    {
        public void CalculateTax(Budget budget)
        {
            CalculateISS(budget);
            CalculateICMS(budget);
        }

        private void CalculateICMS(Budget budget)
        {
            double icms = budget.Value * 0.1;
            Console.WriteLine("Violation 2: " + icms);
        }

        private void CalculateISS(Budget budget)
        {
            double iss = budget.Value * 0.06; ;
            Console.WriteLine("Violation 2: " + iss);
        }

        //If needed to add more taxes types, more methods are needed
        //This way the code will be harder to read and less maintainable
    }
}