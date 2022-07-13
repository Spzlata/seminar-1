// на вход принимает трехзначное число и удаляет вторую чифру этого числа
/*
int A = new Random().Next(100,999); //Выдает рандомные числа в нашем случае от 10 до 99
Console.WriteLine(A);
int firstnumber = A / 100;
int thirdnumber = A % 10;
Console.WriteLine(firstnumber*10 + thirdnumber);
*/

int NumberOfFirstAndThird(int start, int finish)
{
    int A = new Random().Next(start,finish); //Выдает рандомные числа в нашем случае от 10 до 99
    Console.WriteLine(A);
    int firstnumber = A / 100;
    int thirdnumber = A % 10;
    int result = firstnumber*10 + thirdnumber;
    return result;
}

int AFT = NumberOfFirstAndThird(100,999);
Console.WriteLine(AFT);