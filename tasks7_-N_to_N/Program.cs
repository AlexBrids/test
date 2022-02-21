//Показать числа от -N до N

Console.Clear();


int numberA = new Random().Next(-9, 0);
int numberB = new Random().Next(0, 9);
Console.WriteLine($"Число А: {numberA}");
Console.WriteLine($"Число B: {numberB}");

while (numberA <= numberB)
{
    Console.WriteLine(numberA);
    numberA++;
}