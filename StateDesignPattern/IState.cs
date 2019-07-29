using System;

namespace StateDesignPattern
{
    public class Context
    {
        private IState state;

        public Context(IState newstate)
        {
            state = newstate;
        }

        public void Request()
        {
            state.Handle(this);
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }
    }

    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handle called from ConcreteStateA");
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handle called from ConcreteStateB");
            context.State = new ConcreteStateA();
        }
    }
}