using System;

namespace Lab1_Divider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string temp1, temp2;
            Console.WriteLine("Enter first number: ");
            temp1 = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            temp2 = Console.ReadLine();
            try
            {
                i = int.Parse(temp1);
                j = int.Parse(temp2);
                int k = i / j;
                Console.WriteLine($"The first number divided by the second number equals to {k}");
            }
            catch (Exception)// Исключение при делении на 0
            {
                Console.WriteLine("Illigal arguments: division by 0");
                return;
            }
            catch (FormatException)// Исключение при некорректном вводе
            {
                Console.WriteLine("Illigal arguments: not an integer number");
            }
            catch (OverflowException)//Исключение при вводе числа, превышающего размеры типа int
            {
                Console.WriteLine("Illigal arguments: outside of an Int32 value");
            }
        }
    }
}