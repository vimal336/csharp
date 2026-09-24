using System;

class Constructor
{
    // Constructor
    public Constructor()
    {
        Console.WriteLine("Constructor is called");
    }

    public static void Run()
    {
        //Creating an object calls the constructor automatically
        Constructor obj = new Constructor();
    }
}