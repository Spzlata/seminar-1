//Массивы
/*
using System;
using System.IO;

int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];

for (int i = 0; i < num; i++)
{
    array[i] =i;
    Console.WriteLine(array[i]);
}
*/

// Days of week

int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
Console.WriteLine(weekDays[num - 1]);
