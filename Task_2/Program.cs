Console.WriteLine("Enter the Two Numbers (Введите два числа): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", a);
}
else
{
    Console.WriteLine("{0} is the Greatest Number (является наибольшим числом)", b);
}
if (a < b)
{
    Console.WriteLine("{0} is the smallest number (является наименьшим числом)", a);
}
else
{
    Console.WriteLine("{0} is the smallest number (является наименьшим числом)", b);
}
Console.ReadLine();