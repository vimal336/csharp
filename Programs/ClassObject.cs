// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 240;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}

class ClassObject
{
    public static void Run()
    {
        MyClass mycls = new MyClass();
        mycls = "AUDI, BMW";
        mycls.Show();
    }
}