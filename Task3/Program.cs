// Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. Также ищет второй максимум 
// (число меньше максимального элемента, но больше всех остальных) 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int size = Prompt("Введите число элементов массива > ");


// Функция генерации массива
int[] ArrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(1, 10);
        i++;
    }
    return array;
}
// int[] result = ArrayFill(8);

// Поиск второго по величине элемента массива
int SecondNum(int number)
{
    int numMax = ArrayFill[1];
    int numSecond = ArrayFill[2];
    int i = 3;
    for (int[] arrayFill; i <= ArrayFill.Lenght; i++)
    {
        if (numMax < numSecond)
        {
            numMax = numSecond;
        }
        int num3 = ArrayFill[i];
        if (numMax < num3)
        {
            numMax = num3;
            numSecond = numMax;
        }
        if (numSecond < num3)
        {
            numSecond = num3;
        }

    }
    return i;
}

SecondNum(number);
System.Console.WriteLine($"Второй максимум {numSecond}");
//System.Console.WriteLine($"{ArrayFill(result)}");
