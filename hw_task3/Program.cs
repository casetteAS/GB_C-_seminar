// Задача 3: Напишите программу, 
// 1. которая принимает на вход целое число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.Write("Введите любое число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num *= -1;
if (num >= 10 && num <= 99)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    if (digit1 > digit2)
    {
        Console.WriteLine($"{num} => {digit1}");
    }
    else
    {
        Console.WriteLine($"{num} => {digit2}");        
    }
}
