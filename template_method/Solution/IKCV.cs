namespace template_method.Solution
{
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
}