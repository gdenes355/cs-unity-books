using System;
using System.Collections.Generic;
public class Computer
{
  //properties
  //HINT make an array for file names and another array for their content
  private Dictionary<string, string> Files = new Dictionary<int, string>();
  //like a python dictionary you can add an element with the KEY and a VALUE
  //You can refer to this source https://www.tutorialsteacher.com/csharp/csharp-dictionary

  public Computer()
  {
    //constructor code
  }

  //functions
  public void TurnOn() 
  {

  }
  public void TurnOff() 
  {

  }
  public void CreateFile(string filename, string text) 
  {
    // add an element to a dictionary with the KEY as the file name and VALUE has the content
  }

  public void ReadFile() 
  {

  }
  public void WriteFile() 
  {

  }
  public void SaveFile() 
  {

  }

}

public class ICT2 
{

  public static void Main(string[] args)
  {
    Computer comp = new Computer("Microsoft", 1);
    Computer comp2 = new Computer("Microsoft", 2);

    comp.TurnOn();
    comp.ReadFile("test.txt"); //should give file not made error
    comp.CreateFile("test.txt");
    comp.ReadFile("test.txt"); //should say the file is empty

    comp.WriteFile("test.txt", "This is a test message");
    comp.TurnOff();
    comp.TurnOn();
    comp.ReadFile("test.txt"); 
    //should say the file is empty because was not saved before turning off


    comp2.TurnOn();
    comp2.CreateFile("test2.txt");
    comp2.WriteFile("test.txt", "This should be saved."); // should give a file not found error message
    comp2.WriteFile("test2.txt", "This should be saved.");
    comp2.SaveFile("test2.txt");
    
    comp2.TurnOff();
    comp2.TurnOn();
    comp2.ReadFile("test2.txt"); //should print "This should be saved."

    
  }

}
