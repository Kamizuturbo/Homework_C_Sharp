// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

void Arr(int[] Array)
{
    for (int i = 0; i<Array.Length; i++)
    {
         Array[i] = new Random().Next(0, 100);
         System.Console.Write($"{Array[i]},");
    }
}

Console.Clear();
int[] Array = new int[new Random().Next(0, 9)];
Arr(Array);