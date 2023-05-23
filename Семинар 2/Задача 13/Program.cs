System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 1000)
{
    num = num / 10;
}

if(num < 100)
    System.Console.Write("Третьей цифры нет");
else
    System.Console.Write(num % 10);