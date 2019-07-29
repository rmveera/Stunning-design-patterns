using System;

namespace FactoryDesignPattern
{
    public interface IVehicleFactory
    {
        void Drive();
    }

    public class Bike : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Bike is Driven");
        }
    }

    public class Scooter : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Scooter is Driven");
        }
    }

    public class Car : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driven");
        }
    }

    public class Bus : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Bus is Driven");
        }
    }

    public class Lorry : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Lorry is Driven");
        }
    }

    public class Train : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Train is Driven");
        }
    }

    public class Ship : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Ship is Driven");
        }
    }

    public class Helicopter : IVehicleFactory
    {
        public void Drive()
        {
            Console.WriteLine("Helicopter is Driven");
        }
    }
}