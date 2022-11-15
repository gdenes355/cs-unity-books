using System;

public class ReverseCase
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter a phrase with a mixture of upper and lower case:");
    string userInput = Console.ReadLine();

    char[] characters = userInput.ToCharArray();

    i = 0;

    while (i < userInput.____) 
    {
      ___ (Char.IsUpper(___[i])) 
      {
        ___[i] = Char.ToUpper(___[i]);
      }
      ___ ___ (Char.IsLower(___[i]))
      {
        ___
      }
      else 
      {
        // number or special character
        ___
      }
    }


    Console.WriteLine(___);
  }
}