using System;

namespace FacadeDesignPattern
{
    internal class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    internal class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }

    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    internal class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }

    /// <summary>
    /// The 'Subsystem ClassD' class
    /// </summary>
    internal class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class CarFacade
    {
        private CarModel model;
        private CarEngine engine;
        private CarBody body;
        private CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}