void Task_47()
{
    //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами,
    // округлёнными до одного знака.

    Console.Write("Enter the number of array rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of array columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
}

void FillArrayDouble(double[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(random.NextDouble() * 50 - 25, 1);
        }
    }
}

void PrintArrayDouble(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Task_47();



void Task_50()
{
    //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.

    Console.Write("Enter the number of array rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of array columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[rows, columns];
    Console.WriteLine();
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    Console.WriteLine();
    Console.Write("Enter the row index: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the column index: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());

    if (rowIndex < numbers.GetLength(0) && columnIndex < numbers.GetLength(1))
        Console.Write($"The element of indexes({rowIndex}x{columnIndex}) = {numbers[rowIndex, columnIndex]}");
    else
        Console.Write("There is no such number in the array");
}
//Task_50();



void Task_52()
{
    //Задача 52: Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.

    Console.Write("Enter the number of array rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of array columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    Console.WriteLine();
    FillArrayInt(numbers);
    PrintArrayInt(numbers);
    Console.WriteLine();

    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
            sum += numbers[j, i];
        Console.Write(Math.Round(sum / numbers.GetLength(0), 2) + "\t");
    }
}

void FillArrayInt(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArrayInt(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Task_52();