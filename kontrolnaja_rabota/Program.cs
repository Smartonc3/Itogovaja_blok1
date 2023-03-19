using System;

string[] array = new string[6] { "3", "3421", "334", "4d", "rdffgg", "52" };
string[] array2 = new string[array.Length];

void SecondArrayWithIF(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            Console.Write($"{array2[count]} ");
            count++;   
        }
        
    }
}

SecondArrayWithIF(array, array2);