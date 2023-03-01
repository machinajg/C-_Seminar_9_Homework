// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Message(string text)
{
    Console.Write(text);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int SegmentRecursion(int m, int n)
{
    if (m == n) return m;
    else return m + SegmentRecursion((m + 1), n);
}
int m = Message("введи значение M: ");
int n = Message("введи значение N: ");
Console.WriteLine(SegmentRecursion(m, n));