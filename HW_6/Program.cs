void Task_41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. 
    // Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3

    Console.Write("Enter array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;
    int i = 0;

    while (i < size)
    {
        Console.Write($"Enter the {i + 1} number of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) sum = sum + 1;
        i++;
    }
    Console.WriteLine($"Entered {sum} numbers greater than 0");
}
Task_41();

void Task_43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    Console.Write($"Enter coordinate k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter coordinate b1:: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter coordinate k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter coordinate b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Coincident Lines");
    else if (k1 == k2)
        Console.WriteLine("Parallel lines");
    else
        Console.WriteLine($"The coordinates of the point of intersection of the lines: ({x}; {y})");
}
//Task_43();