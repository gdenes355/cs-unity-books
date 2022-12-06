using System;

___ ___ ID_Number
{

  public int min = 0;
  public int max = 1;

  public ID_Number(___ ___) // the constructor
  {
    min = Int32.Parse(___.Split("-")[0]);
    max = Int32.Parse(___.Split("-")[1]);
  }


}

public class AoC4
{

  public static string input = @"PLACE YOUR INPUT HERE";

  public static void Main(string[] args)
  {

    string ___;
    string ___;
    ID_Number ___;
    ID_Number ___;

    int overlap_pairs = 0; // used for part one
    int contain_pairs = 0; // used for part two

    foreach (string c in input.Split("\n"))
    {
      first_range = c.Split(",")[0];
      second_range = c.Split(",")[1];
      first_ID = ___ ID_Number(first_range);
      second_ID = new ___(second_range);

      if ((first_ID.min <= second_ID.min) && (first_ID.max >= second_ID.max) || //think about what this logic is doing
      ((second_ID.min <= first_ID.min) && (second_ID.max >= first_ID.max))) {
        ___ += 1;
        ___ += 1;
      } else if ((first_ID.min <= second_ID.min) && (first_ID.max >= second_ID.min) || 
      ((second_ID.min <= first_ID.min) && (second_ID.max >= first_ID.min))) {
        ___ += 1;
      }

    }

    ___.___($"Part One: {contain_pairs}, Part Two: {overlap_pairs}");

  }
}