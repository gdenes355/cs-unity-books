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

  public void ___()
  {
    ___ ___ = ___;
    string b = "";
    ___ ___ = 0;
    ___ (___ ___ in ___)
    {
     
      if (___ != "empty") {
        ___ = true;
        b = slots[iter];
        slots[iter] = "___";
        ___;
      }
      iter ++;
    }

    if (!___) {
      Console.WriteLine("The toaster was empty");
    } ___ {
      Console.WriteLine($"A {b} piece of toast was removed.");
    }

  }
    
  ___ ___ Toast()
  {
    Console.WriteLine("The bread is being toasted!");
    ___[] states = {"bread", "warm", "crispy", "brown", "burnt", "black"};

    int ___;
    int iter = 0;

    ___ (___ ___ ___ ___)
    {
      if (bread != "empty") {
        ___ = Array.IndexOf(states, bread);

        ___ += power_rating;
        if (___ > (states.Length - 1)) ___ = states.Length - 1;

        slots[iter] = states[___];
      }
      
      iter___
    }
  }

  private void PrintModel() 
  {
    Console.WriteLine($"{colour} Toaster of brand {brand} has been created!");
  }

  public void ShowBreadSlots() {
    
    int ___ = 1;
    foreach (string bread in slots)
    {
      if (_________) Console.WriteLine($"Slot {iter} is currently empty");
      else if (_________) Console.WriteLine($"Slot {iter} currently has un-toasted bread");
      else Console.WriteLine($"Slot {iter} has some {bread} toast");

      ______;
    }

  }

}

public class Kitchen 
{

  public static void Main(string[] args)
  {
    Toaster MyToaster = new Toaster("BreadBurner", 3, "Red");

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
