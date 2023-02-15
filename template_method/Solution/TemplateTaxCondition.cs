namespace template_method.Solution
{
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
}