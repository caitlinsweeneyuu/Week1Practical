﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

int ageInFiveYears = age + 5;

Console.WriteLine($"Hello, {name}. You will be {ageInFiveYears} in 5 years");

if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if ( age < 20 && age >= 13)
{
    Console.WriteLine("You are a teenager.");
}
else if (age > 19 && age < 110){
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("Invalid age entered.");
}
