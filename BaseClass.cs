using System;


namespace Base
{
    class BaseClass
    {
        int a;
        public void fn1()
        {
            Console.WriteLine(this.ToString() + "this is fn1()");
        }
        public virtual void fn2()
        {
            Console.WriteLine(this.ToString() + "this is fn2()");
        }
    }
    class DerivedClass : BaseClass
    {
        int b;
        public void fn1()
        {
            Console.WriteLine(this.ToString() + "this is fn1()");
        }
        public override void fn2()
        {
            Console.WriteLine(this.ToString() + "this is fn2()");
        }
    }
}
