void Task_34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
    // Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 4;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < size; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine("Even numbers in the array: " + count);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-12, 13);
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.WriteLine(" ]");
}
//Task_34();



void Task_36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.

    int size = 4;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);

    int count = 0;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) count++;
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine("The sum of values of odd index positions: " + sum);
}
//Task_36();



void Task_38()
{
    //Задача 38: Задайте массив вещественных чисел.
    // Найдите разницу между максимальным и минимальным элементом массива.

    int size = 4;
    double[] array = new double[size];
    FillArray(array);
    PrintArray(array);

    double maxValue = array[0];
    double minValue = array[0];
    for (int i = 1; i < size; i++)
    {
        if (array[i] > maxValue)
            maxValue = array[i];
        if (array[i] < minValue)
            minValue = array[i];
    }
    Console.WriteLine("The maximum element of the array: " + maxValue);
    Console.WriteLine("The minimum element of the array: " + minValue);
    Console.WriteLine("The difference between these two elements: " + Math.Round(maxValue - minValue, 2));

    void FillArray(double[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
    }

    void PrintArray(double[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
            if (i < array.Length - 1)
                Console.Write(array[i] + "  ");
            else
                Console.Write(array[i]);
        Console.WriteLine(" ]");
    }
}
Task_38();