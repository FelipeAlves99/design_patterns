namespace template_method.Violation
{
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
}