int AskAQuestion()
{
    System.Console.Write("Введите цифру, обозначающую день недели: ");
    int temp = Convert.ToInt32(System.Console.ReadLine());
    if(temp < 1 || temp > 7)
    {
        System.Console.WriteLine("Введите цифру от 1 до 7!");
        temp = AskAQuestion();
    }
    return temp;
}

int num = AskAQuestion();
System.Console.WriteLine(num);
if(num < 6)
    System.Console.Write("Это будний день");
else
    System.Console.Write("Это выходной день");