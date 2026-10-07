
Category foodCategory = new Category("Food");
Expense lunchExpense = new Expense("Lunch", 250, foodCategory);
Console.WriteLine($"Expense Title: {lunchExpense.Title}");
Console.WriteLine($"Expense Amount: {lunchExpense.Amount}");
Console.WriteLine($"Expense Category: {lunchExpense.Category.Name}");


Console.WriteLine("--------------------------------------------------");
Category TravelCategory = new Category("Travel");
Expense TravelExpense = new Expense("Travel", 500, TravelCategory);
Console.WriteLine($"Expense Title: {TravelExpense.Title}");
Console.WriteLine($"Expense Amount: {TravelExpense.Amount}");
Console.WriteLine($"Expense Category: {TravelExpense.Category.Name}");