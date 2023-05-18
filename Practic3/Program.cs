namespace Practic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FirstClass first = new FirstClass();
            SecondClass second = new SecondClass();
            Console.WriteLine("Singleton mame in FirstClass: " + first.GetName());
            Console.WriteLine("Singleton mame in SecondClass: " + second.GetName());*/
            Console.WriteLine("Non-singleton implementation:");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(ZeroToTen.getName);
                var temp = new ZeroToTen();
            }
            Console.WriteLine("Singleton implementation:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(ZeroToTenSingleton.getName);
                var temp = ZeroToTenSingleton.Instance;
            }
        }
    }
}