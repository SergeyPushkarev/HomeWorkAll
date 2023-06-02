int RaiseToDegree(int numA, int numB)
{
    int temp = numA;
    for (int i=1; i < numB; i++)
    {
        numA *= temp;
    }
    return numA;
}

System.Console.Write("Введите число A: ");
int numA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число B: ");
int numB = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(RaiseToDegree(numA, Math.Abs(numB)));