using System;
Console.WriteLine("Podaj liczby oddzielone spacja:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input)) 
{
    Console.WriteLine("Nie podano zadnych danych");
    return;
}