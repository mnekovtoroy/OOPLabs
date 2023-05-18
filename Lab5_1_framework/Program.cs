using System;                // Console
using System.IO;             // FileStream, FileReader

namespace Lab5_1_framework
{
    class Program
    {
        static void Summarize(char[] contents)
        {
            foreach (char c in contents)
            {
                if ("AEIOUaeiou".IndexOf(c) != -1)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            Console.WriteLine(args.Length);
            long filelength = stream.Length;
            char[] contents = new char[filelength];
            for (int i = 0; i < contents.Length; i++)
            {
                contents[i] = (char)reader.Read();
            }
            foreach (char c in contents)
            {
                Console.Write(c);
            }
            //int argsCount = int.Parse(Console.ReadLine());
            //args = new string[argsCount];
            //for(int i = 0; i < argsCount; i++)
            //{
            //    args[i] = Console.ReadLine();
            //}
        }
    }
}