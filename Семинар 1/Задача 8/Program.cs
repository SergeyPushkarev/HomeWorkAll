System.Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Count = 2;

while (Count <= num)
{
    if (Count % 2 == 0)
        System.Console.Write(Count + ",");
    Count = Count + 2;
}