// Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли второе число кратным первому.
// 3. Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst % numSecond == 0)
{
    Console.WriteLine($"{numFirst}, {numSecond} => да");
}
else
{
    int result = numFirst % numSecond;
    Console.WriteLine($"{numFirst}, {numSecond} => нет, {result}");
}