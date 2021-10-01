using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Circle : Shapes  // Derived class (child) 
    {
        public new void draw()
        {
            Console.WriteLine("This Draws a Circle");
        }
        public new void erase()
        {
            Console.WriteLine("This Erases a Circle");
        }
    }
}
