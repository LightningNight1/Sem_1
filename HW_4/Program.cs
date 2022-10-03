void Task_25()
{
    //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два
    // натуральных числа (A и B) и возводит число A в степень B.

    Console.WriteLine("Enter two natural numbers: ");
    int numA = Convert.ToInt32(Console.ReadLine());
    int numB = Convert.ToInt32(Console.ReadLine());
    int expon = 1;
    if (numA < 1 || numB < 1)
        Console.WriteLine("Invalid value. Enter natural numbers.");
    else
    {
        for (int i = 1; i < numB + 1; i++)
            expon *= numA;
        Console.WriteLine($"The result of exponentiation is {expon}");
    }
}
//Task_25();



void Task_27()
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.Write("Enter a number: ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int sum = 0;
    for (; num > 0; num /= 10)
        sum += num % 10;
    Console.WriteLine($"Sum of the digits of the given number is {sum}");

}
//Task_27();



void Task_29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит
    // отсортированный по модулю массив.

    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    Sorter(array);
    PrintArray(array);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-12, 13);
}

void Sorter(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = i; j < array.Length; j++)
            if (Math.Abs(array[j]) < Math.Abs(array[i]))
            {
                int temporary = array[j];
                array[j] = array[i];
                array[i] = temporary;
            }
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
Task_29();