namespace Utils
{
    using System;

    public class Test
    {
        public static void Main() 
        {
           string s = Console.ReadLine();
	       Utils.Reverse(ref s);
	       Console.WriteLine(s);
        }
    }
}
