using System;

public class CountingPartTwo
{
  public static void Main(string[] args)
  {
    string userInput = "";

    Console.WriteLine("What shall I count up to?");

    userInput = Console.ReadLine();

    int count = Int32.Parse(userInput);
    
    int i = 0;

    ___ (i < count) 
    {
        i ++; //this increases i by 1
        ___.___("Number " + i.ToString())___
    }

  }
}