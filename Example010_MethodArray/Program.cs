﻿int[] array = { 11, 21, 3, 4, 18, 65, 76, 37, 18 };
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
       Console.WriteLine(index);
       break;
    }
    index++;
}
