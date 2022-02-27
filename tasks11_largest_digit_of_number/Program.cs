// дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear();

int GetRandomNumber ()
{
    int randomNumber = new Random().Next(10, 100);
    return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Первое число больше и равно: {firstDigit}");
    Console.WriteLine($"Второе число равно: {secondDigit}");
}
else 
{
    Console.WriteLine($"Второе число больше и равно: {secondDigit}");
    Console.WriteLine($"Первое число равно: {firstDigit}");
}