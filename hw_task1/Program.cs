// Задача 1: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



int Ackerman_Func(int n, int m)
{
    if (n == 0) return m + 1;
    else
    {
        if (m == 0) return Ackerman_Func(n-1, 1);
    }
    return Ackerman_Func(n - 1, Ackerman_Func(n, m - 1));
}

Console.Write($"{Ackerman_Func(3, 2)} ");