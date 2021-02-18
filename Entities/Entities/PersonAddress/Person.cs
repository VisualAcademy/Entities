namespace Entities.PersonAddress
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }
    }
}
