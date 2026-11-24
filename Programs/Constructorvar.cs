using System;

class Constructorvar
{
    string name;
    int age;
    int mynum;

    // Parameterized constructor
    public Constructorvar(string n, int a)
    {
        name = n;
        age = a;
    }

    public static void Run()
    {
        Constructorvar obj = new Constructorvar("VimalS ", 7);

        Console.WriteLine(obj);
    }
}