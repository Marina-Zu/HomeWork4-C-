// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = Prompt("Введите число A > ");
int degree = Prompt("Введите показатель степени B > ");
int ADegreeB(int number)
{
   int answer = 1;
    for (int i = 1; i <= degree; i++)
    {
        answer = answer * number;
    }
   return answer;
}

System.Console.WriteLine($"Ответ: {ADegreeB(number)}");
