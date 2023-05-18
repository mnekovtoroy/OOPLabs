namespace Practic1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
            Console.WriteLine();
            Duck wood = new WoodDuck();
            wood.PerformFly();
            wood.PerformQuack();
            Console.WriteLine();
            Duck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();
        }
    }
}