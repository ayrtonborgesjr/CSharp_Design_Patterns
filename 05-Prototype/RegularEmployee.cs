namespace _05_Prototype
{
    public class RegularEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public IEmployee Clone()
        {
            return this.MemberwiseClone() as IEmployee;
        }

        public override string ToString()
        {
            return "\tName: " + Name + "\n\tAge: " + Age + "\n\tType: " + Type;
        }
    }
}
