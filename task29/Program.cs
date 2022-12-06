// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
int i = 0;
while (i < 8)
{
    int rnd = new Random().Next(1, 100);
    array[i] = rnd;
    i++;
}
Console.Write($"[{string.Join(",", array)}]");
