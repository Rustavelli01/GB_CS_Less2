//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A(x1,y1), B(x2,y2)
/*
  ___________________
\/(х2-х1)(x2-x1)+(y2-y1)(y2-y1)
Math.Sqrt- Извлечение квадратного корня double
Math.Sqrt(25);
*/

double LineLengthAB(int x1, int x2, int y1, int y2)
{
    double lengthAB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return lengthAB;
}
Console.Write("Укажите Х координат А: ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите Y координат А: ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите Х координат B: ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите Y координат B: ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
double dist = LineLengthAB(xAcoord, xBcoord, yAcoord, yBcoord);
Console.WriteLine($"Длина от точки А до точки В: {dist:f2} ");