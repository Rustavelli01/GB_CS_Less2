//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8


int DigitRandom()
{
    int randomNum = new Random().Next(10,100);
    Console.WriteLine("Generated numcer is" + randomNum);

    int ed = randomNum%10;
    int dec = randomNum/10;
   
    if (ed > dec)
        return ed;
    else if (dec > ed)
        return dec;
    else
       return dec;
}
Console.WriteLine($"Большее значение {DigitRandom()}");