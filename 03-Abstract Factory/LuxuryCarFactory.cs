using System;

namespace _03_Abstract_Factory
{
    public class LuxuryCarFactory : CarFactory
    {
        public override Stereo AssembleStereo()
        {
            return new BluetoothPlayer();
        }

        public override Wheel AssembleWheeel()
        {
            return new AlloyWheel();
        }
    }
}
