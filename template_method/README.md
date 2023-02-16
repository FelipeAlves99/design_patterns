# Template method pattern

The Template method pattern is a design pattern that defines the skeleton of an algorithm in a base class, but lets subclasses override specific steps of the algorithm without changing its structure. The Template Method pattern is useful for creating code that follows the open-closed principle, allowing new behavior to be added to the algorithm without modifying the base class.

## Violation example

**Violation example:**

    public class ICPP : ITaxType
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value >= 500)
                return budget.Value * 0.07;

            return budget.Value * 0.05;
        }
    }
    
    public class IKCV : ITaxType
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value > 500 && HasItemBiggerThan100(budget))
                return budget.Value * 0.1;

            return budget.Value * 0.06;
        }

        private bool HasItemBiggerThan100(Budget budget)
        {
            foreach (var item in budget.Items)
                if (item.Value > 100)
                    return true;

            return false;
        }
    }


Both classes violates the template method because it doesn't use our base class `TemplateTaxCondition`, but instead, they implement their own logic for calculating the tax based on different conditions.


## Solution example

To solve the issue mentioned, we created a base class that implements out `ITaxType` interface.

    public abstract class TemplateTaxCondition : ITaxType
    {
        public double Calculate(Budget budget)
        {
            if (ShouldUseMaxTaxation(budget))
                return MaxTax(budget);

            return MinimumTax(budget);
        }

        protected abstract double MinimumTax(Budget budget);

        protected abstract double MaxTax(Budget budget);

        protected abstract bool ShouldUseMaxTaxation(Budget budget);
    }

This way the overall algorithm for the tax calculation is defined, but the specific details of how to calculate the minimum tax, maximum tax, and whether to use the maximum tax are left to be implemented by subclasses. This would allow for a more standardized approach to calculating taxes across different tax types, while still allowing for flexibility and variation in the specific calculations based on the tax type.



    public class ICPP : TemplateTaxCondition
    {
        protected override double MaxTax(Budget budget)
        {
            return budget.Value * 0.07;
        }

        protected override double MinimumTax(Budget budget)
        {
            return budget.Value * 0.05;
        }

        protected override bool ShouldUseMaxTaxation(Budget budget)
        {
            return budget.Value >= 500;
        }
    }
    
    public class IKCV : TemplateTaxCondition
    {
        protected override double MaxTax(Budget budget)
        {
            return budget.Value * 0.1;
        }

        protected override double MinimumTax(Budget budget)
        {
            return budget.Value * 0.06;
        }

        protected override bool ShouldUseMaxTaxation(Budget budget)
        {
            return budget.Value > 500 && HasItemBiggerThan100(budget);
        }

        private bool HasItemBiggerThan100(Budget budget)
        {
            foreach (var item in budget.Items)
                if (item.Value > 100)
                    return true;

            return false;
        }
    }

