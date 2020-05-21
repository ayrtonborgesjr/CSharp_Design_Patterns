namespace Dependency_Injection
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private IAddressObject Address_;
        
        public IAddressObject Address
        {
            get { return Address_; }
            set { Address_ = value; }
        }

        /*
        public Company(int id, string name, IAddressObject address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        */
        public override string ToString()
        {
            return "Company Name: " + this.Name + ", Address: " + this.Address.ToString();
        }
    }
}
