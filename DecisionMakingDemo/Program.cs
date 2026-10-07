using System;
// Console.WriteLine("Enter your age :");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("You are eligible to vote.");
// }
// else
// {
//     Console.WriteLine("You are not eligible to vote.");
// }


// Console.Write("Enter a day number (1-3):");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//     case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break;
//     case 3:
//         Console.WriteLine("Wednesday");
//         break;
//     default:
//         Console.WriteLine("Invalid day number.");
//         break;
// }


// Console.Write("Enter a day number (1-3):");
// int day = Convert.ToInt32(Console.ReadLine());
// string dayName = day switch
// {
//     1 => "Monday",
//     2 => "Tuesday",
//     3 => "Wednesday",
//     _ => "Invalid day number."
// };
// Console.WriteLine($"The day is: {dayName}");

Console.Write("Enter your age number: ");
int Age = Convert.ToInt32(Console.ReadLine());
string ticketType = Age switch
{
    < 13 => "Child",
    < 50 => "Adult",
    _ => "Senior"
};
Console.WriteLine($"Your ticket type is: {ticketType}");
