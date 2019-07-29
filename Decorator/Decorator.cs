﻿using System;

namespace DecoratorDesignPattern
{
    public interface Component
    {
        void Operation();
    }

    public class ConcreteComponent : Component
    {
        public void Operation()
        {
            Console.WriteLine("Component Operation");
        }
    }

    public abstract class Decorator : Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public virtual void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Override Decorator Operation");
        }
    }
}