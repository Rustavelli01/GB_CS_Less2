//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46, 789 -> 79

//a = 456 / 100 
//b = 456 % 10

//result = a * 10 + b




/*void DeleteDigit()
{
    int random3Dig = new Random().Next(100, 1000);
    Console.WriteLine("ваша цыфра " + random3Dig);
    int dig1 = random3Dig / 100;
    int dig2 = random3Dig % 10;

    int newNum = dig1 * 10 + dig2;
    Console.WriteLine($"result is {newNum}");
}
DeleteDigit();*/



int DeleteDigit()
{
    int random3Dig = new Random().Next(100, 1000);
    Console.WriteLine("ваша цыфра " + random3Dig);
    int dig1 = random3Dig / 100;
    int dig2 = random3Dig % 10;

    int newNum = dig1 * 10 + dig2;
    //Console.WriteLine($"result is {newNum}");
    return newNum;
}
int result=DeleteDigit();
Console.WriteLine($"Result is {result}");
