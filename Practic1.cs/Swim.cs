using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1.cs
{
    public class Swim : SwimBehavior
    {
        void SwimBehavior.Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
