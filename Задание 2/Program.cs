// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static string Reverse(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }
        return Reverse(s.Substring(1)) + s[0].ToString();
    }
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        var inputText = Console.ReadLine();
        Console.WriteLine("Перевернутая строка: " + Reverse(inputText));
        Console.ReadLine();
    }
}
