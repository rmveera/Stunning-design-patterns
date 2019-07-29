using System;
using System.Collections.Generic;
using System.Text;

namespace AbstactFactoryDesignPattern
{
    public interface IVehicleFactory
    {
        Scooter GetScooter(string Bike);

        Bike GetBike(string Bike);

        Car GetCar(string Bike);
    }

    public class HondaFactory : IVehicleFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();

                case "Regular":
                    return new RegularBike();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new SportsScooter();

                case "Regular":
                    return new RegularScooter();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }
        }

        public Car GetCar(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new SportsCar();

                case "Regular":
                    return new RegularCar();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }
        }
    }

    public class HeroFactory : IVehicleFactory
    {
        public Bike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();

                case "Regular":
                    return new RegularBike();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Bike));
            }
        }

        public Scooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new SportsScooter();

                case "Regular":
                    return new RegularScooter();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }
        }

        public Car GetCar(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new SportsCar();

                case "Regular":
                    return new RegularCar();

                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }
        }
    }

    public interface Bike
    {
        string Name();
    }

    public interface Scooter
    {
        string Name();
    }

    public interface Car
    {
        string Name();
    }

    public class RegularBike : Bike
    {
        public string Name()
        {
            return "Regular bike";
        }
    }

    public class SportsBike : Bike
    {
        public string Name()
        {
            return "Sports bike";
        }
    }

    public class RegularScooter : Scooter
    {
        public string Name()
        {
            return "Regular scooter";
        }
    }

    public class SportsScooter : Scooter
    {
        public string Name()
        {
            return "Sports scooter";
        }
    }

    public class RegularCar : Car
    {
        public string Name()
        {
            return "Regular car";
        }
    }

    public class SportsCar : Car
    {
        public string Name()
        {
            return "Sports car";
        }
    }
}