void Task_53()
{
    //Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
    // последнюю строку массива.

    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine();
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    int min_i = 0;
    int max_i = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (numbers[min_i, j], numbers[max_i, j]) = (numbers[max_i, j], numbers[min_i, j]);
    }
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-100, 100);
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
//Task_53();



void Task_55()
{
    //Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
    // В случае, если это невозможно, программа должна вывести сообщение для пользователя.

    var random = new Random();
    int rows = random.Next(4, 5);
    int columns = rows;
    int[,] numbers = new int[rows, columns];
    Console.WriteLine();
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    for (int i = 0; i < rows; i++)
        for (int j = i; j < columns; j++)
        {
            (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]);
            // int temp = numbers[i, j];
            // numbers[i, j] = numbers[j, i];
            // numbers[j, i] = temp;
        }
    PrintArray(numbers);
}
//Task_55();



void Task_57()
{
    //Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
    // информацию о том, сколько раз встречается элемент входных данных.

    var random = new Random();
    int rows = random.Next(4, 5);
    int columns = rows;
    int[,] numbers = new int[rows, columns];
    Console.WriteLine();
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    int[] counts = new int[10];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            counts[numbers[i, j]]++;
        }
    }
    for (int i = 0; i < 10; i++)
        Console.WriteLine($"{i} встречается {counts[i]} раз(а)");
}
//Task_57();



void Task_59()
{
    //Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
    // на пересечении которых расположен наименьший элемент массива.

    var random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int min = numbers[0, 0];
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"N[{i_min + 1}, {j_min + 1}] = {min}");

    int rowsResult = rows - 1;
    int columnsResult = columns - 1;
    int[,] result = new int[rowsResult, columnsResult];
    int bias_i = 0;
    int bias_j = 0;

    // for (int i = 0; i < rowsResult; i++)
    // {
    //     for (int j = 0; j < columnsResult; j++)
    //     {
    //         if (j == j_min) bias_j++;
    //         bias_j = 0;
    //         result[i, j] = numbers[i + bias_i, j + bias_j];
    //     }
    // }
    // Console.WriteLine();
    // PrintArray(result);
    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        if (i != i_min)
        {
            for (int j = 0; j < columns; j++)
            {
                {
                    if (j != j_min)
                        Console.Write(numbers[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
//Task_59();



void Extra_Task_3()
{
    //Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами. 
    // Игрок может ходить только по полям, заполненным единицами. Проверьте, существует ли путь 
    //из точки [0, 0] в точку [4, 4] (эти поля требуется принудительно задать равными единице).

    var random = new Random();
    int rows = 5;
    int columns = 5;
    int[,] map = new int[rows, columns];
    FillArray_0_1(map);
    int i_max = rows - 1;
    int j_max = columns - 1;
    map[0, 0] = 1;
    map[i_max, j_max] = 1;
    PrintArray(map);
    bool exit = false;
    //while(!exit)
    // {
    //     FillArray_0_1(map);
    //     FindPath(map);
    // }
    FindPath(map);

    if (exit) Console.WriteLine("Выход есть");
    else Console.WriteLine("Выхода нет");
    Console.WriteLine();
    PrintArray(map);

    void FindPath(int[,] map, int i = 0, int j = 0)
    {
        if (i < 0 || i > i_max || j < 0 || j > j_max || map[i, j] == 0 || map[i, j] == 2)
        {
            return;
        }
        map[i, j] = 2;
        if (i == i_max && j == j_max)
        {
            exit = true;
            return;
        }

        FindPath(map, i + 1, j);
        FindPath(map, i - 1, j);
        FindPath(map, i, j + 1);
        FindPath(map, i, j - 1);
        FindPath(map, i + 1, j + 1);
        FindPath(map, i - 1, j - 1);
        FindPath(map, i + 1, j - 1);
        FindPath(map, i - 1, j + 1);
    }
}
void FillArray_0_1(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 2);
        }
    }
}
Extra_Task_3();