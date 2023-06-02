int CalculateCountMulti(decimal num)
{
    int countMulti = 0;
    while(num % 1 != 0)
    {
        num *= 10;
        countMulti++;
    }
    return countMulti + 1;
}

int DoubleToInt(decimal num)
{
    while(num % 1 != 0)
    {
        num *= 10;
    }
    return Convert.ToInt32(num);
}

int CalculateCountDigitNumber(int num)
{
    int count = 0;
    while(num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

void WriteCountDigitNumber(int count)
{
    System.Console.WriteLine($"Количество цифр: {count}");
}

System.Console.Write("Введите число: ");
decimal num = Convert.ToDecimal(System.Console.ReadLine());

if (num > -1 && num < 1)
    if (num == 0) WriteCountDigitNumber(1);
    else WriteCountDigitNumber(CalculateCountMulti(num));
else
{
    WriteCountDigitNumber(CalculateCountDigitNumber(DoubleToInt(num)));
}