namespace BootcampClassLibrary;

public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public String GenrateAdress()
        {
            return "this is the default address";
        }
    }
