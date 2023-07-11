//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.




/*void NameFunk (args)
{
    <body>
}
NameFunk(args1);

int, double, bool NameFunk1()
{
    <body>
    return.......;
}
NameFunk1();*/

//Невозвратный метод

void CoordsTask1()
{
    Console.Write("Введите координату х: ");
    int xCoord = Convert.ToInt32(Console.ReadLine());
    while (xCoord == 0)
    {
        Console.WriteLine("Неверное значение. Попробуйте снова!: ");
        xCoord = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Введите координату у:");
    int yCoord = Convert.ToInt32(Console.ReadLine());



    while (xCoord == 0)
    {
        Console.WriteLine("Неверное значение. Попробуйте снова");
        yCoord = Convert.ToInt32(Console.ReadLine());
    }

    if (xCoord > 0 && yCoord > 0)
        Console.WriteLine("Точка координат находится в 1й четверти");
        else if (xCoord < 0 && yCoord > 0)
            Console.WriteLine("Точка координат находится в 2й четверти");
            else if (xCoord < 0 && yCoord < 0)
            Console.WriteLine("Точка координат находится в 3й четверти");
                else Console.WriteLine("Точка координат находится в 4й четверти");
}

CoordsTask1();