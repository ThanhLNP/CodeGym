using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class ArrayOfObjectsTable
    {
        static void Main()
        {
            A a = new A();
            a.someMethod();

            B b = new B();
            b.someMethod();

            C c = new C();
            c.someMethod();

        }
    }
    public class A
    {
        public virtual void someMethod()
        {
            Console.WriteLine("a");
        }
    }

    public class B : A
    {
        public sealed override void someMethod()
        {
            Console.WriteLine("b");
        }
    }
    public class C : B
    {

    }
}
