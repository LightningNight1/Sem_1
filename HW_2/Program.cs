void task_10()
{
    //Задача 10: Напишите программу, которая принимает на вход трёхзначное число
    // и на выходе показывает вторую цифру этого числа.

    Console.WriteLine("Enter a three-digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens = number / 10;
    if (number > 99 && number < 1000)
        Console.Write(tens % 10);
    else
        Console.Write("Invalid value");
}


void task_13()
{
    //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа
    // или сообщает, что третьей цифры нет.

    Console.Write("Enter the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
        number = -number;
    if (number < 100)
        Console.WriteLine("third digit is missing");
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
}

void task_15()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
    // и проверяет, является ли этот день выходным.


    Console.WriteLine("Enter a number of a week's day (1 - Mon, 2 - Tue, 3 - Wed, 4 - Thu, 5 - Fri, 6 - Sat, 7 - Sun)");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day > 0 && day < 8)
        if (day == 6 || day == 7)
            Console.WriteLine("Day off! :)");
        else
            Console.WriteLine("It's not a day off yet :(");
    else
        Console.WriteLine("Invalid value");
}


task_10();
//task_13();
//task_15();
