System.Console.Write("Введите целое или вещественное число: ");
double num = Convert.ToDouble(System.Console.ReadLine());

int Count = 0; 
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
    Console.Write(Convert.ToInt32(temp) / Convert.ToInt32(Math.Pow(10, Count))); //делим число на число в степени десятков, получаем первую цифру
    if(Count > 1) Console.Write(temp % Math.Pow(10, Count - 1)); //получаем остаток от деления на число в степени десятков - 1, чтобы пропустить вторую цифру
}