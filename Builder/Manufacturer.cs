using System;

namespace Builder
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
