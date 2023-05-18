namespace Lab5_2
{
    static class MatrixMultiply
    {
        public static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];

            Console.WriteLine("Enter first matrix: ");
            string[] input = Console.ReadLine().Split(' ');
            a[0, 0] = int.Parse(input[0]);
            a[0, 1] = int.Parse(input[1]);
            input = Console.ReadLine().Split(' ');
            a[1, 0] = int.Parse(input[0]);
            a[1, 1] = int.Parse(input[1]);

            Console.WriteLine("Enter second matrix: ");
            input = Console.ReadLine().Split(' ');
            b[0, 0] = int.Parse(input[0]);
            b[0, 1] = int.Parse(input[1]);
            input = Console.ReadLine().Split(' ');
            b[1, 0] = int.Parse(input[0]);
            b[1, 1] = int.Parse(input[1]);

            int[,] result = MatrixMultiply.Multiply(a,b);

            Console.WriteLine($"Result:\n{result[0, 0]} {result[0, 1]}\n{result[1, 0]} {result[1, 1]}");
        }
    }
}