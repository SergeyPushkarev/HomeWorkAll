// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalculateAckermanFunction (int m, int n)
{
    if (m == 0)
        return n + 1;
    else if((m > 0) && (n == 0))
        return CalculateAckermanFunction(m - 1, 1);
    else if((m > 0) && (n > 0))
        return CalculateAckermanFunction(m - 1, CalculateAckermanFunction(m, n - 1));
    else return n + 1;
}

System.Console.Write("Введите первое неотрицательное число (m): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе неотрицательное число (n): ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Результат функции аккермана для A({m},{n}) равен: {CalculateAckermanFunction(m, n)}");