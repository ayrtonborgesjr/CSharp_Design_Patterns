using System;

namespace _04_Builder
{
    public class IPhoneBuilder : ICellPhone
    {
        CellPhone cellPhone;

        public CellPhone CellPhone
        {
            get { return this.cellPhone; }
        }

        public IPhoneBuilder()
        {
            this.cellPhone = new CellPhone("iPhone");
        }

        public void BuildBattery()
        {
            this.cellPhone.Battery = "MAH_1700";
        }

        public void BuildCamera()
        {
            this.cellPhone.Camera = "16 MP";
        }

        public void BuildOperationalSystem()
        {
            this.cellPhone.OperationaSystem = "iOS 11";
        }

        public void BuildScreen()
        {
            this.cellPhone.Screen = "9 pol";
        }
    }
}
