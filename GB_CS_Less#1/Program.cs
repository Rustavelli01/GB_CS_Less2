//Задача 1.
//Напишите программу, которая получает на вход двузначное число и показывает наибольшую цифру числа.


Console.WriteLine("Enter your number: ");
int user_nam = Convert.ToInt32(Console.ReadLine());

if (user_nam >= 9 && user_nam < 100)
{
    int ed = user_nam % 10;
    int des = user_nam / 10;

    if(ed<des)
    {
        Console.WriteLine($"Большее значение это {des}");
    }
    else if (ed>des)
    {
        Console.WriteLine($"Большее значение это {ed}");
    }
        else
        {
            Console.WriteLine($"Значение эквивалентно {des}");
        }
}
else Console.WriteLine("Некорректное значение");



