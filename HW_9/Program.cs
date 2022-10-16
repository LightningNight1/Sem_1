//Task_64();
void Task_64()
{
    //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
    // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    Console.Write("Enter the natural number M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the natural number N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    while (numM <= 0 || numN <= 0)
    {
        Console.WriteLine("Invalid value");
        Console.Write("Enter the NATURAL number M: ");
        numM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the NATURAL number N: ");
        numN = Convert.ToInt32(Console.ReadLine());
    }
    FindNaturalNumbersMultipleOf3(numM, numN);
    FindNaturalNumbersMultipleOf3ReverseOrder(numM, numN);
}
int FindNaturalNumbersMultipleOf3(int numM, int numN)
{
    if (numM > numN)
    {
        return numM;
    }
    if (numM % 3 == 0)
    {
        Console.Write($"{numM} ");
        numM += 3;
    }
    else
    {
        numM++;
    }
    return FindNaturalNumbersMultipleOf3(numM, numN);
}
int FindNaturalNumbersMultipleOf3ReverseOrder(int numM, int numN)
{
    if (numM < numN)
    {
        return numM;
    }
    if (numM % 3 == 0)
    {
        Console.Write($"{numM} ");
        numM -= 3;
    }
    else
    {
        numM--;
    }
    return FindNaturalNumbersMultipleOf3ReverseOrder(numM, numN);
}



//Task_66();
void Task_66()
{
    //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
    // элементов в промежутке от M до N.

    Console.Write("Enter the natural number M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the natural number N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    while (numM <= 0 || numN <= 0)
    {
        Console.WriteLine("Invalid value");
        Console.Write("Enter the NATURAL number M: ");
        numM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the NATURAL number N: ");
        numN = Convert.ToInt32(Console.ReadLine());
    }
    if (numM < numN) { Console.WriteLine(Sum(numM, numN)); }
    else { Console.WriteLine(SumInReverseOrder(numM, numN)); }
}
int Sum(int numM, int numN, int sum = 0)
{
    if (numM == numN + 1)
    {
        return sum;
    }
    sum = sum + numM;
    numM++;
    return Sum(numM, numN, sum);
}
int SumInReverseOrder(int numM, int numN, int sum = 0)
{
    if (numM == numN - 1)
    {
        return sum;
    }
    sum = sum + numM;
    numM--;
    return SumInReverseOrder(numM, numN, sum);
}



//Task_68();
void Task_68()
{
    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    // Даны два неотрицательных числа m и n.

    Console.Write("Enter the non-negative integer M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the non-negative integer N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    while (numM < 0 || numN < 0)
    {
        Console.WriteLine("Invalid value");
        Console.Write("Enter the NON-NEGATIVE integer M: ");
        numM = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the NON-NEGATIVE integer N: ");
        numN = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"A(m,n) = {AckermannFunction(numM, numN)}");
}
int AckermannFunction(int numM, int numN)
{
    if (numM > 0 & numN > 0)
        return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
    else if (numM > 0 & numN == 0)
        return AckermannFunction(numM - 1, 1);
    else return numN + 1;
}