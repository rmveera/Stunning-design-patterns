using System;
using System.Collections.Generic;
using System.Text;

public enum EVehicleType
{
    Bike,
    Car,
    Bus,
    Lorry,
    Scooter,
    Train,
    Ship,
    Helicopter
}

namespace FactoryDesignPattern
{
    public abstract class AFactory
    {
        public abstract IVehicleFactory GetVehicle(string type);

        public abstract IVehicleFactory GetVehicle(EVehicleType type);
    }

    public class Factory : AFactory
    {
        public override IVehicleFactory GetVehicle(string type)
        {
            IVehicleFactory product = null;

            return product;
        }

        public override IVehicleFactory GetVehicle(EVehicleType type)
        {
            IVehicleFactory ObjVehicleFactory = null;
            switch (type)
            {
                case EVehicleType.Bike:
                    ObjVehicleFactory = new Bike();
                    break;

                case EVehicleType.Scooter:
                    ObjVehicleFactory = new Scooter();
                    break;

                case EVehicleType.Car:
                    ObjVehicleFactory = new Car();
                    break;

                case EVehicleType.Bus:
                    ObjVehicleFactory = new Bus();
                    break;

                case EVehicleType.Lorry:
                    ObjVehicleFactory = new Lorry();
                    break;

                case EVehicleType.Train:
                    ObjVehicleFactory = new Train();
                    break;

                case EVehicleType.Ship:
                    ObjVehicleFactory = new Ship();
                    break;

                case EVehicleType.Helicopter:
                    ObjVehicleFactory = new Helicopter();
                    break;

                default:
                    break;
            }

            return ObjVehicleFactory;
        }
    }
}