Console.WriteLine("Введи цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (num < 8)
{
    if (num < 6)
    {
        Console.WriteLine("К сожалению, сегодня будний день, а тебе пора на работу :(");
    }
    else if (num >= 6)
    {
        Console.WriteLine("Ура, сегодня выходной!:)");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}