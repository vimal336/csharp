using System;

class Constructorvar
{
    string name;
    int age;

    // Parameterized constructor
    public Constructorvar(string n, int a)
    {
        name = n;
        age = a;
    }

    public static void Run()
    {
        Constructorvar obj = new Constructorvar("VimalS ", 4);

        Console.WriteLine(obj);
    }
}