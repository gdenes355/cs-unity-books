using System;

public class Toaster
{
  public string brand;
  private ___ powerRating;
  ___ string colour;
  ___ ___[] slots = {"empty", "empty", "empty", "empty"};


  public Toaster(____________)
  {
    brand = ___;
    powerRating = ___;
    ___ = ___;
    PrintModel();
  }

  public void AddBread()
  {
    bool emptySpace = false;
    int iter = 0;
    foreach (string bread in slots)
    {

      if (bread == "empty") {
        emptySpace = true;
        ___[i] = "bread"; // change the value in the slots array to now contain bread
        break;
      }
      iter ++;
    }

    if (!emptySpace) {
      Console.WriteLine("The toaster was full");
    } else {
      Console.WriteLine($"A slice of bread was added to the toaster.");
    }
  }


  ___ void PrintModel() 
  {
    Console.___($"{colour} Toaster of brand {brand} has been created!");
  }

}

public class Kitchen 
{

  ___ ___ ___ ___(___[] ___) // This is our Main function
  {
    Toaster MyToaster = new ___("BreadBurner", 1, "Red");

    //testing
    //see if it does what you expect

    MyToaster.AddBread();
    MyToaster.AddBread();
    MyToaster.AddBread();

  }


}
