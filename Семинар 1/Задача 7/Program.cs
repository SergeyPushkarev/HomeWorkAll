System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool found = false;

while (found == false)
{
    if (num < 100)
    {
        System.Console.WriteLine("нет");
        found = true;
    }
    else if (num < 1000)
    {
        System.Console.WriteLine(num % 10);
        found = true;
    }
    else if (num < 10000)
        num = num / 10;
    else if (num < 100000)
        num = num / 100;
    else
        num = num / 1000;
}