# Chain of responsibility pattern

The Chain of responsibility pattern is a design pattern that lets you pass requests along a dynamic chain of handlers. Any handler in the chain can take care of a request, there's no guaranteed order in which the requests are processed

## Violation example

**Violation example:**

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


This example violates the chain of responsibility pattern because it chains the responsibilities with multiple `if` statements to apply each business logic, resulting in complex and hard to maintain code. It's exact same problem described for the strategy pattern.


## Solution example

To solve the issue mentioned, we implemented a shared interface to normalize all discount implementations and added a chain builder. In this example, we use the`DiscountCalculator` to make our chain, since the chain itself doesn't configure their next step.

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


The common interface for all the discounts makes the calculation logic interchangeable and easily modifiable without affecting the code that utilizes it. This improves code maintainability and flexibility, as new discount calculation logic can be created and added to the chain builder.

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