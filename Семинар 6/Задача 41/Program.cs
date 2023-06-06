int EnterAndCalculateGreatZero(int Count = 0)
{
    string StringNum = System.Console.ReadLine()!;
    if(StringNum.Length != 0)
    {
        if(Convert.ToInt32(StringNum) > 0) Count++;
        Count = EnterAndCalculateGreatZero(Count);
    }
    else return Count;
    return Count;
}

System.Console.WriteLine("Введите нужное количество чисел, отделяя их с помощью ENTER. Чтобы завершить ввод, отправьть пустую строку.");
System.Console.WriteLine($"Введено чисел больше нуля: {EnterAndCalculateGreatZero()}");