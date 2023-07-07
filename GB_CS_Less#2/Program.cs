int DigitsTask1(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
        return ed;
    else if (dec < ed)
        return dec;
    else
        return ed;

}

Console.WriteLine("Enter your number: ");
int user_nam = Convert.ToInt32(Console.ReadLine());

if (user_nam >= 10 && user_nam <= 99)
{
    int result = DigitsTask1(user_nam);
    Console.WriteLine($"Большее значение {result}");

}
else 
    Console.WriteLine("Ошибка");

