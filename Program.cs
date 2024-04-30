// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// string[] str = ["Helllo", "World", "no", "2", "Hi", "Russia", "Kazan", ":-)", "1234", "567"];

// // string[] str2 = new string[str.Length];
// // for (int i = 0; i < str2.length; i++)
// // {
// //     if (str[i].Length <= 3)
// //     {
// //         System.Console.WriteLine(str[i]);
// //     }
// // }
// foreach (string w in str)
// {
//     if (w.Length <= 3)
//     {
//         System.Console.Write($"{w} ");
//     }
// }

string[] MyToStringArray(string str)
{
    string[] words = new string[str.Length];
    foreach (string w in words)
    {
        System.Console.WriteLine($"{w} ");
    }
    // return words;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

string[] CreateNewArray(string[] array)
{
    string[] array2 = new string[array.Length];
    for (int i = 0; i < array.Length / 2; i++)
    {
        array2[i].Length <= 3;
    }
    return array2;
}

System.Console.Write("Напишите несколько слов через пробел: ");
string str = Console.ReadLine();
PrintArray(MyToStringArray(str));
PrintArray(CreateNewArray(str));