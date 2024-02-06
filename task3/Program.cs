// Семинар 7. Рекурсия
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


void ConsonantLetters(int i, string allSymbol)
{
    // A,a, E,e, I,i, O,o U,u, Y,y
    if (i > allSymbol.Length - 1) return;
    char t = char.ToLower(allSymbol[i]);
    if (t != 'a' && t != 'e' && t != 'i' && t != 'o' && t != 'u' && t != 'y')
    {
        Console.Write($"{allSymbol[i]} ");
    }
    ConsonantLetters(i + 1, allSymbol);
}

Console.WriteLine("Введите строку, содержащую латинские буквы: ");
string stringAllSymbol = Console.ReadLine();
ConsonantLetters(0, stringAllSymbol);

// void PrintConsonants(int index, string allSymbol)
// {
// if (index > allSymbol.Length - 1)
// {
// return;
// }

// char t = char.ToLower(allSymbol[index]);
// if (t != 'e' && t != 'a' && t != 'o' && t != 'i' && t != 'u' && t != 'y')
// {
// Console.Write($"{allSymbol[index]} ");
// }
// PrintConsonants(index + 1, allSymbol);
// }
// Console.WriteLine("Введите строку, содержащую латинские буквы");
// string StringAllSymbol = Console.ReadLine();
// PrintConsonants(0, StringAllSymbol);