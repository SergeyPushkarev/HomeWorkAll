// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void CalculateAverageInArray(int[,] Array, double[] ArrayAverage)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
            ArrayAverage[i] += Array[j,i];
        ArrayAverage[i] /= Array.GetLength(0);
    }
}

void RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = new Random().Next(1,21);
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j],2} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArrayAverage(double[] Array)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i]);
        if(i < Array.Length - 1) System.Console.Write("; ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
int[,] Array = new int[rows,columns];
double[] ArrayAverage = new double[columns];

RandomFillArray(Array);
PrintArray(Array);
CalculateAverageInArray(Array, ArrayAverage);
PrintArrayAverage(ArrayAverage);