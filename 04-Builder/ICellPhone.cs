using System;

namespace _04_Builder
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
