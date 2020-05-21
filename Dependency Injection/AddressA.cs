namespace Dependency_Injection
{
    public class AddressA : IAddressObject
    {
        public string Street { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return this.Street + ", " + Number;
        }
    }
}