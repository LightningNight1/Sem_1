//Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    Console.WriteLine(i + " ");
    i += 2;
}
if (N <= 1)
{
    Console.WriteLine("Invalid value");
}