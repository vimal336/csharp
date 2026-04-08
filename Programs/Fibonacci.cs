class Fibonacci
{
    public static void Run()
    {
        int n = 5; // how many numbers to print

        int a = 0;
        int b = 1;

        Console.Write(a + " " + b + " ");

        for(int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");

            a = b;
            b = c;
        }
    }
}
