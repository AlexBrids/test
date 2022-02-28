// Найти третью цифру числа или сообщить что ее нет 

Console.Clear();

int GetNumber()
{
    int randomNumber = new Random().Next(50, 150);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Исходное число: {number}");

string str = Convert.ToString(number);
int length = str.Length;
//Console.WriteLine(length);

if (length < 3)
{
    Console.WriteLine("Чило двузначное, третьего числа нет.");
}
else
{
    int result = number % 10;
    Console.WriteLine($"Третье число, искомого числа: {result}");
}