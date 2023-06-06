//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

void CalculateintersectionPoint(double k1, double k2, double b1, double b2)
{
    if(b1 == b2 && k1 == k2)
        System.Console.WriteLine("Прямые совпадают");
    else if(k1 == k2)
        System.Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (-(b1-b2) / (k1-k2));
        double y = k1*x+b1;
        System.Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");
    }
}

System.Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(System.Console.ReadLine());

CalculateintersectionPoint(k1,k2,b1,b2);