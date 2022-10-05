void Task_39()
{
    //Задача 39: Напишите программу, которая перевернёт одномерный массив 
    // (последний элемент будет на первом месте, а первый - на последнем и т.д.)

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers);
    PrintArray(numbers);
}

void ReverseArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        //or
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 9)
{
    int size = numbers.Length;
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}
//Task_39();



void Task_40()
{
    //Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
    // может ли существовать треугольник со сторонами такой длины.

    Console.WriteLine("Enter three numbers: ");
    int sideA = Convert.ToInt32(Console.ReadLine());
    int sideB = Convert.ToInt32(Console.ReadLine());
    int sideC = Convert.ToInt32(Console.ReadLine());

    if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
        Console.WriteLine("The triangle exists");
    else
        Console.WriteLine("The triangle doesn't exist");
}
//Task_40();



void Task_42()
{
    //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = "";

    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    Console.WriteLine(result);
}
//Task_42();
//or
void Task_42_1()
{
    //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = Convert.ToString(num, 2);
    Console.WriteLine(result);
}
//Task_42_1();
//or
void Task_42_2()
{
    //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num10 = num;
    double numAs2 = 0;
    double i = 0;
    while (num10 > 0)
    {
        numAs2 = (num10 % 2) * Math.Pow(10, i) + numAs2;
        num10 /= 2;
        i += 1;
    }
    Console.WriteLine(numAs2);
}
//Task_42_2();



void Task_44()
{
    //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
    // Первые два числа Фибоначчи: 0 и 1.

    Console.WriteLine("Enter a number: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int num1 = 0;
    int num2 = 1;
    double[] numbers = new double[size];

    numbers[0] = num1;
    numbers[1] = num2;

    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray(numbers);

    void PrintArray(double[] numbers)
    {
        int size = numbers.Length;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
        Console.WriteLine();
    }
}
//Task_44();



void Task_45()
{
    //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью 
    // поэлементного копирования.

    int size = 10;
    int[] numbers = new int[size];
    int[] numbers1 = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
        numbers1[i] = numbers[i];
    Console.WriteLine();
    PrintArray(numbers);
}
//Task_45();


void Reverse(int num = 0)
{
    if (num == 0) return;
    Console.WriteLine(num % 10);
    num /= 10;
    Reverse(num);
}
//Reverse(123456); // 6 5 4 3 2 1 (654321)

void Sum(int num = 0, int sum = 0)
{
    if (num == 0)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += num % 10;
    num /= 10;
    Sum(num, sum);
}
Sum(123); // 1+2+3=6

