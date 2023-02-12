using strategy_pattern;
using strategy_pattern.Solution;
using strategy_pattern.Violation;

Solution();
Violation();

Console.ReadKey();

void Solution()
{
    ITaxType iss = new ISS();
    ITaxType icms = new ICMS();

    Budget budget = new Budget(500.0);

    var calculator = new TaxCalculator();

    calculator.Calculate(budget, iss);
    calculator.Calculate(budget, icms);
}

void Violation()
{
    Budget budget = new Budget(500.0);

    var calculatorViolation1 = new TaxCalculatorVioaltion1();

    calculatorViolation1.CalculateTax(budget, "ICMS");
    calculatorViolation1.CalculateTax(budget, "ISS");

    var calculatorViolation2 = new TaxCalculatorVioaltion2();

    calculatorViolation2.CalculateTax(budget);
}