//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.



//Возвратный метод с 2 аргументами

int Task1Coords(int x, int y)
{
    int numQuater;
    if (x > 0 && y > 0)
        numQuater = Console.WriteLine("Вы попали в плоскость 1!");

    else if (x < 0 && y > 0)
        numQuater = Console.WriteLine("Вы попали в плоскость 2!");
    else if (x < 0 && y < 0)
        numQuater = Console.WriteLine("Вы попали в плоскость 3!");
    else numQuater = Console.WriteLine("Вы попали в плоскость 4!");
    return numQuater;
}
Console.Write("Введите координату Х: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

//if (xCoord==0|| yCoord ==0)

if (xCoord == 0)

    Console.WriteLine("Ошибка!вы попали на ось Х! ");

else if (yCoord == 0)
    Console.WriteLine("Ошибка!вы попали на ось Y! ");

else
    Console.Write(Task1Coords(xCoord, yCoord));
