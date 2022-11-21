using System;

public class ___
{
  public string name;
  ___ int ___;
  ___ int ___;


  public ___(___ ___, ___ w, ___ h)
  {
    ___ = ___;
    ___ = w;
    ___ = h;
    // Your constructor code goes here
  }

  public int ___()
  {
   _________
  }
    
}

public class Building 
{

  public static float TotalFloorPlan;

  public static void Main(string[] args)
  {
    
    ___ kitchen = ___ ___("Kitchen", 8, 5);
    ___ dining = ___ ___("Dining Room", 5, 7);
    ___ living = ___ ___("Living Room", 15, 15);
    ___ bedroom = ___ ___("Bedroom", 12, 4);

    AddArea(kitchen);
    AddArea(dining);
    AddArea(living);
    AddArea(bedroom);

    Console.WriteLine(TotalFloorPlan);

  }

  public static void AddArea(Room room) 
  {
    TotalFloorPlan = TotalFloorPlan + room.GetArea();
  }

}
