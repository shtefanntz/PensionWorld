namespace PensionWorld.Domain.Model
{
    using System;

    public class RoomType
    {
        public Guid Id { get; set; }

        public string TypeName { get; set; }

        public string Description { get; set; }
    }
}