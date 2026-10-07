Expense lunchExpense = new Expense("Lunch",250);
lunchExpense.PrintDetails();

RecurringExpense netflixSubscrption = 
        new RecurringExpense("Netflix",
                499,
                "Monthly");
netflixSubscrption.PrintDetails() ;               

Expense expense = 
            new RecurringExpense("Netflix",
                499,
                "Monthly"
                );
expense.PrintDetails();

IPrintable PrintableExpense = 
            new RecurringExpense("Internet Bill",
                999,
                "Monthly");
PrintableExpense.PrintDetails();

