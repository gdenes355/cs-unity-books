using System;

public class Toaster
{
  public string brand;
  private int powerRating;
  private string colour;
  private string[] slots = {"empty", "empty", "empty", "empty"};


  public Toaster(string br, int pr, string col)
  {
    brand = br;
    powerRating = pr;
    colour = col;
    PrintModel();
  }

  public void AddBread()
  {
    bool emptySpace = false;
    for (int i = 0; i < slots.Length; i++)
    {    
      if (slots[i] == "empty") {
        emptySpace = true;
        slots[i] = "bread"; // change the value in the slots array to now contain bread
        break;
      }
    }

    if (!emptySpace) {
      Console.WriteLine("The toaster was full");
    } else {
      Console.WriteLine($"A slice of bread was added to the toaster.");
    }
  }

  ___ void RemoveBread()
  {
    bool hasBread = false;
    ___ b = "";
    ___ (int i = 0; i < slots.Length; i++)  // iterating through the array like in the AddBread function.
    {
      if (slots[i] != "empty") {
        hasBread = true;
        b = slots[i];
        slots[i] = "empty";
        break;
      }
    }

    if (!hasBread) {
      Console.WriteLine("The toaster was empty");
    } else {
      Console.WriteLine($"A {b} piece of toast was removed.");
    }

  }
    
  ___ void Toast()
  {
    Console.WriteLine("The bread is being toasted!");
    ___[] states = {"bread", "warm", "crispy", "brown", "burnt", "black"}; // making a string array

    int currstate;
    for (int i = 0; i < slots.Length; i++)
    {
      if (_______ != "empty") {
        currstate = Array.IndexOf(states, slots[i]);

        currstate += powerRating;
        if (currstate > (states.Length - 1)) currstate = states.Length - 1;

        slots[iter] = states[currstate];
      }
    }
  }

  private void PrintModel() 
  {
    Console.WriteLine($"{colour} Toaster of brand {brand} has been created!");
  }

  public void ShowBreadSlots() 
  {
    for (int i = 0; i < slots.Length; i++)
    {
      if (___ == "empty") Console.WriteLine($"Slot {i} is currently empty");
      else if (___ == "bread") Console.WriteLine($"Slot {i} currently has un-toasted bread");
      else Console.WriteLine($"Slot {i} has some {_______} toast");
    }
  }

}

public class Kitchen 
{

  public static void Main(string[] args)
  {
    ___ MyToaster = ___ ___("BreadBurner", 3, "Red");

    //testing
    //see if it does what you expect

    MyToaster.AddBread();
    MyToaster.AddBread();
    MyToaster.AddBread();

    MyToaster.ShowBreadSlots();

    MyToaster.Toast();

    MyToaster.ShowBreadSlots();

    MyToaster.AddBread();
    MyToaster.RemoveBread();
    MyToaster.Toast();

    MyToaster.ShowBreadSlots();
  }


}
