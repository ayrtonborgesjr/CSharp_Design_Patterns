using System;

namespace Builder
{
    public interface ICellPhone
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOperationalSystem();
        void BuildCamera();
        CellPhone CellPhone { get; }


    }
}
