System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    System.Console.Write("max: " + num1 + " min: " + num2);
else
    System.Console.Write("max: " + num2 + " min: " + num1);