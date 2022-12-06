using System;
using System.Linq;

public class AoC1
{

  public static string input = @"PLACE YOUR INPUT HERE";

  public ___ ___ ___(string[] args)
  {
    int[] all_elves = new int[input.Split("\n\n").Length];

    int[] ___ = new int[100];

    ___ iter = 0;
    ___ count = 0;

    foreach (___ cal in input.Split("\n")) 
    {

      if (cal.Trim() == "")
      {
        all_elves[iter] = calories.Sum();
        calories = new int[100];
        ___ ++;
        count = 0;
      }
      else
      {

        calories[count] = Int32.Parse(___);
        ___ ++;
      }
    }

    int topone = ___.Max(); // array max
    int topthree;

    for (int i = 0; i < 3; i++)
    {
      topthree __ all_elves.Max();
      all_elves[Array.IndexOf(all_elves, all_elves.Max())] = 0;
    }

    Console.WriteLine($"Part One: {___}, Part Two: {___}");

  }

}