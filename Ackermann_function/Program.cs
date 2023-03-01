// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29;

int Message(string text)
{
    Console.Write(text);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int Ackfunction(int m, int n)
{
    if (m == 0)return n + 1;

    else if ((m > 0) && (n == 0)) return Ackfunction(m - 1, 1);

    else if ((m > 0) && (n > 0)) return Ackfunction(m - 1, Ackfunction(m, n - 1));

    else return n + 1;
}

int m = Message("введи значение M: ");
int n = Message("введи значение N: ");
Console.WriteLine(Ackfunction(m, n));
