using System;

public class Toaster
{
  public string brand;
  private int power_rating;
  private string colour;
  private string[] slots = {"empty", "empty", "empty", "empty"};


  public Toaster(string br, int pr, string col)
  {
    brand = br;
    power_rating = pr;
    colour = col;
    PrintModel();
  }

  public void AddBread()
  {
    bool empty_space = false;
    int iter = 0;
    foreach (string bread in slots)
    {

      if (bread == "empty") {
        empty_space = true;
        slots[iter] = "bread";
        break;
      }
      iter ++;
    }

    if (!empty_space) {
      Console.WriteLine("The toaster was full");
    } else {
      Console.WriteLine($"A slice of bread was added to the toaster.");
    }
  }

  ___ void RemoveBread()
  {
    bool hasBread = false;
    ___ b = "";
    int iter = 0;
    ___ (string bread in slots) // iterating through the array like in the AddBread function.
    {
     
      if (bread != "empty") {
        hasBread = true;
        b = slots[iter];
        slots[iter] = "empty";
        break;
      }
      iter ++;
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
    int iter = 0;

    foreach (string bread in slots)
    {
      if (bread != "empty") {
        currstate = Array.IndexOf(states, bread);

        currstate += power_rating;
        if (currstate > (states.Length - 1)) currstate = states.Length - 1;

        slots[iter] = states[currstate];
      }
      iter___;
    }
  }

  private void PrintModel() 
  {
    Console.WriteLine($"{colour} Toaster of brand {brand} has been created!");
  }

  public void ShowBreadSlots() {
    
    int iter = 1;
    foreach (string bread in slots)
    {
      if (___ == "empty") Console.WriteLine($"Slot {iter} is currently empty");
      else if (___ == "bread") Console.WriteLine($"Slot {iter} currently has un-toasted bread");
      else Console.WriteLine($"Slot {iter} has some {bread} toast");

      ___++;
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
