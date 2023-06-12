// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j]= new Random().Next(-30,31);
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

void Search(int [,] array,int SearchedNum)
{       bool Find = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j]==SearchedNum)
                    System.Console.WriteLine($"Координаты вашего числа {i},{j}");
                    Find = true;
            }
        }
        if (Find==false) System.Console.WriteLine("Вашего числа нет в массиве");
}

// void Search (int[,] array, int SearchedNum)
// {
//     bool Find = false;
//     foreach (var item in array)
//     {
//         if (item == SearchedNum)
//         {
//             System.Console.WriteLine("Да, есть");
//             Find=true;
//             break;
//         }
//     }
//     if (Find == false) System.Console.WriteLine("Вашего числа нет в массиве");
// }

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array=new int[rows, cols];

FillArray(array);
PrintArray(array);

System.Console.WriteLine("Введите значение искомого элемента");
int SearchedNum = Convert.ToInt32(Console.ReadLine());

Search(array, SearchedNum);

