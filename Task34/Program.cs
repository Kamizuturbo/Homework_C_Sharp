// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
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
void FindArray(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item%2==0)
            count++;
    }
    System.Console.WriteLine(count);
}


Console.Clear();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];

FillArray(array);
PrintArray(array);
FindArray(array);