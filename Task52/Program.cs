// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j]= new Random().Next(1,10);
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j], 3}  ");//3=резер кол-ва символов для вывода значения
        Console.WriteLine();
        }
}

int[] TraceArray(int[,] array)
{
    int[] summ = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
        int index=0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
            {
                summ[index]=(summ[index]+array[i,j]);
                index++;
            }           
        }
        }
    return summ;
}

double PrintArrayOdnomer(int[] array)
{
    double num=array.Length;
    foreach (var item in array)
    {
        Console.Write($"{Math.Round(item/num,3), 3} ");
    }
    System.Console.WriteLine();
    return num;
}

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array=new int[rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int[] summ = TraceArray(array);
PrintArrayOdnomer(summ);