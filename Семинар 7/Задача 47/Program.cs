// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void RandomFillArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = Math.Round(new Random().Next(-20,21) + new Random().NextDouble(),2);
    }
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j],6} ");
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
double[,] Array = new double[rows,columns];

RandomFillArray(Array);
PrintArray(Array);