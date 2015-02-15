namespace PensionWorld.Domain.MasterData
{
    using System;

    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Contact Contact { get; set; }

        public string IdentityCard { get; set; }
    }
}