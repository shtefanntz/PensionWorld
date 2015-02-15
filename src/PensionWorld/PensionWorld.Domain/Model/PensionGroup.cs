namespace PensionWorld.Domain.Model
{
    using System;
    using System.Collections.Generic;

    public class PensionGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Owner Owner { get; set; }

        public Contact Contact { get; set; }

        public IList<Pension> Pensions { get; set; }
    }
}