using FactoryDesignPattern;
using AbstactFactoryDesignPattern;
using FlyweightDesignPattern;
using System;
using AdapterDesignPattern;
using SingletonDesignPattern;
using PrototypeDesignPattern;
using BuilderDesignPattern;
using BridgeDesignPattern;
using CompositeDesignPattern;
using DecoratorDesignPattern;
using FacadeDesignPattern;
using ProxyDesignPattern;
using ChainOfResponsiblityDesignPattern;
using CommandDesignPattern;

namespace Designpaterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region AbstactFactoryDesignPattern

            /* Factory factory = new Factory();
             IVehicleFactory bike = factory.GetVehicle(EVehicleType.Bike);
             bike.Drive();
             IVehicleFactory scooter = factory.GetVehicle(EVehicleType.Scooter);
             scooter.Drive();
             IVehicleFactory car = factory.GetVehicle(EVehicleType.Car);
             car.Drive();
             IVehicleFactory bus = factory.GetVehicle(EVehicleType.Bus);
             bus.Drive();
             IVehicleFactory lorry = factory.GetVehicle(EVehicleType.Lorry);
             lorry.Drive();
             IVehicleFactory train = factory.GetVehicle(EVehicleType.Train);
             train.Drive();
             IVehicleFactory ship = factory.GetVehicle(EVehicleType.Ship);
             ship.Drive();
             IVehicleFactory helicopter = factory.GetVehicle(EVehicleType.Helicopter);
             helicopter.Drive();
             */

            #endregion AbstactFactoryDesignPattern

            #region Adapter

            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            #endregion Adapter

            #region Bridge

            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "I hope you are well";

            usermsg.MessageSender = email;
            usermsg.Send();

            #endregion Bridge

            #region Builder

            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            #endregion Builder

            #region ChainOfResponsiblity

            Approver rohit = new Clerk();
            Approver rahul = new AssistantManager();
            Approver manoj = new Manager();

            rohit.Successor = rahul;
            rahul.Successor = manoj;

            // Generate and process loan requests
            var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
            rohit.ProcessRequest(loan);

            loan = new Loan { Number = 2035, Amount = 42000.10, Purpose = "Bike Loan" };
            rohit.ProcessRequest(loan);

            loan = new Loan { Number = 2036, Amount = 156200.00, Purpose = "House Loan" };
            rohit.ProcessRequest(loan);

            #endregion ChainOfResponsiblity

            #region Command

            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();
            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            if (cmd == "ON")
            {
                s.StoreAndExecute(switchUp);
            }
            else if (cmd == "OFF")
            {
                s.StoreAndExecute(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }

            #endregion Command

            #region Composite

            Employee Rahul = new Employee { EmpID = 1, Name = "Rahul" };

            Employee Amit = new Employee { EmpID = 2, Name = "Amit" };
            Employee Mohan = new Employee { EmpID = 3, Name = "Mohan" };

            Rahul.AddSubordinate(Amit);
            Rahul.AddSubordinate(Mohan);

            Employee Rita = new Employee { EmpID = 4, Name = "Rita" };
            Employee Hari = new Employee { EmpID = 5, Name = "Hari" };

            Amit.AddSubordinate(Rita);
            Amit.AddSubordinate(Hari);

            Employee Kamal = new Employee { EmpID = 6, Name = "Kamal" };
            Employee Raj = new Employee { EmpID = 7, Name = "Raj" };

            Contractor Sam = new Contractor { EmpID = 8, Name = "Sam" };
            Contractor tim = new Contractor { EmpID = 9, Name = "Tim" };

            Mohan.AddSubordinate(Kamal);
            Mohan.AddSubordinate(Raj);
            Mohan.AddSubordinate(Sam);
            Mohan.AddSubordinate(tim);

            Console.WriteLine("EmpID={0}, Name={1}", Rahul.EmpID, Rahul.Name);

            foreach (Employee manager in Rahul)
            {
                Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);

                foreach (var employee in manager)
                {
                    Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                }
            }

            #endregion Composite

            #region Decorator

            HondaCity car = new HondaCity();
            Console.WriteLine("Honda City base price are : {0}", car.Price);
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";

            Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.Price, offer.Offer);

            #endregion Decorator

            #region Facade

            CarFacade facade = new CarFacade();
            facade.CreateCompleteCar();

            #endregion Facade

            #region Flyweight

            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            int NumObjs = sof.TotalObjectsCreated;
            Console.WriteLine("\nTotal No of Objects created = {0}", NumObjs);

            #endregion Flyweight

            #region FactoryDesignPattern

            Factory factory = new Factory();
            FactoryDesignPattern.IVehicleFactory bike = factory.GetVehicle(EVehicleType.Bike);
            bike.Drive();
            FactoryDesignPattern.IVehicleFactory scooter = factory.GetVehicle(EVehicleType.Scooter);
            scooter.Drive();
            FactoryDesignPattern.IVehicleFactory fcar = factory.GetVehicle(EVehicleType.Car);
            fcar.Drive();
            FactoryDesignPattern.IVehicleFactory bus = factory.GetVehicle(EVehicleType.Bus);
            bus.Drive();
            FactoryDesignPattern.IVehicleFactory lorry = factory.GetVehicle(EVehicleType.Lorry);
            lorry.Drive();
            FactoryDesignPattern.IVehicleFactory train = factory.GetVehicle(EVehicleType.Train);
            train.Drive();
            FactoryDesignPattern.IVehicleFactory ship = factory.GetVehicle(EVehicleType.Ship);
            ship.Drive();
            FactoryDesignPattern.IVehicleFactory helicopter = factory.GetVehicle(EVehicleType.Helicopter);
            helicopter.Drive();

            #endregion FactoryDesignPattern

            #region Prototype

            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            #endregion Prototype

            #region Proxy

            ProxyClient proxy = new ProxyClient();
            Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());

            #endregion Proxy

            #region Singleton

            EagerSingleton.Instance.Show();
            LazySingleton.Instance.Show();
            Singleton.Instance.Show();

            #endregion Singleton

            Console.ReadKey();
        }
    }
}