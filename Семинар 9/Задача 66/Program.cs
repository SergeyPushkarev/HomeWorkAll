// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReturnSumInBetween (int num1, int num2, int sum=0)
{
    if(num1 == num2) return num1;
    return num1 + ReturnSumInBetween(num1+1,num2);
}

System.Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма всех чисел от {num1} до {num2} равна: {ReturnSumInBetween(num1, num2)}");