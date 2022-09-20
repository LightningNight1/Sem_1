//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"The number {number1} is even");
}
else
{
    Console.WriteLine($"The number {number1} is odd");
}