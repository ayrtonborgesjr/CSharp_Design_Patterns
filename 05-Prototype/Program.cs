using System;

namespace _05_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype!");
            Console.WriteLine();

            RegularEmployee regEmp = new RegularEmployee() 
            {
                Name = "Bob",
                Age = 25,
                Type = "Regular"
            };

            Console.WriteLine("Regular Employee:");
            Console.WriteLine(regEmp.ToString());

            Console.WriteLine();

            RegularEmployee regEmpCloned = (RegularEmployee)regEmp.Clone();
            Console.WriteLine("Regular Employee cloned:");
            regEmpCloned.Name = "Jackson";
            regEmpCloned.Age = 40;
            Console.WriteLine(regEmpCloned.ToString());

            Console.WriteLine();

            Console.WriteLine("Regular Employee information after he has been cloned:");
            Console.WriteLine(regEmp.ToString());


            Console.ReadKey();
        }
    }
}
