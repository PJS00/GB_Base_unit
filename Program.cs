﻿// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Первое решение
// string[] str = ["Helllo", "World", "no", "2", "Hi", "Russia", "Kazan", ":-)", "1234", "567"];
// System.Console.WriteLine("Исходный массив: ");
// foreach (string s in str)
// {
//     System.Console.Write(s + " ");
// }
// System.Console.WriteLine("\n");
// System.Console.WriteLine("Новый массив: ");
// foreach (string s in str)
// {
//     if (s.Length <= 3)
//     {
//         System.Console.Write(s + " ");
//     }
// }

// Второе решение
// string[] MyToStringArray(string str)
// {
//     string[] words = str.Split(' ');
//     // PrintArray(words);
//     string[] result = new string[0];
//     foreach (string w in words)
//     {
//         if(w.Length <= 3)
//         {
//             System.Console.Write($"{w} ");
//         }
//     }
//     return result;
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Напишите несколько слов через пробел: ");
// string str = Console.ReadLine();
// PrintArray(MyToStringArray(str));

// Третье решение
string[] MyToStringArray(string str)
{
    string[] words = str.Split(' ');
    string[] result = new string[words.Length];
    int j = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            result[j] = words[i];
            j++;
        }
    }
    Array.Resize(ref result, j);
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Напишите несколько слов через пробел: ");
string str = Console.ReadLine();
PrintArray(MyToStringArray(str));