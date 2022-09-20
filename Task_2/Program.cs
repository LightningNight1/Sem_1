//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter three numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"The maximum number is {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"The maximum number is {number2}");
}
else
{
    Console.WriteLine($"The maximum number is {number3}");
}