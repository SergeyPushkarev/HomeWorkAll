int CalculateSumDigitsNumber(int num)
{
    int SumDigitsNumber = 0;
    while (num != 0)
    {
        SumDigitsNumber += num % 10;
        num /= 10;
    }
    return SumDigitsNumber;
}

System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(CalculateSumDigitsNumber(num));