// Напишите программу, которая 
// 1. выводит третью с конца цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100)
{
    int result = num / 100 % 10;
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine($"{num} => Третьей цифры нет");
}