// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(-10,11);
    }
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}
void SumOddElementsArray(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==0)
        {
            Sum=Sum+array[i];
        }
    }
    System.Console.WriteLine(Sum);
}


Console.Clear();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];

FillArray(array);
PrintArray(array);
SumOddElementsArray(array);