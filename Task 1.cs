using System;
class Program
{
  static void Main() 
  {
        int M = Input();
        Console.Write($"Значение M = {M}"); 
        int N = Input() + M*2;
        Console.Write($"\nЗначение N = {N}");
        Console.Write($"\nЦелочисленные значения от N до N: ");
        Print(M,N);
  }
  static int Input()
  {
        Random rand = new Random();
        int x = rand.Next(3,9);
        return x;
  }
  static void Print(int min, int max)
  {
      if(min<max-1)
      {
          min++;
          Console.Write($"{min} ");
          Print(min,max);
      }
  }
}