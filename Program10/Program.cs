Console.WriteLine("Введите трёхзначное число");
 int numbers = Convert.ToInt32(Console.ReadLine());
        while (numbers >= 100)
        {
            numbers /= 10;
        }
        int digit = numbers % 10;
        Console.WriteLine("Вторая цифра в числе = "+digit);