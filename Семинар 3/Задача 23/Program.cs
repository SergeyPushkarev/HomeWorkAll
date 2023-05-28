void ReadArray(int[] ArrayCubes)
{
    for(int i=0;i<=ArrayCubes.Length-1;i++)
    {
        System.Console.WriteLine(ArrayCubes[i]);
    }
}

int[] ReturnArrayCubes(int num)
{
    int[] ArrayCubes = new int[num];
    for(int i=0;i<=num-1;i++)
    {
        ArrayCubes[i] = Convert.ToInt32(Math.Pow(i+1,3));
    }
    return ArrayCubes;
}

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int[] ArrayCubes = ReturnArrayCubes(num);
ReadArray(ArrayCubes);