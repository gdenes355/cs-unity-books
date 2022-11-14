using System;

public class CountingPartTwo
{
  public static void Main(string[] args)
  {
    String input = new String();

    Console.WriteLine("What shall I count up to?");

    input = Console.ReadLine();

    int count = Int32.Parse(input);
    
    int iter = 0;

    ___ (iter < count) 
    {
        iter ++; //this increases iter by 1
        ___.___("Number " + iter.ToString())___
    }

  }
}