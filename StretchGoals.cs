using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
  public class StretchGoals
  {
    public static void FizzBuzzBangOneLiner()
    {
      Enumerable.Range(1, 100).Select(
          i => Tuple.Create(i, string.Join("", new Dictionary<int, string>
          {
            {3, "Fizz"},
            {5, "Buzz"},
            {7, "Bang"}
          }.Where(rule => i%rule.Key == 0).Select(rule => rule.Value))))
        .Select(p => p.Item2 == "" ? p.Item1.ToString() : p.Item2)
        .ToList()
        .ForEach(Console.WriteLine);
    }
  }
}