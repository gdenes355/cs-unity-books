using System;

public class User
{
  public string name = "";
  public int year = 11;
  private int age = 0;

  public User(string myname, int myage)
  {
    name = myname;
    SetAge(myage);
    Console.WriteLine($"Created User called {name}");
  }

  public int GetAge()
  {
   return age;
  }

  private void SetAge(int myage) 
  {
    age = myage;
  }
    
}

public class School 
{
  public static void Main(string[] args)
  {
    User allan = new User("Allan", 15);
    User steve = new User("Steve", 16);
    Console.WriteLine($"{allan.name} is 15 years old");
    Console.WriteLine($"Steve is {steve.GetAge()} years old");
    allan.SetAge(40); // causes error CS0122
  }
}
