System.Console.Write("Введите целое или вещественное число: ");
double num = Convert.ToDouble(System.Console.ReadLine());

int Count = 0;
double result = 0;
double temp = num;
while (temp > 9) //определяем сколько десятков в числе
{
    temp = temp / 10;
    Count++;
}
if(Count == 0)
    System.Console.Write("нет");
else
{
    temp = num;
    double firstDigit = Convert.ToInt32(temp) / Convert.ToInt32(Math.Pow(10, Count)); //делим число на число в степени десятков, получаем первую цифру
    double leftPart = 0;
    if(Count > 1) //если десятков больше 1, тогдаы нужно возвести первую цифру в десяток, сотню и т.д., чтобы верно сложить левую и првую часть числа
        leftPart = firstDigit * Math.Pow(10, Count - 1);
    else //иначе первая цифра и есть вся целая часть числа (после удаления второй цифры целой части)
        leftPart = firstDigit;
    
    double rightPart = temp % Math.Pow(10, Count - 1); //получаем остаток от деления на число в степени десятков - 1, чтобы пропустить вторую цифру
    result = leftPart + rightPart; //складываем левую и правую часть числа
}

if(result != 0)
    System.Console.WriteLine(result);