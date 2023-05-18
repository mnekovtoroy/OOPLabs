using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1.cs
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
