using System;

class Car
{
  public string model;
  public string color;
  public int year;

  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }

  // Problem 1: Method with No Parameters
  public void Start()
  {
    Console.WriteLine("The car is starting.");
  }

  // Problem 2: Method with Parameters
  public void Drive(int miles)
  {
    Console.WriteLine("The car drove " + miles + " miles.");
  }

  // Problem 3: Method with Return Value
  public string GetDescription()
  {
    return year + " " + color + " " + model;
  }

  // Problem 4: Method that Updates a Field
  public void Repaint(string newColor)
  {
    color = newColor;
    Console.WriteLine("The car has been repainted to " + color + ".");
  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display();      // Call Display
    myCar.Start();         // Call Start
    myCar.Drive(50);       // Call Drive(50)

    string description = myCar.GetDescription(); // Call GetDescription
    Console.WriteLine(description);

    myCar.Repaint("red");  // Call Repaint("red")
  }
}
