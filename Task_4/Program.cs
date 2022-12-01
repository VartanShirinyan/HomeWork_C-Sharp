Console.WriteLine("Enter Three Numbers (Введите три числа): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", a);
    }
    else
    {
        Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", c);
    }
}
else if (b > c)
{
    Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", b);
}
else
{
    Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", c);
}
Console.ReadLine();