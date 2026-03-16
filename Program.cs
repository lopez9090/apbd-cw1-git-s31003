using System;
Console.WriteLine("Podaj jakiekolwiek liczby oddzielone spacja:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input)) 
{
    Console.WriteLine("Nie podano zadnych danych");
    return;
}