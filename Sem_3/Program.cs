﻿void Task_17()
{   //17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
    // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");
    CoordCheck(x, y);
}
void CoordCheck(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Точка лежит в 1-ой четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Точка лежит в 2-ой четверти");
    else if (x < 0 && y < 0)
        Console.WriteLine("Точка лежит в 3-ей четверти");
    else if (x > 0 && y < 0)
        Console.WriteLine("Точка лежит в 4-ой четверти");
    else
        Console.WriteLine("Точка лежит на одной из осей");
}

void Task_18()
{
    //Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
    // возможных координат точек в этой четверти (x и y).
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 1)
        Console.WriteLine("(x > 0 & y > 0)");
    else if (number == 2)
        Console.WriteLine("x < 0 & y > 0");
    else if (number == 3)
        Console.WriteLine("x < 0 & y < 0");
    else if (number == 4)
        Console.WriteLine("x > 0 & y < 0");
    else
        Console.WriteLine("Invalid value");
}

void Task_21()
{
    //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
    // находит расстояние между ними в 2D пространстве.

    Console.WriteLine("Enter the numbers: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());

    double xx = Math.Pow(x2 - x1, 2);
    double yy = Math.Pow(y2 - y1, 2);
    double S = Math.Sqrt(xx + yy);
    Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    Console.WriteLine("Расстояние между двумя точками равно " + (S));
    S = Math.Round(S, 2);
    Console.WriteLine("Расстояние между двумя точками равно " + (S));
}


void Task_22()
{
    //Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
    // квадратов чисел от 1 до N.

    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("number\tsquare number");
    for (int i = 1; i <= number; i++)
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i, 2));
}

void Task_22_1()
{
    //or
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double Sqw;
    while (i <= number)
    {
        Sqw = Math.Pow(i, 2);
        Console.WriteLine($"|{i}|{Sqw}|", i, Math.Pow(i, 2));
        i++;
    }
}



//Task_17();
//Task_18();
//Task_21();
//Task_22();
//Task_22_1();