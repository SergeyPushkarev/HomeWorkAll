// Напишите программу, которая заполнит спирально массив 4 на 4.

void FillArraySpirally(string[,] Array)
{
    int count = 1;
    int filledBorders = 0; //счетчик заполненных границ массива для вычитания их в цикле
    int direction = 0; //переменная для назначения, т.е. в каком направлении будем двигаться по массиву (вверх, вниз, влево, вправо)
    int[] target = new int [] {-1,-1}; //массив который определяет до какой точки мы должны двигаться в цикле (до конца строки/столбца или до начала)
    int j = 0, i = 0; //счетчик строк и столбцов для цикла
    bool[] madeStep = new bool[2]; //флаг обозначающий любой шаг в массиве. Если массив полностью заполнен, значит один из этих флагов останется в значении false
    madeStep[0] = true; madeStep[1] = true;
    while(madeStep[0] && madeStep[1]) //пока мы делаем какой-либо шаг, т.е. заполняем какой либо элемент, продолжаем цикл
    {
        madeStep[0] = false; madeStep[1] = false;
        if(target[0] == -1) //если до этого двигались к началу массива (влево или вверх), тогда меняем направление
        {
            target[0] = Array.GetLength(0);
            target[1] = Array.GetLength(1);
            direction = 1;
        }
        else
        {
            target[0] = -1;
            target[1] = -1;
            direction = -1;
        }
        filledBorders *= -1; //после каждого движения в одну сторону меняем знак у счетчика заполненных границ, чтобы верно "откидывать эти границы" в цикле
        for (; j != target[1]+filledBorders; j+=direction)
        {
            if(!String.IsNullOrEmpty(Array[i,j])) continue; //если это следующая итерация цикла while, то мы всегда продолжаем с предыдущего элемента, который уже заполнили
            string temp = String.Empty;
            if(count < 10) temp = "0" + Convert.ToString(count);
            else temp = Convert.ToString(count);
            Array[i,j] = temp;
            
            count++;
            madeStep[0] = true;
        }
        j+=direction*-1;
        if(j == 0 + Math.Abs(filledBorders) && i == Array.GetLength(0)-1 - Math.Abs(filledBorders))
        {
            filledBorders++;
        }
        for (; i != target[0]+filledBorders; i+=direction)
        {
            if(!String.IsNullOrEmpty(Array[i,j])) continue;
            string temp = String.Empty;
            if(count < 10) temp = "0" + Convert.ToString(count);
            else temp = Convert.ToString(count);
            Array[i,j] = temp;
            
            count++;
            madeStep[1] = true;
        }
        i+=direction*-1;
    }
}

void PrintArray(string[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            System.Console.Write($"{Array[i,j]} ");
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(System.Console.ReadLine());
string[,] Array = new string[rows,columns];

FillArraySpirally(Array);
PrintArray(Array);