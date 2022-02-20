Console.Clear();
// По двум заданным числам проверять является ли первое квадратом второго
int numberA = 2 * new Random().Next(1, 3); 
int numberB = 2;

if (numberA / numberB == numberB)
{
    Console.WriteLine("Число А является квадратом числа Б");
    Console.WriteLine($"Число А: {numberA}");
}
else
{
    Console.WriteLine("Число А не является квадратом числа Б");
    Console.WriteLine($"Число А: {numberA}");
}