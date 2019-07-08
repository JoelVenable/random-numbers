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


    }
  }
}
