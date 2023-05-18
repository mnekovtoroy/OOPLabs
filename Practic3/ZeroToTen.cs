namespace Practic3
{
    public class ZeroToTen
    {
        private static int name = 0;

        public ZeroToTen()
        {
            //Console.WriteLine(n);
            name++;
        }

        public static string getName { get { return name.ToString(); } }
    }
}
