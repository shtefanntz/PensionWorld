namespace PensionWorld.Domain.MasterData
{
    using System;

    public class Address
    {
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string Municipality { get; set; }

        public string PostalCode { get; set; }

        public string StreetAddress { get; set; }
    }
}