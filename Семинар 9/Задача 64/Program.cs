// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void OutputAllNumber (int num)
{
    System.Console.Write(num);
    if(num == 1) return;
    System.Console.Write(", ");
    OutputAllNumber(num-1);
}

System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

OutputAllNumber(num);