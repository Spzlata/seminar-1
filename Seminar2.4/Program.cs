// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//Функция 
/*
void TwoDigit(int A, int B)
{
    if ( A % B == 0)
    {
        Console.WriteLine("Multiple");
    }
    else 
    {
        Console.WriteLine("Not Multiple: Remainder: " + A % B);
    }
}
TwoDigit(34, 5);
*/

void TwoDigit(int A)
{
    if ( A % 7 == 0 & A % 23 ==0)
    {
        Console.WriteLine("Multiple");
    }
    else 
    {
        Console.WriteLine("Not Multiple");
    }
}
TwoDigit(161);
