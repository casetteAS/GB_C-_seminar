// Задача 2: Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// 2. выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

Console.Write("Введите координаты точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0) // X ≠ 0 и Y ≠ 0
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"{x}, {y} => 1");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine($"{x}, {y} => 2");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine($"{x}, {y} => 3");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine($"{x}, {y} => 4");
    }
}
else
{
    Console.WriteLine("Координаты ввели неверно. X ≠ 0 и Y ≠ 0");    
}