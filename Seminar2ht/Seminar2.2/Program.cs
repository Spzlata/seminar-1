// напишите программу, которая выводит случайное число из отреска от 10 до 99 и показывает наибольшую цифру числа.
// 78 - 8
// 12 - 2
// 85 - 8
/*
int A = new Random().Next(10,99); //Выдает рандомные числа в нашем случае от 10 до 99
Console.WriteLine(A);
int secondnumber = A % 10;
int firstnumber = A / 10;
if (secondnumber > firstnumber)
{
    Console.WriteLine(secondnumber + " > " + firstnumber);
}
else
{
    Console.WriteLine(firstnumber + " > " + secondnumber);
}


int A = new Random().Next(10,99); //Выдает рандомные числа в нашем случае от 10 до 99
Console.WriteLine(A);
int secondnumber = A % 10;
int firstnumber = A / 10;

void compareNumbers (int secondnumber, int firstnumber)
{
    if (secondnumber > firstnumber)
{
    Console.WriteLine(secondnumber + " > " + firstnumber);
}
else
{
    Console.WriteLine(firstnumber + " > " + secondnumber);
}
}

compareNumbers(firstnumber, secondnumber);

*/

void compareNumbers (int secondnumber, int firstnumber)
{
    if (secondnumber > firstnumber)
{
    Console.WriteLine(secondnumber + " > " + firstnumber);
}
else
{
    Console.WriteLine(firstnumber + " > " + secondnumber);
}
}

void CompNum(int start, int finish)
{
    int A = new Random().Next(start,finish); //Выдает рандомные числа в нашем случае от 10 до 99
    Console.WriteLine(A);
    int secondnumber = A % 10;
    int firstnumber = A / 10;
    compareNumbers(firstnumber, secondnumber);
}
CompNum(10,99);

