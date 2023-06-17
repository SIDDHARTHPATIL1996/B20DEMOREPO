// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter first no. :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter Second no. :");
int b = int.Parse(Console.ReadLine());


Calculator calculator = new Calculator();
calculator.Add(a,b);
calculator.Sub(a,b);


Console.ReadLine();