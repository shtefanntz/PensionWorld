namespace PensionWorld.Domain.MasterData
{
    using System;

    public class Room
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public RoomType Type { get; set; }

        public Guid PensionId { get; set; }
    }
}