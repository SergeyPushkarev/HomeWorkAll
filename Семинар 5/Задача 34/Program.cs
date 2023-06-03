//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int CountEvenNumbers(int[] Array)
{
    int CountEvenNumbers = 0;
    foreach (var item in Array)
    {
        if(item %2 == 0) CountEvenNumbers++;
    }
    return CountEvenNumbers;
}

void FillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100,1000);
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
System.Console.WriteLine($"Всего четных чисел в этом массиве: {CountEvenNumbers(Array)}");