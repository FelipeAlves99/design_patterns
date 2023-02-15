namespace template_method.Solution
{
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
}