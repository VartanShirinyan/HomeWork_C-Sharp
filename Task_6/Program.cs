Console.WriteLine("Enter a Number (Введите число): ");
int i = Convert.ToInt32(Console.ReadLine());
if (i % 2 == 0)
{
    Console.WriteLine("Divisible by 2 (Делится на 2)");
}
else
{
    Console.WriteLine("Not divisible by 2 (Не делится на 2)");
}
Console.ReadLine();