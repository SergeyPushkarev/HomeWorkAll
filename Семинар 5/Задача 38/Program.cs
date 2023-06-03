//Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double DiffBetweenMaxMin(double[] Array)
{
    double Max = Array[0], Min = Array[0];
    for (int i = 1; i < Array.Length; i++)
    {
        if(Max < Array[i]) Max = Array[i];
        if(Min > Array[i]) Min = Array[i];
    }
    System.Console.WriteLine($"max: {Max}; min: {Min}");
    return Math.Round(Max - Min,3);
}

void FillArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1,10) + Math.Round(new Random().NextDouble(),3);
    }
}

void PrintArray(double[] Array)
{
    foreach (var item in Array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите диапазон массива: ");
int size = Convert.ToInt32(System.Console.ReadLine());

double[] Array = new double[size];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine($"Всего разница между максимальным и минимальным элементами: {DiffBetweenMaxMin(Array)}");