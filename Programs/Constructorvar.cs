using System;

class Constructorvar
{
    string name;
    int age;

    // Parameterized constructor
    public Constructor(string n, int a)
    {
        name = n;
        age = a;
    }

    public static void Run()
    {
        Constructor obj = new Constructor("Vimal", 25);

        Console.WriteLine(obj.name);
        Console.WriteLine(obj.age);
    }
}