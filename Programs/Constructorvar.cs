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
        Constructorvar obj = new Constructorvar("Vimal ", 2);

        Console.WriteLine(obj.name);
        Console.WriteLine(obj);
        Console.WriteLine(obj.age);
    }
}