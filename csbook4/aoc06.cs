using System;
using System.Linq;

public class ___
{

  public ___ int packet_marker_part_one = 4; 
  // what modifier is used to show that these variables CAN be accessed WITHOUT a packet_manager object.
  public ___ int packet_marker_part_two = 14;
  private string current;

  ___ ___(string[] mycurrent) // the constructor
  {
    current = string.Join("", mycurrent);
  }

  public bool ___() 
  {
    return current.Distinct().Count() == current.Length;
  }


}

public class AoC6
{

  public static string input = @"PLACE YOUR INPUT HERE";

  public static void Main(string[] args)
  {
    packet_marker ___; // used later
    ___[] current = new ___[4]; // what type of array is it?
    int iter = 0;
    bool found = false;

    foreach (char c in input.ToCharArray()) 
    {
      if (found) { ___; } // continue or break?

      for (int i = 0; i < packet_marker.packet_marker_part_one; i++) // change static variable later for part 2
      {
        current[i] = input[iter + i].___(); // string parse
      }

      packet = ___ ___(current);

      if (packet.isDistinct()) 
      {

        Console.WriteLine(___ + packet_marker.packet_marker_part_one); // change static variable later for part 2

        found = true;
      }

      iter ++;
    }
  }
}