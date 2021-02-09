using System;
using System.Collections.Generic;
int[] arr = InitArray();
foreach (var i in arr)
{
    Console.Write(i + " ");
}

Console.WriteLine();
if (arr != null && arr.Length > 0)
{
    object[] arrEven = new object[GetCountEvenNumber(arr)];
    object[] arrUneven = new object[GetCountUnevenNumber(arr)];
    foreach (var i in arrEven)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
    FillSubArray(arr, arrEven, true);
    FillSubArray(arr, arrUneven, false);
    foreach (var i in arrEven)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
    ReplaceArrElements(arrEven);
    ReplaceArrElements(arrUneven);
    foreach (var i in arrEven)
    {
        Console.Write(i + " ");
    }
}

int[] InitArray()
{
    Console.WriteLine("enter the size of the array:");
    int lenghtArr = 0;
    if (int.TryParse(Console.ReadLine(), out lenghtArr))
    {
        Console.WriteLine($"introduced the dimension of the array: {lenghtArr}");
        int[] retArray = new int[lenghtArr];
        for (int i = 0; i < lenghtArr; i++)
        {
            retArray[i] = new Random().Next(1, 26);
        }

        return retArray;
    }
    else
    {
        Console.WriteLine("Error: Not a number entered");
        return null;
    }
}

int GetCountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int GetCountUnevenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            count++;
        }
    }

    return count;
}

void FillSubArray(int[] mainArr, object[] subArr, bool fillEvenElements)
{
    for (int i = 0; i < mainArr.Length; i++)
    {
        if (fillEvenElements && mainArr[i] % 2 == 0)
        {
            for (int j = 0; j < subArr.Length; j++)
            {
                if (subArr[j] == null)
                {
                    subArr[j] = mainArr[i];
                }
            }
        }
        else if (!fillEvenElements && mainArr[i] % 2 != 0)
        {
            for (int j = 0; j < subArr.Length; j++)
            {
                if (subArr[j] == null)
                {
                    subArr[j] = mainArr[i];
                }
            }
        }
    }
}

Dictionary<string, string> GetAlphabet()
{
    Dictionary<string, string> alphabet = new Dictionary<string, string>
    {
        { "1", "a" },
        { "2", "b" },
        { "3", "c" },
        { "4", "d" },
        { "5", "e" },
        { "6", "f" },
        { "7", "g" },
        { "8", "h" },
        { "9", "i" },
        { "10", "j" },
        { "11", "k" },
        { "12", "l" },
        { "13", "m" },
        { "14", "n" },
        { "15", "o" },
        { "16", "p" },
        { "17", "q" },
        { "18", "r" },
        { "19", "s" },
        { "20", "t" },
        { "21", "u" },
        { "22", "v" },
        { "23", "w" },
        { "24", "x" },
        { "25", "y" },
        { "26", "z" }
    };
    return alphabet;
}

void ReplaceArrElements(object[] arr)
{
    Dictionary<string, string> alphabet = GetAlphabet();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = alphabet[arr[i].ToString()];
    }
}