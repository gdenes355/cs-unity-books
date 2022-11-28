using System;


___ ___ ___ // defining the Word class
{

  ___ string answer;
  ___ char[] guessCopy = new char[5];
  ___ char[] returnString = new char[5];
  // do we want the answer and the arrays used for testing the user's guess to be public or private?
  public string result;

  public ___(string init) //constructor
  {
    answer = init.ToUpper();
  }

  ___ void CheckGreens(string guess) //should this function be private or public
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

  public ___ CompareStrings(string guess) 
  {
    guessCopy = answer.ToCharArray();
    returnString = new char[5];
    guess = guess.___; // capitalize the user guess before checking using .ToUpper

    CheckGreens(guess);

    return new string(returnString);

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

  ___ ___ string GenerateWord() // should this function be public/private and does it need an object?
  {

    var randomIndex = new Random().Next(0, words.Length);
    return words[randomIndex];

  }

  public static void Main(string[] args)
  {
    string guess;
    string response;
    bool won = false;

    game = ___ Word(GenerateWord());
    Console.WriteLine("Enter Your Guesses: ");

    for (int i = 0; i <= 5; i++) // same as for i in range(5) in python
    {


      ___ = Console.___(); // reading the user input as a guess

      response = game.CompareStrings(guess);
      Console.WriteLine(___); // log the response

    }
    Console.WriteLine("Game over");
    if (won) {Console.WriteLine("Congratulations! You Guessed the word!");}
    else {Console.WriteLine($"You ran out of moves. The word was {game.endGame()}");}

  }

}
