Console.WriteLine("Enter a positive number (Введите положительное число)");
int i = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= i)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count++;
    }
    else
    {
        count++;
    }
}
Console.ReadLine();