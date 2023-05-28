int GetCountOfDigits(int num) //Получить количество разрядов числа
{
    int countDigits = 0;
    int temp = num;
    while(temp > 0)
    {
        temp = temp / 10;
        countDigits++;
    }
    return countDigits;
}

int GetDigitOfNumber(int num, int digit) //Получить цифру числа
{
    int temp = num;
    int countDigits = 0;
    countDigits = GetCountOfDigits(num);
    
    if(digit < countDigits) //если нужно получить не самую крайнюю с правой стороны числа цифру, тогда откидываем лишние цифры справа с помощью деления
        temp = temp / Convert.ToInt32(Math.Pow(10, countDigits - digit));
    
    if(digit > 1) //если нужно получить не самую первую цифру, тогда получаем эту цифру с помощью остатка от деления
        temp = temp % 10;
    
    return temp;
}


bool isPalindrome(int num)
{
    int countDigits = GetCountOfDigits(num);
    int count = countDigits / 2;

    for(int i=1; i<=count; i++)
    {
        if(GetDigitOfNumber(num,i) != GetDigitOfNumber(num,countDigits - i + 1))
            return false;
    }
    return true;
}

System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine($"Число палиндром: {isPalindrome(num)}");