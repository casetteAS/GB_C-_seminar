// Задание 1. Совместная работа
// Семинар 7. Рекурсия
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Пример
// 123 => 6
// 63 => 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigit(number));

int SumOfDigit(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumOfDigit(number / 10);
}

