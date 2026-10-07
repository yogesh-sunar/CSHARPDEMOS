List<Expense> expenses = new List<Expense>();
expenses.Add(new Expense("launch",250,"food"));
expenses.Add(new Expense("launch",250,"food"));
expenses.Add(new Expense("launch",250,"food"));

Console.WriteLine("Expense List");
foreach (Expense expense in expenses){
    Console.WriteLine($"Title-{expense.Title}---Amount-{expense.Amount}---Category-{expense.Category}");

}