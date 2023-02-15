using chain_responsibility;
using chain_responsibility.Solution;
using chain_responsibility.Violation;

Solution();
Violation();

Console.ReadKey();

void Solution()
{
    DiscountCalculator discountCalculator = new DiscountCalculator();

    Budget budgetEx1 = new Budget(500.0);
    budgetEx1.AddItem(new Item("Pen", 250));
    budgetEx1.AddItem(new Item("Pencil", 250));
    budgetEx1.AddItem(new Item("Pan", 250));
    budgetEx1.AddItem(new Item("Mouse", 250));
    budgetEx1.AddItem(new Item("Laptop", 250));
    budgetEx1.AddItem(new Item("Keyboard", 250));

    double discount = discountCalculator.Calculate(budgetEx1);
    Console.WriteLine("Solution Discount Rule 1 Value: " + discount);

    Budget budgetEx2 = new Budget(600.0);
    budgetEx2.AddItem(new Item("Pen", 250));
    budgetEx2.AddItem(new Item("Pencil", 250));

    discount = discountCalculator.Calculate(budgetEx2);
    Console.WriteLine("Solution Discount Rule 2 Value: " + discount);

    Budget budgetEx3 = new Budget(500.0);
    budgetEx3.AddItem(new Item("Pen", 250));
    budgetEx3.AddItem(new Item("Pencil", 250));

    discount = discountCalculator.Calculate(budgetEx3);
    Console.WriteLine("Solution Discount Rule 3 Value: " + discount);
}

void Violation()
{
    var discountCalculator = new DiscountCalculatorViolation();

    Budget budgetEx1 = new Budget(500.0);
    budgetEx1.AddItem(new Item("Pen", 250));
    budgetEx1.AddItem(new Item("Pencil", 250));
    budgetEx1.AddItem(new Item("Pan", 250));
    budgetEx1.AddItem(new Item("Mouse", 250));
    budgetEx1.AddItem(new Item("Laptop", 250));
    budgetEx1.AddItem(new Item("Keyboard", 250));

    double discount = discountCalculator.Calculate(budgetEx1);
    Console.WriteLine("Violation Discount Rule 1 Value: " + discount);

    Budget budgetEx2 = new Budget(600.0);
    budgetEx2.AddItem(new Item("Pen", 250));
    budgetEx2.AddItem(new Item("Pencil", 250));

    discount = discountCalculator.Calculate(budgetEx2);
    Console.WriteLine("Violation Discount Rule 2 Value: " + discount);

    Budget budgetEx3 = new Budget(500.0);
    budgetEx3.AddItem(new Item("Pen", 250));
    budgetEx3.AddItem(new Item("Pencil", 250));

    discount = discountCalculator.Calculate(budgetEx3);
    Console.WriteLine("Violation Discount Rule 3 Value: " + discount);
}