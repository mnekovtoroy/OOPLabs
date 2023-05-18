using System;

namespace Lab4_2
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            return a > b ? a : b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
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
            Console.WriteLine("Original values are x: {0}, y: {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("Swapped values are x: {0}, y: {1}", x, y);
        }
    }
}
