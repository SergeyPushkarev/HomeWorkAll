int[] GenerateArray(int[] Array)
{
    for (int i=0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(95,100);
        System.Console.Write(Array[i]);
        if(i+1 < Array.Length) System.Console.Write(", ");
    }
    return Array;
}

int[] Array = new int[8];
Array = GenerateArray(Array);