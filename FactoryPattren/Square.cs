using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing square");
        }

        public void SayHi()
        {
            Console.WriteLine("Hi i'm square");
        }
    }
}
