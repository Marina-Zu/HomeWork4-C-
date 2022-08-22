// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumDigits(int number)
{
    int answer = 0;
    while (number > 0)
    {
        int i = number % 10;
        answer = answer + i;
        number = number / 10;
    }
    return answer;
}

int number = Prompt("Введите число > ");
System.Console.WriteLine($"Сумма цифр равна {SumDigits(number)}");
