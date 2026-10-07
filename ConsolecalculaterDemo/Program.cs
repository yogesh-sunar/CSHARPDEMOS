Console.WriteLine("Interactive Console Calculater");
Console.WriteLine();
Console.Write("Enter your first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.Write("Enter your Second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
double difference = num1 - num2;            
double product = num1 * num2;
double quotient = num1 / num2;

Console.WriteLine();
Console.WriteLine($"The sum of {num1} and {num2} is: {sum:F5}");
Console.WriteLine($"The difference of {num1} and {num2} is: {difference}");

if (num2 != 0)
{
    Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}");
}
else
{
    Console.WriteLine("Cannot divide by zero.");
}       


// Console.Write("Enter an expense amount: ");
// string? input = Console.ReadLine();

// if (decimal.TryParse(input, out decimal amount))
// {
//     Console.WriteLine($"You entered: {amount:F2}");
// }
// else
// {
//     Console.WriteLine("That wasn't a valid number.");
// }
