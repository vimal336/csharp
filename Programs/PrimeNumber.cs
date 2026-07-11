class PrimeNumber
{
    public static void Run()
    {
        int n = 10;
        int count = 0;

        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                count++;
            }
        }

        if(count == 3)
        {
            Console.WriteLine("Prime number");
        }
        else
        {
            Console.WriteLine("Not a prime number");
        }
    }
}
