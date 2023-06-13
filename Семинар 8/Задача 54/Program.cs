// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) //сначала цикл по всем строкам массива
    {
        for (int j = 0; j < Array.GetLength(1); j++) //потом цикл по всем столбцам массива
        {
            int maxPosition = j; //выделим переменную, в которой будем хранить позицию самого максимального значения по строке
            for (int k = j; k < Array.GetLength(1); k++) //запустим цикл снова по столбцам, но уже исходя из столбца, до которого дошли
            {
                if(Array[i,maxPosition] < Array[i,k]) //запоминаем позицию максимального значения
                    maxPosition = k;
            }
            (Array[i,j], Array[i,maxPosition]) = (Array[i,maxPosition], Array[i,j]); //тут меняем местами максимальное значение и текущее
        }
    }
}

void RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = new Random().Next(1,21);
    }
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

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
int[,] Array = new int[rows,columns];

RandomFillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
SortArray(Array);
PrintArray(Array);