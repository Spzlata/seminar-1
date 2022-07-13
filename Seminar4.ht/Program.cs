// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// hard one
/*
bool isPalindrome (int x)
{
    int div =1;
    while (x / div >= 10)
    {
        div *= 10;
    }
    Console.WriteLine(div);
    while ( x != 0)
    {
        int l = x / div;
        int r = x % 10;
        if ( l != r)
        {
            Console.WriteLine("Not a palindrome");
            return false;
        }
    }
    Console.WriteLine("Palindrome");
    return true;
}

isPalindrome(1234);
isPalindrome(12321);
*/
bool isPalindrome (int[] arr)
{
    bool result = false;
    const N = arr.Lenght;
    fot (int i = 0; i < N / 2; i++)
    {
        if (arr[i] !== arr[N -i-1])
        {
            Console.WriteLine("Not a palindrom");
            return result;
        }
    }
    result = true;
    Console.WriteLine("Palindrom");
    return result;
}

isPalindrome(1231);
isPalindrome(11211);
isPalindrome(1221);