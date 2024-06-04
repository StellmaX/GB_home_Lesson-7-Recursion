using System;
class HellOfWorld 
{
  static void Main() 
  {
      int m = 2;
      int n = 1;
      Console.Write($"A ({m},{n}) = {A(m,n)}");
  }
  static int A(int m, int n)
  {
      if (m == 0)
      {
          return n + 1;
      }
      else if(m > 0 && n == 0)
      {
          return A(m-1, 1);
      }
      else 
      {
          return A(m-1,A(m, n-1));
      }
  }
}
