using System;

public class Toaster
{
  public string brand;
  private ___ power_rating;
  ___ ___ ___;
  ___ ___[] slots = {"empty", "empty", "empty", "empty"};


  public Toaster(____________)
  {
    brand = ___;
    power_rating = ___;
    ___ = ___;
    PrintModel();
  }

  public void AddBread()
  {
    bool empty_space = false;
    ___ iter = 0;
    foreach (string bread in slots)
    {

      if (___ == "empty") {
        ___ = true;
        ___[___] = "bread";
        break;
      }
      ___ ++;
    }

    if (!empty_space) {
      Console.WriteLine("The toaster was full");
    } else {
      Console.WriteLine($"A slice of bread was added to the toaster.");
    }
  }


  ___ ___ ___() 
  {
    Console.___($"{colour} Toaster of brand {brand} has been created!");
  }

}

public class Kitchen 
{

  public static void Main(string[] args)
  {
    ___ ___ = ___ ___("BreadBurner", 1, "Red");

    //testing
    //see if it does what you expect

    MyToaster.AddBread();
    MyToaster.AddBread();
    MyToaster.AddBread();

  }


}
