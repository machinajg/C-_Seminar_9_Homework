// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Message(string text)
{
    Console.Write(text);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
void NumbersRecursion(int n)
{
    if (n == 0) return;
    else Console.Write($"{n}  ");
    NumbersRecursion(n - 1);
}
int n = Message("введи значение N: ");
NumbersRecursion(n);