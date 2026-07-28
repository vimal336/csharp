class Car
{
    public string brand;

    public void Show()
    {
        Console.WriteLine("Brand: " + brand);
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.brand = "Audi";
        c.Show();
    }
}