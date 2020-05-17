using System;

namespace Builder
{
    public class AndroidBuilder : ICellPhone
    {

        CellPhone cellPhone;

        public CellPhone CellPhone 
        { 
            get { return this.cellPhone; } 
        }

        public AndroidBuilder()
        {
            this.cellPhone = new CellPhone("Android");
        }

        public void BuildBattery()
        {
            this.cellPhone.Battery = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.cellPhone.Camera = "15 MP";
        }

        public void BuildOperationalSystem()
        {
            this.cellPhone.OperationaSystem = "Android 4.5";
        }

        public void BuildScreen()
        {
            this.cellPhone.Screen = "7 pol";
        }
    }
}
