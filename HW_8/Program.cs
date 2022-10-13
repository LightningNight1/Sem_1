//Task_54();
void Task_54()
{
    //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
    // элементы каждой строки двумерного массива.

    var random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    SortInDescendingOrder(numbers);
    Console.WriteLine();
    Console.WriteLine("Sorting in descending order:");
    PrintArray(numbers);
}
void SortInDescendingOrder(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = j; k < columns; k++)
            {
                if (numbers[i, k] > numbers[i, j])
                {
                    (numbers[i, k], numbers[i, j]) = (numbers[i, j], numbers[i, k]);
                }
            }
        }
    }
}
void FillArray(int[,] numbers)
{
    var random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-100, 101);
        }
    }
}
void PrintArray(int[,] numbers)
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



//Task_56();
void Task_56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    GetMinSumOfRow(numbers);
}

void GetMinSumOfRow(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int minSumOfRow = 0;
    int minSum = 100 * columns;
    for (int i = 0; i < rows; i++)
    {
        int sumOfRowsElements = 0;
        for (int j = 0; j < columns; j++)
        {
            sumOfRowsElements = sumOfRowsElements + numbers[i, j];
        }
        if (sumOfRowsElements < minSum)
        {
            minSum = sumOfRowsElements;
            minSumOfRow++;
        }
        Console.WriteLine(sumOfRowsElements);
    }
    Console.WriteLine();
    Console.WriteLine($"The row with the smallest sum of elements: {minSumOfRow}");
}



//Task_58();
void Task_58()
{
    //Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

    int n = 4;
    int[,] numbers = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
    {
        numbers[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= numbers.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > numbers.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintArray(numbers);
}


//Task_61();
void Task_61()
{
    //Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

    int[,] arrayA = new int[,]
    {
        {10, 10},
        {10, 10}
    };
    int[,] arrayB = new int[,]
    {
        {10, 10},
        {10, 10}
    };
    int[,] arrayC = new int[2, 2];

    PrintArray(arrayA);
    Console.WriteLine("    x");
    PrintArray(arrayB);
    MatrixMultiplication(arrayA, arrayB, arrayC);
    Console.WriteLine();
    Console.WriteLine("Result of product of two-dimensional arrays");
    PrintArray(arrayC);
}
void MatrixMultiplication(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            int result = 0;

            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                result += arrayA[i, k] * arrayB[k, j];
            }
            arrayC[i, j] = result;
        }
    }
}



