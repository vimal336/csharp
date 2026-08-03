class Car
{
    public string brand;

    public void Show()
    {
        Console.WriteLine("Brandnam: " + brand);
    }
}

class ClassObject
{
    public static void Run()
    {
        Car c = new Car();
        c.brand = "AUD";
        c.Show();
    }
}