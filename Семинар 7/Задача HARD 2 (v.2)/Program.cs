// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное.
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился
//на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void FillList(List<string> ListArrayElements, int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            ListArrayElements.Add(Convert.ToString(i)+","+Convert.ToString(j));
}

int[] ConvertStrPositionToInt(string StrPosition)
{
    int[] ArrayIntPosition = new int[2];
    string[] ArrayStrPosition = new string[2];
    ArrayStrPosition = StrPosition.Split(","); //парсим строку на два элемента с использованием разделителя ","
    ArrayIntPosition[0] = Convert.ToInt32(ArrayStrPosition[0]);
    ArrayIntPosition[1] = Convert.ToInt32(ArrayStrPosition[1]);
    return ArrayIntPosition;
}

void RandomMixArray(int[,] Array) //перемешаем массив случайно
{
    List<string> ListArrayElements = new List<string>(); //создадим список, который будет хранить позиции элементов массива, которые еще не перемещались
    FillList(ListArrayElements, Array); //Заполним список всеми позициями массива

    while(ListArrayElements.Count > 0)
    {
        int[] TempPosition1 = ConvertStrPositionToInt(ListArrayElements[0]); //создадим два массива, в которых будем хранить позиции для перемещения
        int TempIndex = new Random().Next(1,ListArrayElements.Count-1);
        int[] TempPosition2 = ConvertStrPositionToInt(ListArrayElements[TempIndex]);
        ListArrayElements.RemoveAt(0); //удаляем использованные элементы, чтобы к ним не возвращаться
        ListArrayElements.RemoveAt(TempIndex-1);
        
        (Array[TempPosition1[0],TempPosition1[1]], Array[TempPosition2[0],TempPosition2[1]]) =
        (Array[TempPosition2[0],TempPosition2[1]], Array[TempPosition1[0],TempPosition1[1]]); //множественным присвоением поменяем элементы местами
        // PrintArray(Array);
        // System.Console.WriteLine("----------------------"); //это код для отладки, чтобы увидеть как двигаются элементы
    }
}

void RandomFillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            Array[i,j] = new Random().Next(1,21);
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j],2} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool CheckEven(int rows, int columns)
{
    if(rows*columns %2 == 0)
        return true;
    else return false;
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
if(!CheckEven(rows, columns))
{
    System.Console.WriteLine($"Необходимо ввести четное количество элементов массива! {Convert.ToString(rows)}*{Convert.ToString(columns)} = {Convert.ToString(rows*columns)}");
    return;
}
int[,] Array = new int[rows,columns];

RandomFillArray(Array);
PrintArray(Array);
RandomMixArray(Array);
PrintArray(Array);