//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
/*
int N = Convert.ToInt32(Console.ReadLine());
int[] squares = new int[N];
for ( int i = 1; i <= N; i++)
{
    squares[i-1]= i*i;
    Console.WriteLine(squares[i-1]);
}
// second variant

Console.WriteLine("_____________________________");
int A = Convert.ToInt32(Console.ReadLine());
int[] square = new int[A];
int x = 1;
while (x <= A)
{
    square[x-1]= x*x;
    Console.WriteLine(square[x-1]);
    x++;
}
*/
//Third variant
int[] ArraySquares(int num)
{
    int [] A = new int[num];
    int x = 1;
    while (x <= num)
    {
        A [x-1]= x*x;
        Console.WriteLine(A[x-1]);
        x++;
    }
    return A;
}
int [] result = ArraySquares(5);