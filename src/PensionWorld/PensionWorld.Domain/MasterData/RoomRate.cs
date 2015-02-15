namespace PensionWorld.Domain.MasterData
{
    using System;

    public class RoomRate
    {
        public Guid Id { get; set; }

        public Pension Pension { get; set; }

        public RoomType RoomType { get; set; }

        public decimal Value { get; set; }

        public Period Period { get; set; }
    }
}