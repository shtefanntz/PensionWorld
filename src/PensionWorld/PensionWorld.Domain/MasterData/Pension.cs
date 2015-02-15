namespace PensionWorld.Domain.MasterData
{
    using System;

    public class Pension
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int ClassificationStars { get; set; }

        public Owner Owner { get; set; }

        public PensionGroup PensionGroup { get; set; }
    }
}