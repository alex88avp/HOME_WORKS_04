// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum(int number)
{
    
    int s = 0;
    while(number > 0)
    {
        int n = number % 10;
        s = s + n;
        number = number /10;
    
    }  
    return s;
}
Console.WriteLine($"{sum(number)} является суммой цифр в числе {number}");