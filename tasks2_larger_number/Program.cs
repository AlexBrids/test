Console.Clear();
int numberA = new Random().Next(0, 50); /// 1 2 3 4 5 .... 49
int numberB = new Random().Next(0, 50); 

if(numberA > numberB)
{
    Console.WriteLine($"Число А больше числа Б и равно: {numberA}");
    Console.WriteLine($"Число Б равно: {numberB}");
}
else
{
    Console.WriteLine($"Число Б больше числа А и равно: {numberB}");
    Console.WriteLine($"Число А равно: {numberA}");
}