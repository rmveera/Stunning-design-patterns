using System;

namespace CommandDesignPattern
{
    public class Client
    {
        public void RunCommand()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            command.Parameter = "Dot Net Tricks !!";
            invoker.Command = command;
            invoker.ExecuteCommand();
        }
    }

    public class Receiver
    {
        public void Action(string message)
        {
            Console.WriteLine("Action called with message: {0}", message);
        }
    }

    public class Invoker
    {
        public ICommandDp Command { get; set; }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }

    public interface ICommandDp
    {
        void Execute();
    }

    public class ConcreteCommand : ICommandDp
    {
        protected Receiver _receiver;
        public string Parameter { get; set; }

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action(Parameter);
        }
    }
}