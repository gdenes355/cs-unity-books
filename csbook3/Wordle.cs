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

  private void CheckYellows(string guess)
  {
    int x;
    int i = 0;
    foreach (char c in guess.ToCharArray()) 
    {
      if (returnString[i] == 'G') {i++;continue;}
      x = Array.IndexOf(guessCopy, c);
      if (x != -1) 
      {
        guessCopy[x] = ' ';
        returnString[i] = 'Y';
      }
      i++;

    }
  }

  private void FillReds() 
  {
    for (int t = 0; t < ret.Length; t++)
    {
      if (returnString[t] != 'Y' && returnString[t] != 'G')
      {
        returnString[t] = 'R';
      }
    }
  }

  public string CompareStrings(string guess) 
  {
    guessCopy = answer.ToCharArray();
    returnString = new char[5];
    guess = guess.ToUpper();

    CheckGreens(guess);
    CheckYellows(guess);
    FillReds();

    return new string(ret);

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

      while (!ValidateGuess(guess)) {
        Console.WriteLine("Invalid Guess");
        guess = Console.ReadLine();
      }

      response = game.CompareStrings(guess);
      Console.WriteLine(response);
      if (response == "GGGGG") {
        //endgame
        won = true;
        break;
      }

    }
    Console.WriteLine("Game over");
    if (won) {Console.WriteLine("Congratulations! You Guessed the word!");}
    else {Console.WriteLine($"You ran out of moves. The word was {game.endGame()}");}
  }

  public static bool ValidateGuess(string g) 
  {
    return !(Array.IndexOf(words, g.ToUpper()) == -1);
  }

}
