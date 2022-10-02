void Task_31()
{
    //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
    // Найдите сумму отрицательных и положительных элементов массива.

    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    Console.WriteLine(GetSummPositive(numbers));
    Console.WriteLine(GetSummNegative(numbers));

}

int GetSummPositive(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            sum += numbers[i];
    }
    return sum;
}

int GetSummNegative(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
            sum += numbers[i];
    }
    return sum;
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}


void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
//Task_31();



void Task_32()
{
    //Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
    // соответствующие отрицательные, и наоборот.
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    ChangeValue(numbers);
    PrintArray(numbers);
}

void ChangeValue(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }


}
//Task_32();


void Task_33()
{
    //Задача 33: Задайте массив. Напишите программу, которая определяет, 
    // присутствует ли заданное число в массиве.

    Console.Write("Введите число для поиска в массиве: ");
    int check = Convert.ToInt32(Console.ReadLine());
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    CheckArray(numbers, check);
}

void CheckArray(int[] numbers, int check)
{
    bool flag = false;
    for (int i = 0; !flag && i < numbers.Length; i++)
    {
        if (check == numbers[i])
        {
            flag = true;
        }
    }

    //int i = 0;
    // while (!flag && i < numbers.Length)
    // {
    //     if (check == numbers[i])
    //     {
    //         flag = true;

    //     }
    //     i++;
    // }
    if (flag)
        Console.WriteLine($"Число {check} находится в массиве");
    else
        Console.WriteLine($"Число {check} не находится в массиве");
}
//Task_33();


void Task_35()
{
    //Задача 35: Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива,
    // значения которых лежат в отрезке[10, 99].

    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers, -90, 190);
    PrintArray(numbers);
    FindArray(numbers);
}

void FindArray(int[] numbers)
{
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            counter++;
        }
    }
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке[10, 99] = {counter}");
}
//Task_35();


void Task_37()
{
    //Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
    // элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex - i]}");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine("Средний элемент массива" + numbers[size / 2]);

    }
    Console.WriteLine();
}
//Task_37();


void Extra_Task_2()
{
    //Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
    // Размер массива должен совпадать с квадратом количества единиц в нём.

    Random random = new Random();
    int countOnes = random.Next(1, 11);
    Console.WriteLine("Количество единиц " + countOnes);
    int size = countOnes * countOnes;
    int[] numbers = new int[size];

    for (int i = 0; i < countOnes; i++)
    {
        int randomIndex = random.Next(0, size);
        while (numbers[randomIndex] == 1)
        {
            Console.WriteLine($"Элемент {randomIndex + 1} уже равен 1, ищем следующий");
            randomIndex = random.Next(0, size);
        }
        numbers[randomIndex] = 1;
        Console.WriteLine($"Элемент {randomIndex + 1} стал 1");
    }
    PrintArray(numbers);
}
Extra_Task_2();





