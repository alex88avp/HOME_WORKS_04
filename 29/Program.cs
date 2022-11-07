// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (в примере показаны два разных массива, создаем именно для 8 элементов)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] array = new int[8];

void NewArray(int[] FillArray)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        FillArray[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] Ar)
{
    int count = array.Length;
    for(int j = 0; j < count; j++)
    {
        Console.Write($"{Ar[j]} ");
    }
}
NewArray(array);
Console.WriteLine();
PrintArray(array);