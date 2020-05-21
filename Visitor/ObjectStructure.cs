using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStructure
    {
        private List<Element> Elements = new List<Element>();

        public void Attach(Element element)
        {
            this.Elements.Add(element);
        }

        public void Detach(Element element)
        {
            this.Elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element item in Elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
