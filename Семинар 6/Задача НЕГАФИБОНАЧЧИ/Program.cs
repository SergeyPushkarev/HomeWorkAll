void FillArrayFibonacci(int[] Array)
{
    if(Array.Length > 0) Array[Array.Length/2] = 0;
    if(Array.Length > 1)
    {
        Array[Array.Length/2-1] = 1;
        Array[Array.Length/2+1] = 1;
    }
    
    for (int i = Array.Length/2+2; i < Array.Length; i++)
    {
        Array[i] = Array[i-1] + Array[i-2];
    }
    for (int i = 0; i < Array.Length/2-1; i++)
    {
        if(i%2 == 0) Array[i] = Array[Array.Length-i-1] * -1;
        else Array[i] = Array[Array.Length-i-1];
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

System.Console.Write("Введите число: ");
int size = Math.Abs(Convert.ToInt32(System.Console.ReadLine())) * 2 - 1;

int[] ArrayFibonacci = new int[size];

FillArrayFibonacci(ArrayFibonacci);
PrintArray(ArrayFibonacci);