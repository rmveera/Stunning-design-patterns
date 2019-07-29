using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public interface IShape
    {
        void Print();
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }

    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class ShapeObjectFactory
    {
        private Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;
            if (shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;

                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;

                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}