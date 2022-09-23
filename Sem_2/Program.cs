void task_1()
{
    //9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
    // и показывает наибольшую цифру числа.

    Random random = new Random();
    int number = random.Next(10, 100);
    Console.WriteLine(number);
    int tens = number / 10;
    int ones = number % 10;
    Console.WriteLine(tens);
    Console.WriteLine(ones);
    if (tens > ones)
    {
        Console.WriteLine($"Number {tens} is greater than {ones}");
    }
    else if (tens < ones)
    {
        Console.WriteLine($"Number {ones} is greater than {tens}");
    }
    else
    {
        Console.WriteLine("The numbers are equal");
    }
}

void task_2()
{
    //11. Напишите программу, которая выводит случайное трёхзначное число 
    // и удаляет вторую цифру этого числа.

    int number = new Random().Next(100, 1000);
    int a = number / 100;
    int b = number % 10;
    string c = Convert.ToString(a) + Convert.ToString(b);
    Console.WriteLine(number);
    Console.WriteLine(c);
}
//or
void task_2_1()
{
    Random random = new Random();
    int number = random.Next(100, 1000);
    Console.WriteLine(number);
    int hundreds = number / 100;
    int tens = number / 10;
    int ones = number % 10;
    Console.Write(hundreds * 10 + ones);
}

void task_3()
{
    //12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
    // число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

    Console.WriteLine("Enter the first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 % num1 == 0)
    {
        Console.WriteLine("multiple");
    }
    else
    {
        Console.WriteLine($"not a multiple, the remainder is {num2 % num1}");
    }

}

void task_4()
{
    //14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
    // одновременно 7 и 23. (161...)

    Console.WriteLine("Enter the number");
    int num1 = Convert.ToInt32(Console.ReadLine());

    //if (num1 % 7 * 23 == 0)
    //if (num1 % 7 == 0 && num1 % 23 == 0)
    if (num1 % 161 == 0)
        Console.WriteLine("multiple");
    else
        Console.WriteLine("not a multiple");

}

void task_5()
{
    //16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
    // квадратом другого.

    Console.WriteLine("Enter the first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 == num2 * num2 || num2 == num1 * num1) Console.WriteLine("Yes");
    else Console.WriteLine("No");

}
//or
void task_5_1()
{
    int Input()
    {
        if (true) return 1;
        else return 5;
        Console.WriteLine("Enter the number");
        return Convert.ToInt32(Console.ReadLine());
    }
    int num1 = Input();
    int num2 = Input();
    if (num1 == num2 * num2 || num2 == num1 * num1) Console.WriteLine("Yes");
    else Console.WriteLine("No");

}


//task_1();
//task_2();
//task_2_1();
//task_3();
//task_4();
//task_5();
task_5_1();