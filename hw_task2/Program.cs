// Задача 2: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] arr = [1, 2, 3, 4, 5, 6];
void PrintElements(int i, int[] array)
{
    if (i > array.Length-1) return;
    PrintElements(i + 1, array);
    Console.Write($"{array[i]} ");
}
PrintElements(0, arr);