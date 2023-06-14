// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MultiplyArray(int[,] Array1, int[,] Array2)
{
    int[,] ResultArray = new int[Array1.GetLength(0), Array2.GetLength(1)];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
            int multiply = 0;
            for (int k = 0; k < Array2.GetLength(0); k++)
            {
                multiply += Array1[i,k] * Array2[k,j];
            }
            ResultArray[i,j] = multiply;
        }
    }
    return ResultArray;
}

void RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = new Random().Next(0,5);
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j],3} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool IsValidNumber(int number)
{
    if(number > 0)
        return true;
    else
    {
        System.Console.WriteLine("Вы ввели неверное число!");
        return false;
    }

}

bool IsValidArray(int[,] Array1, int[,] Array2)
{
    if(Array1.GetLength(1) == Array2.GetLength(0))
        return true;
    else
    {
        System.Console.WriteLine("Количество столбцов в первой матрице не равно количеству строк во второй матрице!");
        System.Console.WriteLine("Произведение невозможно.");
        return false;
    }
}

System.Console.Write("Введите количество строк первой матрицы: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
if(!IsValidNumber(rows)) return;
System.Console.Write("Введите количество столбцов первой матрицы: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
if(!IsValidNumber(columns)) return;
int[,] Array1 = new int[rows,columns];
System.Console.Write("Введите количество строк второй матрицы: ");
rows = Convert.ToInt32(System.Console.ReadLine());
if(!IsValidNumber(rows)) return;
System.Console.Write("Введите количество столбцов второй матрицы: ");
columns = Convert.ToInt32(System.Console.ReadLine());
if(!IsValidNumber(columns)) return;
int[,] Array2 = new int[rows,columns];
if(!IsValidArray(Array1, Array2)) return;

RandomFillArray(Array1);
PrintArray(Array1);
RandomFillArray(Array2);
PrintArray(Array2);

int[,] ResultArray = MultiplyArray(Array1, Array2);
PrintArray(ResultArray);