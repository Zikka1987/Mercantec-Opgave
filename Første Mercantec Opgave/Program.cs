// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, everybody");

Console.WriteLine("Please enter your first name:");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Hello " + firstName + " " + lastName);

Console.WriteLine("what year were you born?");
string age = Console.ReadLine();

Console.WriteLine("I see, so you are " + age + " years old. That is pretty old man!");

Console.WriteLine("Now tell me, what country are you from?");
string country = Console.ReadLine();

Console.WriteLine("All right, and what city did you grow up in?");
string city = Console.ReadLine();

Console.WriteLine($"So you are from {city}, {country}. That sounds a bit boring to be honest");
