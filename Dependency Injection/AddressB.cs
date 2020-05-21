namespace Dependency_Injection
{
    public class AddressB : IAddressObject
    {
        public string City { get; set; }
        public string State { get; set; }

        public override string ToString()
        {
            return this.City + ", " + this.State;
        }
    }
}
