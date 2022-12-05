// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Stepen(int c, int n)
    {
        double stepen = Math.Pow(c,n);
        return stepen;
    }

Console.Write ("Введите число А: ");
int c = int.Parse(Console.ReadLine());
Console.Write ("Введите число B: ");
int n = int.Parse(Console.ReadLine());

double st = Stepen(c,n);
Console.WriteLine($"{c},{n} -> {st}");
// Console.WriteLine(c);