using System;
using System.Collections.Generic;

namespace VisitorDesignPattern
{
    public class ObjectStructure
    {
        public List<IVisitor> Elements { get; private set; }

        public ObjectStructure()
        {
            Elements = new List<IVisitor>();
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Element element in Elements)
            {
                element.Accept(visitor);
            }
        }
    }

    public interface Element
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteElementA : Element
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string Name { get; set; }
    }

    public class ConcreteElementB : Element
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string Title { get; set; }
    }

    public interface IVisitor
    {
        void Visit(ConcreteElementA element);

        void Visit(ConcreteElementB element);
    }

    public class ConcreteVisitorA : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorA visited ElementA : {0}", element.Name);
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorA visited ElementB : {0}", element.Title);
        }
    }

    public class ConcreteVisitorB : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorB visited ElementA : {0}", element.Name);
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorB visited ElementB : {0}", element.Title);
        }
    }
}