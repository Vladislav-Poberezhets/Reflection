using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssembly
{
    public class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyClass(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int MyMethod(int count, string text)
        {
            Console.WriteLine("This is a normal method.");
            Console.WriteLine("Count: {0}", count);
            Console.WriteLine("Text: {0}", text);

            return X + Y;
        }

        public static void StaticMethod(int count, float radius)
        {
            Console.WriteLine("This is a static method call.");
            Console.WriteLine("Count: {0}", count);
            Console.WriteLine("Radius: {0}", radius);
        }
    }
}
