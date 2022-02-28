// показать четные числа от 1 до N

Console.Clear();

int GetNumber()
{
    int randomN = new Random().Next(2, 120);
    return randomN;
}

int N = GetNumber();
Console.WriteLine($"Случаное число равное: {N}");

int number = 0;

while (number < N)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number++;
}