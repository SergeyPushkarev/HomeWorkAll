double CalculateDistance(List<int> ListCoord, int SpaceDimension)
{
    double distance = 0.0;
    switch(SpaceDimension)
    {
        case 1:
        {
            //ListCoord[0] - x1; ListCoord[1] - x2
            distance = Math.Sqrt(Math.Pow(ListCoord[1] - ListCoord[0], 2));
            break;
        }
        case 2:
        {
            //ListCoord[0] - x1; ListCoord[1] - y1; ListCoord[2] - x2; ListCoord[3] - y2
            distance = Math.Sqrt(Math.Pow(ListCoord[2] - ListCoord[0], 2) + Math.Pow(ListCoord[3] - ListCoord[1], 2));
            break;
        }
        case 3:
        {
            //ListCoord[0] - x1; ListCoord[1] - y1; ListCoord[2] - z1; ListCoord[3] - x2; ListCoord[4] - y2; ListCoord[5] - z2;
            distance = Math.Sqrt(Math.Pow(ListCoord[3] - ListCoord[0], 2) + Math.Pow(ListCoord[4] - ListCoord[1], 2) + Math.Pow(ListCoord[5] - ListCoord[2], 2));
            break;
        }
    }
    return distance;
}

List<int> EnterCoordinates(List<int> ListCoord, int SpaceDimension)
{
    switch(SpaceDimension)
    {
        case 1:
        {
            System.Console.Write("Введите координату x1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату x2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            break;
        }
        case 2:
        {
            System.Console.Write("Введите координату x1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату y1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату x2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату y2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            break;
        }
        case 3:
        {
            System.Console.Write("Введите координату x1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату y1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату z1: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату x2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату y2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            System.Console.Write("Введите координату z2: ");
            ListCoord.Add(Convert.ToInt32(System.Console.ReadLine()));
            break;
        }
    }
    return ListCoord;
}

System.Console.WriteLine("1. Одномерное пространство");
System.Console.WriteLine("2. Двумерное пространство");
System.Console.WriteLine("3. Трехмерное пространство");
System.Console.Write("Введите размерность пространства для расчета расстояния между точками: ");
int SpaceDimension = Convert.ToInt32(System.Console.ReadLine());

if(SpaceDimension < 1 || SpaceDimension > 3)
{
    System.Console.WriteLine("Такой размерности пространства не знаю...");
    return;
}

List<int> ListCoord = new List<int>();

ListCoord = EnterCoordinates(ListCoord, SpaceDimension);

System.Console.WriteLine(CalculateDistance(ListCoord, SpaceDimension));