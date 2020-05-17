using System;

namespace Abstract_Factory
{
    public abstract class CarFactory
    {
        public abstract Wheel AssembleWheeel();
        public abstract Stereo AssembleStereo();
    }
}
