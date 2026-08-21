// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 250;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("This car  as fast as it can!");
  }
}

class ClassObject
{
    public static void Run()
    {
        MyClass mycls = new MyClass();
        mycls = "aaudi";
        mycls.Show();
    }
}