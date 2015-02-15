namespace PensionWorld.Domain.Model
{
    using System;

    public class Room
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public RoomType Type { get; set; }
    }
}