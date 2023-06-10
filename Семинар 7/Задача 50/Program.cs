// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

void FindAndPrintPositionNumber(int[,] Array, int Num)
{
    List<string> TempList = new List<string>();
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            if(Array[i,j] == Num)
                TempList.Add(Convert.ToString(i) + "," + Convert.ToString(j));
    
    if(TempList.Count > 0)
    {
        System.Console.Write("Это число находится на позиции:  [");
        for (int i = 0; i < TempList.Count; i++)
        {
            System.Console.Write(TempList[i]);
            if(i < TempList.Count-1)
                System.Console.Write(" ; ");
        }
        System.Console.Write("]");
    }
    else System.Console.WriteLine("Введенного числа в массиве не найдено.");

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
    System.Console.WriteLine();
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
int[,] Array = new int[rows,columns];

RandomFillArray(Array);
PrintArray(Array);
System.Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(System.Console.ReadLine());
FindAndPrintPositionNumber(Array, number);