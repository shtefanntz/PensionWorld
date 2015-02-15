namespace PensionWorld.Domain.Model
{
    using System;

    public class Owner
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Contact Contact { get; set; }
    }
}