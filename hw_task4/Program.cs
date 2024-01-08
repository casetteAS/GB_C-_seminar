// Задача 4: Напишите программу, которая на вход принимает натуральное число N
// а на выходе показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int digit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(digit + ", ");
        }
        else
        {
            Console.WriteLine(digit);
        }
    }
}