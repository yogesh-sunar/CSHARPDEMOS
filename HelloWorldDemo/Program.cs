// // ++++++++++++++++++++++vdo 8++++++++++++++++++++
// // Console.WriteLine("Hello, aba!");

// string StudentName = "ydkr";
// // Console.WriteLine($"Hello, {StudentName}!");

// string mName = "Manish";
// int drinkOrdered =2;
// bool isPaid =true;
// char size = 'L';

// // Declareing string 
// string CustomerName= "prabin";
// string city = "chitwan";

// CustomerName = CustomerName.ToUpper();
// Console.WriteLine($"Customer Name: {CustomerName}");
// CustomerName = CustomerName.ToLower();
// Console.WriteLine($"Customer Name: {CustomerName}");
// int NameLength = CustomerName.Length;
// Console.WriteLine($"Customer length: {NameLength}");
// bool hasP = CustomerName.Contains("p");
// Console.WriteLine($"Customer has 'p': {hasP}");

// // ++++++++++++++++++++++vdo 9++++++++++++++++++++

// string companyName ="NullToDev";
// bool isApplicationRunning = true;
// int maxUsers = 100;
// double taxRate= 12.5;

// Console.WriteLine($"Company Name: {companyName}");
// Console.WriteLine($"Is Application Running: {isApplicationRunning}");
// Console.WriteLine($"Max Users: {maxUsers}");        
// Console.WriteLine($"Tax Rate: {taxRate}");

Console.Write("Enter Your Name: ");
String name = Console.ReadLine();


Console.Write("Enter Your Age: ");
int age = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter Your Monthly Budget: ");
Double Budget = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("User Summary");
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");
Console.WriteLine($"Your monthly budget is {Budget:C}.");