void Task_46()
{
    //Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
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
            numbers[i, j] = random.Next(-10, 11);
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
//Task_46();


void Task_48()
{
    //Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
    // A = m+n. Выведите полученный массив на экран.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    Console.WriteLine();
    int[,] numbers = new int[rows, columns];
    FillArrayIndexSum(numbers);
    PrintArray(numbers);
}

void FillArrayIndexSum(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
}
//Task_48();



void Task_49()
{
    //Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
    // и замените эти элементы на их квадраты.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Массив размера {rows}x{columns}");
    Console.WriteLine();
    FillArrayIndexSum(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] % 2 == 0)
                numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
    PrintArray(numbers);
}
//Task_49();



void Task_51()
{
    //Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
    // (с индексами (0,0);(1; 1) и т.д

    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = rows;
    int[,] numbers = new int[rows, columns];
    int sum = 0;
    Console.WriteLine($"Массив размера {rows}x{columns}");
    Console.WriteLine();
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
                sum += numbers[i, j];
        }
    }
    Console.WriteLine("Сумма элементов, находящихся на главной диагонали = " + sum);
}
//Task_51();



void Extra_Task_2()
{
    //Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
    // Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

    string phrase = "без труда не выловишь и рыбку из пруда";
    char[] alphabet = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'я' };

    // int count = 0;
    // foreach (char letter in phrase)
    // {
    //     bool contain = alphabet.Contains(letter);
    //     if (contain) count++;
    //     Console.WriteLine($"буква {letter} гласная: {alphabet.Contains(letter)}");
    // }
    // Console.WriteLine($"В поговорке {count} гласных букв");

    int CountOfVowelLetters(string phrase, char[] alphabet, int count = 0, int index = 0)
    {
        if (index == phrase.Length) return count;
        bool contain = alphabet.Contains(phrase[index]);
        if (contain) count++;
        index++;
        return CountOfVowelLetters(phrase, alphabet, count, index);
    }
    Console.WriteLine($"В поговорке {CountOfVowelLetters(phrase, alphabet)} гласных букв");
}
//Extra_Task_2();



