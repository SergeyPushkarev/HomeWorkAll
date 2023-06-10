// Задача HARD SORT необязательная
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

void SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) //сначала цикл по всем строкам массива
    {
        for (int j = 0; j < Array.GetLength(1); j++) //потом цикл по всем столбцам массива
        {
            int[] minPosition = new int[] {i,j}; //выделим массив, в котором будем хранить позицию самого минимального значения во всем массиве
            for (int k = i; k < Array.GetLength(0); k++) //запустим цикл снова по строкам, но уже исходя из строки, до которой дошли
            {
                int var = 0; //выделим переменную, в которой будет индекс столбца в зависимости от строки "k"
                if(k==i) var = j + 1;
                else var = 0;
                for (int m = var; m < Array.GetLength(1); m++) //запустим цикл снова по столбцам, но уже сходя из столбца, до которого дошли
                {
                    if(Array[minPosition[0],minPosition[1]] > Array[k,m]) //запоминаем позицию минимального значения
                    {
                        minPosition[0] = k;
                        minPosition[1] = m;
                    }
                }
            }
            int temp = Array[i,j]; //тут меняем местами минимальное значение и текущее
            Array[i,j] = Array[minPosition[0],minPosition[1]];
            Array[minPosition[0],minPosition[1]] = temp;
        }
    }
}

void RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = new Random().Next(-20,21);
    }
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j],3} ");
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
int[,] Array = new int[rows,columns];

RandomFillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
SortArray(Array);
PrintArray(Array);