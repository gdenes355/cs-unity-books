using System;

public class PIN_verifier
{
  public static void Main(string[] args)
  {

    ___.WriteLine("Enter the PIN to verify:");
    string userInput = Console.___();

    ___[] characters = userInput.___();

    ___ verified = false;

    int i = 0;

    if (___) // length check 
    {

    }
    else 
    {

      while (___) 
      {

        if (Char.IsDigit(___[___])) // check that all four chars entered are digits
        {

        }

      }

    }

    if (___) 
    {
      Console.WriteLine("PIN approved");
    }
    ___ 
    {
      Console.WriteLine("___"); // add an angry message here
    }


  }
}