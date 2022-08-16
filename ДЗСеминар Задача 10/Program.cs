Console.Write("введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10;
int num2 = num1 % 10;

Console.Write($"{num2} вторая из {number}");
