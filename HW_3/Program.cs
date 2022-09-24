void Task_19()
{
    //Задача 19: Напишите программу, которая принимает на вход пятизначное число 
    // и проверяет, является ли оно палиндромом.

    Console.WriteLine("Enter a five-digit number: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int one = number / 10000 % 10;
    int two = number / 1000 % 10;
    int four = number / 10 % 10;
    int five = number % 10;
    if (number > 9999 && number < 100000)
    {
        if (one == five && two == four)
            Console.WriteLine("it's a palindrome");
        else
            Console.WriteLine("it's not a palindrome");
    }
    else
        Console.WriteLine("Invalid value");
}


void Task_21_1()
{
    //Задача 21: Напишите программу, которая принимает на вход координаты двух точек
    // и находит расстояние между ними в 3D пространстве.

    Console.WriteLine("Enter the coordinates of two points: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The distance between two points is " +
    $"{Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))}");
}


void Task_23()
{
    //Задача 23: Напишите программу, которая принимает на вход число (N) 
    // и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("Enter a number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number\tCube number");
    for (int i = 1; i <= N; i++)
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i, 3));
    if (N < 1)
        Console.WriteLine("Invalid value");
}


Task_19();
//Task_21_1();
//Task_23();