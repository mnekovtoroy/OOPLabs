namespace Practic1
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
            swimBehavior = new Float();
            Console.WriteLine("I'm RubberDuck");
        }
    }
}
