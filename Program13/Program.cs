
Console.WriteLine("Введите целое число");
int numbers = Convert.ToInt32(Console.ReadLine());
int digit = 0, i = 0;

if (numbers > 99)
{
    i = numbers;
    while (i >= 1000)
    {
        i /= 10;
        digit = i % 10;
    }
    Console.WriteLine($"Третья цифра в числе = {digit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}