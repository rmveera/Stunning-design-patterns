using System;

namespace TemplateMethodDesignPattern
{
    public abstract class Template
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        public abstract void Step1();

        public abstract void Step2();

        public abstract void Step3();
    }

    public class ConcreteClassA : Template
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class A, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class A, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class A, Step 3");
        }
    }

    public class ConcreteClassB : Template
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class B, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class B, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class B, Step 3");
        }
    }
}