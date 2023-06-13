// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FindLargestSumOfElements(int[,] Array)
{
    int[] maxSum = new int[2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
            Sum += Array[i,j];
        if(maxSum[0] < Sum)
        {
            maxSum[0] = Sum;
            maxSum[1] = i;
        }
    }
    System.Console.WriteLine($"Максимальная сумма элементов в строке {maxSum[1]+1}, сумма равняется {maxSum[0]}");
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
            System.Console.Write($"{Array[i,j],3} ");
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Необходимо указать прямоугольный двумерный массив (кол. строк не равно кол. столбцов)");
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());

if(rows == columns) { System.Console.WriteLine("Нужно ввести прямоугольный массив!"); return; }
int[,] Array = new int[rows,columns];

RandomFillArray(Array);
PrintArray(Array);
FindLargestSumOfElements(Array);