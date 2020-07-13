using System;

namespace TemplateMethod
{
   abstract class AbstractClass
   {
       public abstract void PrimiriveOperation1();
       public abstract void PrimiriveOperation2();

       public void TemplateMethod()
       {
           PrimiriveOperation1();
           PrimiriveOperation2();
           Console.WriteLine("");
       }
   }

   class ConcreteClassA: AbstractClass
   {
       public override void PrimiriveOperation1()
       {
           Console.WriteLine("Method1 implementation of concrete class A");
       }
       public override void PrimiriveOperation2()
       {
           Console.WriteLine("Method2 implementation of concrete class A");
       }
   }

   class ConcreteClassB : AbstractClass
   {
       public override void PrimiriveOperation1()
       {
           Console.WriteLine("Method1 implementation of concrete class B");
       }
       public override void PrimiriveOperation2()
       {
           Console.WriteLine("Method2 implementation of concrete class B");
       }
   }


    //static void Main(string[] args)
    //{
    //    AbstractClass c;
    //    c = new ConcreteClassA();
    //    c.TemplateMethod();
    //    c = new ConcreteClassB();
    //    c.TemplateMethod();
    //    Console.Read();
    //}
}
