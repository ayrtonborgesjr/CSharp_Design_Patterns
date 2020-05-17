using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder!");

            // Create Manufacturer
            Manufacturer manufacturer = new Manufacturer();

            // Allows the Builder class to be ready
            ICellPhone celluarBuild = null;
            // Let's create a Android cellphone
            celluarBuild = new IPhoneBuilder(); //AndroidBuilder(); 
            manufacturer.Constructor(celluarBuild);
            Console.WriteLine("A new cell phone was built by: {0}", celluarBuild.CellPhone.Name);
            Console.WriteLine("Camera: {0}", celluarBuild.CellPhone.Camera);
            Console.WriteLine("OS: {0}", celluarBuild.CellPhone.OperationaSystem);
            Console.WriteLine("Screen: {0}", celluarBuild.CellPhone.Screen);
            Console.WriteLine("Batrery: {0}", celluarBuild.CellPhone.Battery);

            Console.ReadKey();
        }
    }
}
