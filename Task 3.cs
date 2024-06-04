using System;

class Program
{
    static void Main()
    {
        string [] str = StrinRand();
        Console.Write($"Изначальная строка:\n");
        PrintArray(str);
        Console.Write($"\nСтрока после разворота:\n");
        Reward(str,str.Length-1);
    }
    static string [] StrinRand()
    {
        Random rand = new Random();
        string [] StrRand = new string [rand.Next(3,11)];
        string [] str = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        for (int i =0; i<StrRand.Length; i++)
        {
            StrRand[i]=str[rand.Next(0,str.Length)];
        }
        return StrRand;
    }
    static void PrintArray(string [] str)
    {
        for (int i = 0; i<str.Length; i++)
        {
            Console.Write($"{str[i]} ");
        }
    }
    static void Reward (string [] str, int i)
    {
        if (i<0)
        {
            return;
        }
            Console.Write($"{str[i]} ");
            Reward(str,i-1);
    }
}
