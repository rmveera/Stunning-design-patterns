using System;

namespace PrototypeDesignPattern
{
    public interface Prototype
    {
        Prototype Clone();
    }

    public class ConcretePrototypeA : Prototype
    {
        public Prototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }

    public class ConcretePrototypeB : Prototype
    {
        public Prototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (Prototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }
}