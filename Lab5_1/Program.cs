using System;                // Console
using System.IO;             // FileStream, FileReader

namespace Lab5_1
{
    class Program
    {
        static void Summarize(char[] contents)
        {
            int vowel_count = 0, consonants_count = 0, newline_count = 0;
            foreach(char c in contents)
            {
                if("AEIOUaeiou".IndexOf(c) != -1)
                {
                    vowel_count++;
                } else if("BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".IndexOf(c) != -1)
                {
                    consonants_count++;
                } else if(c == '\n')
                {
                    newline_count++;
                }
            }
            Console.WriteLine($"Total vowels: {vowel_count}");
            Console.WriteLine($"Total consonants: {consonants_count}");
            Console.WriteLine($"Total newline symbols: {newline_count}");
        }

        static void Main(string[] args)
        {
            try
            {
                string fileName = args[0];
                FileStream stream = new FileStream(fileName, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                
                //Console.WriteLine(args.Length);
                long filelength = stream.Length;
                Console.WriteLine(filelength);
                char[] contents = new char[filelength];
                for (int i = 0; i < contents.Length; i++)
                {
                    contents[i] = (char)reader.Read();
                }
                Summarize(contents);
                //foreach (char c in contents)
                //{
                //    Console.Write(c);
                //}
                //int argsCount = int.Parse(Console.ReadLine());
                //args = new string[argsCount];
                //for(int i = 0; i < argsCount; i++)
                //{
                //    args[i] = Console.ReadLine();
                //}
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                throw;
            }
        }
    }
}