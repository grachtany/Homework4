// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число - ");
int mas = int.Parse(Console.ReadLine());
int result = 0;
while (mas > 0)
{
    int digit;
    mas = Math.DivRem(mas, 10, out digit);
    int m = digit;
    Console.WriteLine(m);
    result += m;
}
Console.WriteLine($"Сумма всех цифр в числе равна {result}");