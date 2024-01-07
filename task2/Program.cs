// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num *= -1;
if (num >=100 && num <= 999)
{
    double digitSecond = num % 100 / 10;
    double result = Math.Pow(digitSecond, num % 10); 
    Console.WriteLine(result);
}