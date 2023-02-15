using template_method;
using template_method.Solution;
using ViolationICPP = template_method.Violation.ICPP;
using ViolationIKCV = template_method.Violation.IKCV;

Solution();
Violation();

Console.ReadKey();

void Solution()
{
    var icpp = new ICPP();
    var ikcv = new IKCV();

    Budget budget = new Budget(500.0);

    var ikcvTaxValue = ikcv.Calculate(budget);
    var icppTaxValue = icpp.Calculate(budget);

    Console.WriteLine($"Solution ICPP Tax Value: {icppTaxValue}");
    Console.WriteLine($"Solution IKCV Tax Value: {ikcvTaxValue}");
}

void Violation()
{
    var icpp = new ViolationICPP();
    var ikcv = new ViolationIKCV();

    Budget budget = new Budget(500.0);

    var calculator = new TaxCalculator();

    calculator.Calculate(budget, icpp);
    calculator.Calculate(budget, ikcv);
}