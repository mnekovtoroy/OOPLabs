using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1.cs
{
    public class Silence : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...silence...");
        }
    }
}
