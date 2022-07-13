// homework 2
/* Console.Write("Write first number ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number ");
int B = Convert.ToInt32(Console.ReadLine());


if (A > B)
{
    Console.WriteLine("First number (" + A + ") bigger than second (" + B + ")");
}
else
{
    Console.WriteLine("Second number (" + B + ") bigger than first (" + A + ")");
}

// second task of homwork 1

Console.Write("Write first number ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third number ");
int E = Convert.ToInt32(Console.ReadLine());

int max = C;

if (max < D)
{
    max = D;
}
if (max < E)
{
    max = E;
}
Console.WriteLine("Maximum is " + max);


// task 3 from homwork 1

Console.Write("Write a number ");
int A = Convert.ToInt32(Console.ReadLine());

if (A % 2 == 0)
{
    Console.Write("Number " + A + " is even");
}
else
{
    Console.Write("Number " + A + " is odd");
}


Console.Write("Write a number ");
int A = Convert.ToInt32(Console.ReadLine());
int i = 1;
while ( i<= A)
{
    if ( i% 2 == 0)
    {
        Console.Write( i + ", ");
    }
    i++;
}
*/
Console.Write("Write a number ");
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= A; i++)
if (i % 2 == 0)
{
    Console.Write( i + ", ");
}