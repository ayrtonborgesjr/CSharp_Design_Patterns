using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection");
            Console.WriteLine();

            AddressA addressA = new AddressA();
            addressA.Number = 15010;
            addressA.Street = "36th Street - Building 92";

            AddressB addressB = new AddressB();
            addressB.City = "Redmond";
            addressB.State = "Washington";


            Company company1 = new Company();
            company1.Id = 1;
            company1.Name = "Microsoft Corporation";
            company1.Address = addressA;
            
            Company company2 = new Company();
            company2.Id = 2;
            company2.Name = "Microsoft Corporation";
            company2.Address = addressB;

            Console.WriteLine("Company 1: " + company1.ToString());
            Console.WriteLine("Company 2: " + company2.ToString());

            Console.ReadKey();
        }
    }
}
