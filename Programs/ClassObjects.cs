class Car
{
    public string brand;

    public void Show()
    {
        Console.WriteLine("Brand: " + brand);
    }
}

class classObject
{
    public static void Run()
    {
        Car c = new Car();
        c.brand = "BMW";
        c.Show();
    }
}