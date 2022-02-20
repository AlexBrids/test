// Найти максимальное из трех чисел
Console.Clear();

int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int numberC = new Random().Next(1, 10);
int max = 0;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число равно {max}");
Console.WriteLine($"Число А: {numberA}");
Console.WriteLine($"Число В: {numberB}");
Console.WriteLine($"Число С: {numberC}");