using System;
using System.Reflection.Metadata.Ecma335;

namespace _04_Builder
{
    public class CellPhone
    {
        public CellPhone(string mobileName)
        {
            this.Name = mobileName;
        }

        public string MobileName;
        public string Name { get; set; }
        public string Screen { get; set; }
        public string Battery { get; set; }
        public string OperationaSystem { get; set; }
        public string Camera { get; set; }
    }
}
