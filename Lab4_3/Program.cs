using System;

namespace Lab4_3
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

        public static bool Factorial(int n, out int answer)
        {
            answer = 1;
            for (int i = 2; i <= n; ++i)
                answer *= i;
            return true;
        }

        public static bool RecursiveFactorial(int n, out int answer)
        {
            if (n < 1)
            {
                answer = 1;
                return true;
            }
            RecursiveFactorial(n - 1, out answer);
            answer *= n;
            return true;
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
            int factorial;
            Utils.Factorial(y, out factorial);
            Console.WriteLine("Factorial of {0} is {1}", y, factorial);
            Utils.Factorial(y, out factorial);
            Console.WriteLine("Recursive factorial of {0} is {1}", y, factorial);
        }
    }

}