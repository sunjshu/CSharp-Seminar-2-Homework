Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    int num1 = number % 1000;
    int num2 = num1 / 100;
    Console.WriteLine($"Третья цифра от {number}  - {num2}");
}