//Задача 3.
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a, b вводит пользователь


void DividedAB(int A, int B, int num)
{
    if (num % A == 0 && num % B == 0)
    Console.WriteLine($"ваш номер{num} кратно {A}и{B}");
    else
    Console.WriteLine($"ваш номер{num} не кратно {A}и{B}");
}
Console.WriteLine("Введите ваше число: ");
int 