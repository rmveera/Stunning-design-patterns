using System;

namespace ChainOfResponsiblityDesignPattern
{
    public abstract class Handler
    {
        protected Handler _successor;

        public abstract void HandleRequest(int request);

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
                Console.WriteLine("Handled by ConcreteHandlerA");
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10)
                Console.WriteLine("Handled by ConcreteHandlerB");
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }
}