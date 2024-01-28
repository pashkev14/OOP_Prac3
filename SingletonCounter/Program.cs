namespace SingletonCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                FirstClass first = new FirstClass();
                SecondClass second = new SecondClass();
                Console.WriteLine("First class count: " + first.Count());
                Console.WriteLine("Second class count: " + second.Count());
            }
        }
    }
}