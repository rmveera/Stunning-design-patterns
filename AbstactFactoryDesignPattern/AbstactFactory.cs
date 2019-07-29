using System;

namespace AbstactFactoryDesignPattern
{
    public class AbstactFactory
    {
    }

    internal class VehicleClient
    {
        private Bike bike;
        private Scooter scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }
    }
}