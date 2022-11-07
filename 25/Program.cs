// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

//double c = Math.Pow(a,b);

int Degree(int a, int b)
{
    int count = 0;
    while(count < b)
    {
        int result = a * a;
        count++;
        return result;
    }
    return count;
}
Console.WriteLine($"Число {a}, возведённое в степень {b} является числом {Degree(a, b)}");
