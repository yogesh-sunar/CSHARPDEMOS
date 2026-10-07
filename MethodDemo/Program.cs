void DisplayaWelcomeMessage()
{
    Console.WriteLine("Welcome Aba!");
    
}
DisplayaWelcomeMessage();

//Method with parameters
void DisplayName(string name)
{
    Console.WriteLine($"Hello {name}!");
}

DisplayName("Aba");

//Method with return value
double CalculateTax(double amount)
{
    return amount * 0.15;
}

double tax = CalculateTax(100);
Console.WriteLine($"The tax is: {tax}");

// pass by value
void IncrementValue(int number)
{
    number +=1;
    Console.WriteLine($"Inside IncrementValue: {number}");

}
int score =5;
IncrementValue(score);
Console.WriteLine($"Outside IncrementValue: {score}");


// pass by reference
void IncrementValueRef(ref int number)
{
    number +=1;
    Console.WriteLine($"Inside IncrementValueRef: {number}");
}       
int scoreRef =5;
IncrementValueRef(ref scoreRef);
Console.WriteLine($"Outside IncrementValueRef: {scoreRef}");

//optional parameter and name arguments
void DisplayProduct(string productName, string cateory = "alpha" )
{
    Console.WriteLine($"Product: {productName}, Category: {cateory}");

}
DisplayProduct("Laptop");
DisplayProduct("Phone", "Electronics");
DisplayProduct(cateory: "Gadgets",
                 productName: "Tablet");