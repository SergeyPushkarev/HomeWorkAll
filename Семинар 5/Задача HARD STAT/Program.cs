//Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов.
//Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива.

int CalculateMedian(int[] Array)
{
    int result = 0;
    if(Array.Length %2 == 0)
    {
        int firstVal = Array[Array.Length / 2 - 1];
        int secondVal = Array[Array.Length / 2];
        result = (firstVal + secondVal) / 2;
    }
    else result = Array[Array.Length / 2];
    return result;
}

void SortArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        int minPosition = i;
        for (int ii = i+1; ii < Array.Length; ii++)
        {
            if(Array[minPosition] > Array[ii]) minPosition = ii;
        }
        int temp = Array[i];
        Array[i] = Array[minPosition];
        Array[minPosition] = temp;
    }
}

void FillMinMax(int[] Array, int[][] ArrayMaxMinAverage)
{
    List<int> ListMinIndex = new List<int>(), ListMaxIndex = new List<int>();
    ListMinIndex.Add(0); ListMaxIndex.Add(0);

    int Max = Array[0], Min = Array[0];
    for (int i = 1; i < Array.Length; i++)
    {
        if(Min > Array[i])
        {
            Min = Array[i];
            ListMinIndex.Clear();
            ListMinIndex.Add(i); //после очистки сразу добавляем текущий индекс, т.к. на данный момент он считается минимальным значением
        }
        else if(Min == Array[i]) ListMinIndex.Add(i);
        
        if(Max < Array[i])
        {
            Max = Array[i];
            ListMaxIndex.Clear();
            ListMaxIndex.Add(i); //после очистки сразу добавляем текущий индекс, т.к. на данный момент он считается максимальным значением
        }
        else if(Max == Array[i]) ListMaxIndex.Add(i);
    }

    if(ListMinIndex.Count > 0)
    {
       ArrayMaxMinAverage[0] = new int[ListMinIndex.Count]; //определяем размер массива с индексами минимальных
       for (int i = 0; i < ListMinIndex.Count; i++)
       {
            ArrayMaxMinAverage[0][i] = ListMinIndex[i]; //переносим индексы мин. значений из листа в осн. массив
       }
    }
    if(ListMaxIndex.Count > 0)
    {
       ArrayMaxMinAverage[1] = new int[ListMaxIndex.Count]; //определяем размер массива с индексами максимальных
       for (int i = 0; i < ListMaxIndex.Count; i++)
       {
            ArrayMaxMinAverage[1][i] = ListMaxIndex[i]; //переносим индексы макс. значений из листа в осн. массив
       }
    }
}

void CalculateMaxMinAverage(int[] Array, int[][] ArrayMaxMinAverage)
{
    FillMinMax(Array, ArrayMaxMinAverage); //эта функция заполнит все индексы мин. и макс. значений
    
    int Average = 0;
    foreach (var item in Array)
    {
        Average += item;
    }
    Average /= Array.Length;
    ArrayMaxMinAverage[2] = new int[1]; //определяем размер массива для среднего арифметического
    ArrayMaxMinAverage[2][0] = Average;
}

void FillArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1,21);
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

void PrintArrayMaxMinAverage(int[][] ArrayMaxMinAverage, int[] Array)
{
    for (int i = 0; i < ArrayMaxMinAverage.Length; i++)
    {
        if(i==0)
        {
            System.Console.Write($"Минимальное значение массива равно: {Array[ArrayMaxMinAverage[0][0]]}. ");
            if(ArrayMaxMinAverage[0].GetLength(0) > 1) System.Console.Write($"Индексов с этим значением несколько: ");
            else System.Console.Write($"Индекс с этим значением: ");
        }
        else if(i==1)
        {
            System.Console.Write($"Максимальное значение массива равно: {Array[ArrayMaxMinAverage[1][0]]}. ");
            if(ArrayMaxMinAverage[1].GetLength(0) > 1) System.Console.Write($"Индексов с этим значением несколько: ");
            else System.Console.Write($"Индекс с этим значением: ");
        }
        else if(i==2)
        {
            System.Console.Write("Среднее арифметическое всех чисел массива равно: ");
        }
        for (int ii = 0; ii < ArrayMaxMinAverage[i].GetLength(0); ii++)
        {
            System.Console.Write(ArrayMaxMinAverage[i][ii]);
            if(ii < ArrayMaxMinAverage[i].GetLength(0)-1) System.Console.Write(", ");
        }
        System.Console.WriteLine();
    }
}
//Эта программа позволяет задать массив случайных чисел указанного диапазона, находит макс. значение, мин. значение и все их индексы (если таких значений больше 1)
//находит среднее арифм. всех чисел и выводит результат с пояснением. Находит медианное значение первонач. массива
System.Console.Write("Введите диапазон массива: ");
int size = Convert.ToInt32(System.Console.ReadLine());

int[] Array = new int[size];
int[][] ArrayMaxMinAverage = new int[3][]; //0 - массив всех индексов с минимальными значениями; 1 - с максимальными; 2 - среднее арифметическое всех чисел

FillArray(Array); //заполним массив случайными числами от 1 до 20
PrintArray(Array); //выведем полученный массив
CalculateMaxMinAverage(Array, ArrayMaxMinAverage); //рассчитаем все макс. и мин. значения массива, среднее арифм. и сохраним это в отдельном массиве
PrintArrayMaxMinAverage(ArrayMaxMinAverage, Array); //выведем полученную инфу с подробным описанием

int[] ArraySort = Array; //здесь будет отсортированный по возрастанию первоначальный массив
SortArray(ArraySort); //отсортируем массив по возрастанию
System.Console.WriteLine(); System.Console.WriteLine($"Упорядоченный первоначальный массив для вычисления медианного значения:");
PrintArray(ArraySort); //выведем отсортированный массив
System.Console.Write($"Медианное значение равняется: {CalculateMedian(ArraySort)}"); //покажем медианное значение