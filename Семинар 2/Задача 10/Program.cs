System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int temp = num / 10 % 10;

System.Console.WriteLine(temp);