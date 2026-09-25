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
        Constructorvar obj = new Constructorvar("Vimal", 27);

        Console.WriteLine(obj.name);
        Console.WriteLine(obj.age);
    }
}