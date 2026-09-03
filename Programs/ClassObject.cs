// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 250;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine"This car is as fast as it can!";
  }
  public void halfThrottle()   // method
  {
    Console.WriteLine"This car is proper speed on !";
  }
}

class ClassObject
{
    public static void Run()
    {
        MyClass mycls = new MyClass();
        mycls = "bmw...";
        mycls.Show();
    }
}