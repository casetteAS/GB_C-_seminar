// Задача 1: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23
// a=50 => нет
// a=7 => нет
// a=322 => да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write($"{num} => да");
}
else
{
    Console.Write($"{num} => нет");    
}