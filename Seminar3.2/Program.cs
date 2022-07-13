// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void NumOfDiapason(int A)
{
    if (A == 1)
    {
        Console.WriteLine("x from 0 to plus infinity, y from 0 to plus infinyty");
    }
    else if (A == 2)
    {
        Console.WriteLine("x from 0 to plus infinity, y from 0 to minus infinyty");
    }
    else if (A == 3)
    {
        Console.WriteLine("x from 0 to minus infinity, y from 0 to plus infinyty");
    }
    else if (A == 4)
    {
        Console.WriteLine("x from 0 to minus infinity, y from 0 to minus infinyty");
    }
}

NumOfDiapason(1);
NumOfDiapason(2);
NumOfDiapason(3);
NumOfDiapason(4);

//secondvariant
Console.WriteLine("__________________________________");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("x>0, y>0");
}
else if (num ==2)
{
    Console.WriteLine("x<0, y>0");
}
else if (num ==3)
{
    Console.WriteLine("x<0, y<0");
}
else if (num == 4)
{
    Console.WriteLine("x>0, y<0");
}
