//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int num; 
int num2;
num = new Random().Next(100, 999);
Console.WriteLine(" Initial num " + num);

num2 = (num/10) % 10;
Console.WriteLine(" Initial num " + num2);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Not working
void hasThirdNumber(int x) //
{
    int div = 1;
    while ( x / div >= 10) //переменная х подается на вход, делим на див 
    {
        div *= 10;
    }
}
if (div < 100)
{
    Console.WriteLine("Too little");
}
else
{
    {
        int digit = (x/(div/100)) % 10;
        Console.WriteLine("Third is {0}", digit);
    }
}

hasThirdNumber(12);
hasThirdNumber(123);
hasThirdNumber(1234);
hasThirdNumber(12345);
hasThirdNumber(987654);
*/
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string [] day = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
Console.Write("Write a number:  ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >=1 && num <=7)
{
    Console.Write("This is " + day[num-1]);
    if (num ==6 || num == 7)
    {
        Console.Write(" - weekend");
    }
}
else 
{
    Console.WriteLine("Not exist");
}