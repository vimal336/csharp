class Car
{
    public string brand;

    public void Show()
    {
        Console.WriteLine("Brandname: " + brand);
    }
}

class ClassObject
{
    public static void Run()
    {
        Car c = new Car();
        c.brand = "AUDI, BMW";
        c.Show();
    }
}