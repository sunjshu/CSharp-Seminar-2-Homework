string[] isweekend = { "нет", "нет", "нет", "нет", "нет", "да", "да" };
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 8 && number > 0)
{

    Console.WriteLine(isweekend[number - 1]);
}
else
{
    Console.WriteLine("Таких дней недели еще не придумали");
}