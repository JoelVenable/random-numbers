using System;
using System.Collections.Generic;

namespace randomNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      var numbers = new List<int>() {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6)
            };

      for (int i = 0; i < numbers.Count; i++)
      {
        Boolean doesContain = numbers.Contains(i);
        Console.WriteLine($"numbers list {(doesContain ? "contains" : "does not contain")} {i}");
      }
    }
  }
}
