using System;

namespace Abstract_Factory
{
    public class RunAbstractFactory
    {
        public static Car AsselbleCar(string type)
        {
            CarFactory carFactory = null;

            switch (type)
            {
                case "lux":
                    carFactory = new LuxuryCarFactory();
                    break;

                case "popular":
                    carFactory = new PopularCarFactory();
                    break;

                default:
                    break;
            }

            Car car = new Car();
            
            car.Wheel = carFactory.AssembleWheeel();
            
            car.Stereo = carFactory.AssembleStereo();

            return car;
        }
    }
}
