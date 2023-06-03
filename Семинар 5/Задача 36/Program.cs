//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
int SumOddIndex(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if(i %2 !=0) sum += Array[i];
    }
    return sum;
}

void FillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] Array)
{
    foreach (var item in Array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите диапазон массива: ");
int size = Convert.ToInt32(System.Console.ReadLine());

int[] Array = new int[size];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine($"Всего сумма элементов, стоящих на нечетных индексах: {SumOddIndex(Array)}");