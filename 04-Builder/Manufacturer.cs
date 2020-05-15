using System;

namespace _04_Builder
{
    public class Manufacturer
    {
        public void Constructor (ICellPhone celularBuilder)
        {
            celularBuilder.BuildBattery();
            celularBuilder.BuildCamera();
            celularBuilder.BuildOperationalSystem();
            celularBuilder.BuildScreen();
        }
    }
}
