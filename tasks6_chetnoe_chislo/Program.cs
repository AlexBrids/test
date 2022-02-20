// Console.WriteLine(23 % 2);

Console.WriteLine("Введите число: ");

string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);


if (number % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
{
    Console.WriteLine("Число нечетное!");
}