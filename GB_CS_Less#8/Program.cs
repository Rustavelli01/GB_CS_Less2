//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

//1.запросит у пользователя номер четверти
//2. нужно проверить введенные значения
//3.вывести ответ

void ShowDiaposone(int numQuat)
{
    if (numQuat == 1)
        Console.WriteLine("Ваш диапазон указывает на 1 четверть: x > 0, y > 0");
    else if (numQuat == 2)
        Console.WriteLine("Ваш диапазон указывает на 2 четверть: x < 0, y > 0");
    else if (numQuat == 3)
        Console.WriteLine("Ваш диапазон указывает на 3 четверть: x < 0, y < 0");
    else
        Console.WriteLine("Ваш диапазон указывает на 4 четверть: x > 0, y > 0");
}
Console.Write("Введите число нужного диапазона плоскости: ");
int quaterNumber = Convert.ToInt32(Console.ReadLine());

if (quaterNumber > 0 && quaterNumber < 5)
{
    ShowDiaposone(quaterNumber);
}
else Console.WriteLine("Это не является числом нужного диапазона плоскости: ");