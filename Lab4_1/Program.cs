using System;

namespace Lab4_1
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            return a > b ? a : b;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            int x, y, greater;
            Console.WriteLine("Enter two numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater one is: {0}", greater);
        }
    }

}