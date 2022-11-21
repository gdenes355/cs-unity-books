using System;

___ ___ ___
{
  ___ string name = "";
  public int year = 11;
  private int age = 0;

  public ___(___ myname, ___ myage) // Constructor
  {
    name = myname;
    SetAge(___);
    Console.WriteLine($"Created User called {name}");
  }

  ___ ___ GetAgeOfStudent()
  {
   ___ age;
  }

  ___ void SetAge(int myage) 
  {
    ___ = myage;
  }
    
}

public class School 
{
  public static void Main(string[] args)
  {
    User allan = new User("Allan", 15);
    User steve = new User("Steve", 16);
    Console.WriteLine($"{allan.name} is 15 years old");
    Console.WriteLine($"Steve is {steve.GetAgeOfStudent()} years old");
    allan.SetAge(40); // should cause error CS0122
  }
}
