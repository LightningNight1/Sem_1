void Task_24()
{
    //Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

    Console.WriteLine("Enter a number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    Console.WriteLine("Number\tSum");
    for (int i = 1; i <= N; i++)
        Console.WriteLine("{0}\t{1}\t", i, sum += i);
    if (N < 1)
        Console.WriteLine("Invalid value");
}

//Task_24();



void Task_26()
{
    //Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

    Console.Write("Введите число: ");
    int num1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int counter = 0;

    while (num1 > 0)
    {
        num1 /= 10; //current_num = current_num / 10;
        counter++;
    }
    Console.WriteLine($"Количество цифр {counter}");
}

//Task_26();

//or
void Task_26_1()
{
    Console.WriteLine("Введите число: ");
    string num1 = Console.ReadLine();
    Console.WriteLine($"Количество цифр {num1.Length}");
}

//Task_26_1();

//or
void Task_26_2()
{
    Console.WriteLine("Введите число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{num1} -> {Math.Ceiling(Math.Log10(num1))}");
}

//Task_26_2();



void Task_28()
{
    //Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    Console.WriteLine("Enter a number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;
    Console.WriteLine("Number\tProduct");
    for (int i = 1; i <= N; i++)
        Console.WriteLine("{0}\t{1}\t", i, factorial *= i);
    if (N < 1)
        Console.WriteLine("Invalid value");
}

//Task_28();



void Task_28_1()
{
    //Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    Console.Write("Enter a number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;
    for (int i = 1; i <= N; i++)
        factorial *= i;
    Console.WriteLine($"{N} -> {factorial}");
    if (N < 1)
        Console.WriteLine("Invalid value");
}

//Task_28_1();



void Task_30()
{
    //Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
    // в случайном порядке.

    Random random = new Random();
    int size = 6;
    int[] numbers = new int[size];
    Console.WriteLine(size);
    //FillArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    PrintArray(numbers);
}

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
        num[i] = random.Next(0, 2);
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
        Console.Write(num[i] + "\t");
    Console.WriteLine();
}

//Task_30();



