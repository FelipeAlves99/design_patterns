# Strategy pattern

The Strategy pattern is a design pattern that provides a way to define a set of algorithms and let the client choose which one to use. It separates the implementation of a particular algorithm from the code that uses it. The main idea behind the strategy pattern is to encapsulate an algorithm in a separate class, making it interchangeable with other algorithms.

## Violation example

**Violation example 1:**

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


 The first example violates the strategy pattern because it uses multiple `if` statements to apply each business logic, resulting in complex and hard to maintain code

**Violation example 2:**

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

The second example we solve the issue of using multiple `if` statements, but transfers the logic to multiple methods. This leads to code that is harder to read and less maintainable, and adding more tax types would require adding more methods.


## Solution example

To resolve the issues mentioned, we must implement a shared interface and let the client choose the desired implementation. In this example, the `TaxCalculator` uses the **ISS** and **ICMS** implementations to calculate the tax amount for a budget, without having to know the specific details of the calculation logic.

    ITaxType iss = new ISS();
    ITaxType icms = new ICMS();

    Budget budget = new Budget(500.0);

    var calculator = new TaxCalculator();

    calculator.Calculate(budget, iss);
    calculator.Calculate(budget, icms);


The common interface between **ISS** and **ICMS** makes the calculation logic interchangeable and easily modifiable without affecting the code that utilizes it. This improves code maintainability and flexibility, as new tax calculation logic can be added or changed by simply creating a class that implements the `ITaxType` interface.

    public class ISS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
    public class ICMS : ITaxType
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }

