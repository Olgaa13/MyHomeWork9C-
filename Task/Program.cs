
// Task64();
// Task66();
// Task68();

void Task64()

// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

{
    Console.Clear();
    Console.Write("Введите натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    DesSeqOfNumber(n);
}

void DesSeqOfNumber(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write($"{n} ");
    n--;
    DesSeqOfNumber(n);
}



void Task66()

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
{
    Console.Clear();
    Console.Write("Введите m ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SummNaturalElements(m, n));
}

int SummNaturalElements(int m, int n, int summ = 0)
{
    if (m == n + 1)
    {
        return summ;
    }
    summ = summ + m;
    m++;
    return SummNaturalElements(m, n, summ);
}



void Task68()

// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

{
    Console.Clear();
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Ackermann(m, n));

}
int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Ошибка, введите положительные числа!");
        return 0;
    }
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(n, m);
}
