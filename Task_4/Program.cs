Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= N)
{
    Console.WriteLine(i + " ");
    i += 2;
}
if (N <= 1)
{
    Console.WriteLine("Invalid value");
}