public class Expense
{
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }

    public Expense(string title, decimal amount, string category)
    {
        Title = title;
        Amount = amount;
        Category = category;
    }
}