using System;


public class Word
{

  private string answer;
  private char[] guessCopy = new char[5];
  private char[] returnString = new char[5];
  public string result;

  public Word(string init) 
  {
    answer = init.ToUpper();
  }

  private void CheckGreens(string guess) 
  {
    int i = 0;
    foreach (char c in guess.ToCharArray()) 
    {
      if (answer[i] == c) 
      {
        returnString[i] = 'G';
        guessCopy[i] = ' ';
      }
      i ++;
    }
  }

  ___ void ___(string guess)
  {
    int x;
    int i = 0;
    foreach (char c in guess.ToCharArray()) 
    {
      if (returnString[i] == 'G') 
      {
        i++;
        ___; // if its already green we don't do anything else
      } 
      x = Array.IndexOf(guessCopy, c);
      if (x != -1) // if its in the word
      {
        guessCopy[x] = ' ';
        returnString[i] = 'Y';
      } // yellow code logic which does not require changing
      i++;

    }
  }

  ___ void ___() 
  {
    for (int t = 0; t < ret.Length; t++)
    {
      if (returnString[t] != 'Y' && returnString[t] != 'G')
      {
        ___[t] = 'R'; // if its not yellow or green make it red
      }
    }
  }

  public string CompareStrings(string guess) 
  {
    guessCopy = answer.ToCharArray();
    returnString = new char[5];
    guess = guess.ToUpper();

    CheckGreens(guess);
    ___(guess); // check for yellow letters
    ___(); // fill the whitespaces with red

    return new string(___); // return the return string after doing the green and yellow check

  }

  public string endGame() 
  {
    string a = answer;
    answer = new string("");
    guessCopy = new char[5];
    returnString = new char[5];
    return a;
  }

}

public class Wordle 
{

  private static Word game;

  private static string[] words = {"ALERT","ARISE","ACTOR","ADULT","BOOST","BRAIN","BROWN","BUILT","CARRY","CHILD","CLOSE","COUNT","DANCE","DREAM","DRIVE","DRINK","EARLY","ENJOY","EMPTY","ENTER","FAULT","FIELD","FLASH","FLUID","GLOBE","GRAND","GREAT","GROSS","HAPPY","HOUSE","HUMAN","HEAVY","ISSUE","INPUT","INDEX","IMAGE","JUICE","JOINT","JELLY","JEANS","KNOWN","KNOCK","KNIFE","KILLS","LIGHT","LEVEL","LEAVE","LEARN","MIXER","MEALS","MARRY","MAGIC","NOVEL","NOISE","NEWLY","NIGHT","OUGHT","OTHER","ORDER","OFFER","PAINT","PAPER","ROUND","ROYAL","SHARE","SHARP","SHAPE","SCORE","TAKEN","TEACH","THANK","THICK","UPSET","USAGE","USUAL","UPPER","VALUE","VIDEO","VIRAL","VOICE","WORST","WHOLE","WORLD","WRONG","YOUTH","YEARS","YOUNG","YARDS","ZILLA","ZEROS"};

  public static string GenerateWord() 
  {

    var randomIndex = new Random().Next(0, words.Length);
    return words[randomIndex];

  }

  public ___ bool ValidateGuess(string g) // does this function need a specific object.
  {
    return !(Array.IndexOf(words, g.ToUpper()) == -1); // no need to change logic
  }

  public static void Main(string[] args)
  {
    string guess;
    string response;
    bool won = false;

    game = new Word(GenerateWord());
    Console.WriteLine("Enter Your Guesses: ");

    for (int i = 0; i <= 5; i++) 
    {


      guess = Console.ReadLine();

      while (!___(guess)) {
        Console.WriteLine(___); // add angry invalid guess message
        guess = Console.ReadLine();
      }

      response = game.CompareStrings(guess);
      Console.WriteLine(response);
      if (response == ___) { // what is the pattern we are looking for
        ___ = ___; // we won
        ___; // we dont want to play anymore so we need to exit the loop
      }

    }
    Console.WriteLine("Game over");
    if (won) {Console.WriteLine("Congratulations! You Guessed the word!");}
    else {Console.WriteLine($"You ran out of moves. The word was {game.endGame()}");}
  }

}
