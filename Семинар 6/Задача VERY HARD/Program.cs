void RandomFillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1,21);
    }
}

void FindSequence(int[] Array, int[] ArraySeq)
{
    for (int i = 0; i < Array.Length; i++)
    {
        int firstNum = Array[i], secondNum = Array[i];
        bool notFound = false;
        while(notFound == false)
        {
            bool find = false;
            for (int j = 0; j < Array.Length-1; j++)
            {
                if(Array[j] == secondNum+1)
                {
                    secondNum = Array[j];
                    find = true;
                    break;
                }
            }
            
            if(find == false) notFound = true;
        }

        if(ArraySeq[1] - ArraySeq[0] < secondNum - firstNum)
        {
            ArraySeq[0] = firstNum;
            ArraySeq[1] = secondNum;
        }
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

int size = new Random().Next(10,21);
int[] Array = new int[size];
int[] ArraySequence = new int[2];

RandomFillArray(Array);
PrintArray(Array);
FindSequence(Array, ArraySequence);

if(ArraySequence[1] - ArraySequence[0] == 0)
    System.Console.WriteLine("Сплошной возрастающей последовательности не нашлось.");
else
    System.Console.WriteLine($"[{ArraySequence[0]}, {ArraySequence[1]}]");