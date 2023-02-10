using strategy_pattern;

ITaxType iss = new ISS();
ITaxType icms = new ICMS();

Budget budget = new Budget(500.0);

var calculator = new TaxCalculator();

calculator.Calculate(budget, iss);
calculator.Calculate(budget, icms);

Console.ReadKey();