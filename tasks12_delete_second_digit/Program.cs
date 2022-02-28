// Удалить вторую цифру трехзначного числа 

Console.Clear();

int GetMumber ()
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}

int number = GetMumber();
Console.WriteLine($"Исходное число: {number}");

void DeleteSecondDigit(int getNumber)
{
    int secondDigit = getNumber % 10;
    string secondResult = Convert.ToString(secondDigit);
    int firstDigit = getNumber / 100;
    string firstResult = Convert.ToString(firstDigit);
    Console.WriteLine(firstResult + secondResult);

}

DeleteSecondDigit(number);
