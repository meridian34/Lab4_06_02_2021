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

    FillSubArray(arr, arrEven, true);
    PrintArr(arrEven);
    FillSubArray(arr, arrUneven, false);
    PrintArr(arrUneven);
    ReplaceArrElements(arrEven);
    PrintArr(arrEven);
    ReplaceArrElements(arrUneven);
    PrintArr(arrUneven);
    Console.WriteLine();
    if (GetCountLetter(arrEven) > GetCountLetter(arrUneven))
    {
        Console.WriteLine($"An even array has more uppercase letters.");
        Console.WriteLine($"Count in an even array: {GetCountLetter(arrEven)};");
        Console.WriteLine($"Count in an uneven array: {GetCountLetter(arrUneven)};");
    }
    else
    {
        Console.WriteLine($"An uneven array has more uppercase letters.");
        Console.WriteLine($"Count in an even array: {GetCountLetter(arrEven)};");
        Console.WriteLine($"Count in an uneven array: {GetCountLetter(arrUneven)};");
    }

    PrintArr(arrEven);
    PrintArr(arrUneven);
}

void PrintArr(object[] arr)
{
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
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
                    break;
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
                    break;
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
        string letter = arr[i].ToString();
        if (letter == "a" || letter == "e" || letter == "i" || letter == "d" || letter == "h" || letter == "j")
        {
            arr[i] = arr[i].ToString().ToUpper();
        }
    }
}

int GetCountLetter(object[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        string letter = arr[i].ToString();
        if (letter == "A" || letter == "E" || letter == "I" || letter == "D" || letter == "H" || letter == "J")
        {
            count++;
        }
    }

    return count;
}