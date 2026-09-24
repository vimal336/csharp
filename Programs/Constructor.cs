using System;

class Constructor
{
    // Constructor
    public Constructor()
    {
        Console.WriteLine("Constructor is called");
        consname = "new";
    }

    public static void Run()
    {
        //Creating an object calls the constructor automatically
        Constructor obj = new Constructor();
        Console.WriteLine(obj.consname);
    }
}