

// The class
// class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}

class ClassObject
{
    public static void Run()
    {
        Car c = new Car();
        c.brand = "AUDI, BMW";
        c.Show();
    }
}