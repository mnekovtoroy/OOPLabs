namespace Practic1
{
    public class WoodDuck : Duck
    {
        public WoodDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Silence();
            swimBehavior = new Float();
            Console.WriteLine("I'm WoodDuck");
        }
    }
}
