using System;
using System.Text;

namespace FizzBuzz
{
  public class Part2
  {
    public static void FizzBuzzBang()
    {
      for (int i = 1; i <= 200; i++)
      {
        var builder = new StringBuilder();

        if (i%3 == 0)
        {
          builder.Append("Fizz");
        }

        if (i%5 == 0)
        {
          builder.Append("Buzz");
        }

        if (i%7 == 0)
        {
          builder.Append("Bang");
        }

        Console.WriteLine(builder.Length == 0 ? i.ToString() : builder.ToString());
      }
    }

  }
}