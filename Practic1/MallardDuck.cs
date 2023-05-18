namespace Practic1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
            swimBehavior = new Swim();
            Console.WriteLine("I'm MallardDuck");
        }
    }
}
