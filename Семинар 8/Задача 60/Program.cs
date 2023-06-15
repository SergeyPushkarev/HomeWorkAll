// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void RandomFillArray(int[,,] Array)
{
    int prevNum = 10; //это переменная в которой хранится предыдущее значение, чтобы начинать с него в целях уникальности. Начинаем с 10, чтобы было двухзначное число
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Array[i,j,k] = prevNum + new Random().Next(0,15);
                prevNum = Array[i,j,k];
            }
     for (int i=0; i < Array.GetLength(0); i++) //в этом цикле случайным образом перемешиваем массив
        for (int j = 0; j < Array.GetLength(1); j++)
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                int randI = new Random().Next(0,2);
                int randJ = new Random().Next(0,2);
                int randK = new Random().Next(0,2);
                (Array[i,j,k], Array[randI,randJ,randK]) = (Array[randI,randJ,randK], Array[i,j,k]);
            }
}

void PrintArray(int[,,] Array)
{
    for (int k = 0; k < Array.GetLength(2); k++)
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
                System.Console.Write($"{Array[i,j,k]}({i},{j},{k}) ");
            System.Console.WriteLine();
        }
}

int[,,] Array = new int[2,2,2];
RandomFillArray(Array);
PrintArray(Array);