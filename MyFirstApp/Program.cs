// This is a comment to my code

//Programm küsib kasutajalt tema nime ja siis tervitab tema nimepidi

Console.WriteLine("Enter Your Name:");

//string- sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");

//string interpolation
Console.WriteLine($"Hello, {userName}!");