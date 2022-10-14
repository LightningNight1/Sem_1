//Task_63();
void Task_63()
{
    //Задача 63: Задайте значение N. Напишите программу, которая выведет 
    // все натуральные числа в промежутке от 1 до N.

    Console.Write("Enter the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    FindNaturalNumbers(number);

    void FindNaturalNumbers(int number, int counter = 0)
    {
        counter++;
        Console.WriteLine(counter);
        if (counter >= number)
            return;
        FindNaturalNumbers(number, counter);
    }
}


//Task_65();
void Task_65()
{
    //Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
    // все натуральные числа в промежутке от M до N.

    Console.Write("Enter the number M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number N: ");
    int number = Convert.ToInt32(Console.ReadLine());
    FindNaturalNumbers(number, m);

    void FindNaturalNumbers(int number, int counter = 1)
    {
        Console.WriteLine(counter);
        counter++;
        if (counter > number)
            return;
        FindNaturalNumbers(number, counter);
    }
}


//Task_67();
void Task_67()
{
    //Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

    Console.Write("Enter the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Sum of the digits of the given number is {SumOfDigits(number)}");

    int SumOfDigits(int number, int sum = 0)
    {
        if (number == 0)
        {
            return sum;
        }
        sum += number % 10;
        number /= 10;
        return SumOfDigits(number, sum);
    }
}


//Task_69();
void Task_69()
{
    //Задача 69: Напишите программу, которая на вход принимает два числа A и B,
    // и возводит число А в целую степень B с помощью рекурсии.

    Console.Write("Enter the number A: ");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number B: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    Pow(numA, numB);

    void Pow(int numA, int numB, int result = 1)
    {
        if (numB == 0)
        {
            Console.WriteLine($"The result of exponentiation is {result}");
            return;
        }
        result *= numA;
        numB--;
        Pow(numA, numB, result);
    }
}