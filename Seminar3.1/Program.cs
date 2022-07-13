 //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void quarter(int A, int B)
{
    if (A > 0 && B > 0)
    {
        Console.WriteLine("First quarter");
    }
    else if (A < 0 && B > 0)
    {
        Console.WriteLine("Second quarter");
    }
    else if (A > 0 && B < 0)
    {
        Console.WriteLine("Third quarter");
    }
    else if (A < 0 && B < 0)
    {
        Console.WriteLine("Forth quarter");
    }
}

quarter(5, 6);
quarter(-5, 6);
quarter(-5, -5);
quarter(5, -6);

