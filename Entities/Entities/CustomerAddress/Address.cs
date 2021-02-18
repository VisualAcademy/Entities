namespace Entities.CustomerAddress
{
    public class Address
    {
        public string Line { get; set; }
        public string PostalOrZipCode { get; set; }
        public string StateOrProvince { get; set; }
        public string CityOrTown { get; internal set; }
    }
}
