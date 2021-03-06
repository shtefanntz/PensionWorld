﻿namespace PensionWorld.Domain.MasterData
{
    using System;

    public class Room
    {
        public Guid Id { get; set; }

        public Guid PensionId { get; set; }

        public int Number { get; set; }

        public RoomType Type { get; set; }

        public float Surface { get; set; }

        public int Floor { get; set; }

        public bool HasBalcony { get; set; }

        public bool HasBathroom { get; set; }
    }
}