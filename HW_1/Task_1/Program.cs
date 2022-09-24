// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter two numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Number {number1} is greater than {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Number {number2} is greater than {number1}");
}
else
{
    Console.WriteLine("The numbers are equal");
}