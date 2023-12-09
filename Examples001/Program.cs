// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


{
    Console.WriteLine("Введите значение M:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int n = int.Parse(Console.ReadLine());

    PrintNumbersInRange(m, n);

    Console.ReadLine();
}

static void PrintNumbersInRange(int start, int end)
{
    if (start <= end)
    {
        Console.Write(start + " ");
        PrintNumbersInRange(start + 1, end);
    }
}

