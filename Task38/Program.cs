// Задайте массив вещественных случайных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементов массива.

void FillArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Convert.ToDouble(new Random().Next(-1000,1100))/100;
    }
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void MinMaxElement(double[] array)
{
    double min=0;
    double max=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        max=array[i];
        if (array[i]<min)
        min=array[i];
    }
    System.Console.WriteLine(max-min);
}



Console.Clear();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];

FillArray(array);
PrintArray(array);
MinMaxElement(array);