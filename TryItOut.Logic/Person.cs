using TryItOut.CommonInterfaces;

namespace TryItOut.Logic
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Identifier { get; set; }

        public string IdentifierGet()
        {
            return Identifier;
        }

        public string NameGet()
        {
            return Name;
        }
    }
}