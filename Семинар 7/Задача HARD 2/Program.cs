// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное.
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился
//на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

void IdentifyRandomPosition(int[] ArrayPosition, int[,] ArrayAllMove) //определить рандомную позицию для перемещения
{
    bool found = false;
    while(found == false)
    {
        ArrayPosition[0] = new Random().Next(0,ArrayAllMove.GetLength(0));
        ArrayPosition[1] = new Random().Next(0,ArrayAllMove.GetLength(1));
        if(ArrayAllMove[ArrayPosition[0],ArrayPosition[1]] != -1) found = true; //если генерированная позиция еще не участвовала в перемещении, то будем использовать ее
    }
}

void RandomMixArray(int[,] Array) //перемешаем массив случайно
{
    int[,] ArrayAllMove = (int[,])Array.Clone(); //создадим копию массива, в котором будем отмечать с помощью "-1" те элементы, которые уже участвовали в перемещении
    int[] Position = new int[2]; //создадим массив, в котором будем хранить позицию для перемещения
    int CountItem = Array.GetLength(0)*Array.GetLength(1), CountMove = 0; //создадим переменные для количества элементов и количества перемещений

    for (int i = 0; i < Array.GetLength(0); i++) //цикл по строкам
        for (int j = 0; j < Array.GetLength(1); j++) //цикл по столбцам
        {
            if(ArrayAllMove[i,j] == -1) continue; //если этот элемент уже перемещали, тогда продолжаем
            ArrayAllMove[i,j] = -1; //отмечаем этот элемент
            IdentifyRandomPosition(Position, ArrayAllMove); //определим случайную позицию для перемещения
            ArrayAllMove[Position[0],Position[1]] = -1; //отметим и этот элемент

            (Array[i,j], Array[Position[0],Position[1]]) = (Array[Position[0],Position[1]], Array[i,j]); //множественным присвоением поменяем элементы местами

            // PrintArray(Array);
            // PrintArray(ArrayAllMove);
            // System.Console.WriteLine("----------------------"); //это код для отладки, чтобы увидеть как двигаются элементы

            CountMove++;
            if(CountItem/2-1 == CountMove) //если это было предпоследнее перемещение, тогда поменяем местами оставшиеся 2 элемента
            {
                int[] firstPosition = new int[] {-1,-1};
                int[] secondPosition = new int[2];
                for (int k = 0; k < ArrayAllMove.GetLength(0); k++)
                    for (int m = 0; m < ArrayAllMove.GetLength(1); m++)
                    {
                        if(ArrayAllMove[k,m] != -1) //отбираем оставшиеся 2 элемента
                        {
                            if(firstPosition[0] != -1 && firstPosition[1] != -1) //если первую позицию уже определили, тогда это последний элемент
                            {
                                secondPosition[0] = k;
                                secondPosition[1] = m;
                                i = ArrayAllMove.GetLength(0); //в i,j,k,m заполним длину измерений массива, чтобы прекратить все циклы
                                j = ArrayAllMove.GetLength(1);
                                k = ArrayAllMove.GetLength(0);
                                m = ArrayAllMove.GetLength(1);
                            }
                            else
                            {
                                firstPosition[0] = k;
                                firstPosition[1] = m;
                            }
                        }
                    }

                (Array[secondPosition[0],secondPosition[1]], Array[firstPosition[0],firstPosition[1]])
                = (Array[firstPosition[0],firstPosition[1]], Array[secondPosition[0],secondPosition[1]]); //меняем местами последние 2 элемента
            }
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