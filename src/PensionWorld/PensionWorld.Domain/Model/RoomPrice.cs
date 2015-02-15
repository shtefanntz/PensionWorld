namespace PensionWorld.Domain.Model
{
    using System;

    public class RoomPrice
    {
        public Guid Id { get; set; }

        public Pension Pension { get; set; }

        public RoomType RoomType { get; set; }

        public decimal Value { get; set; }

        public Period Period { get; set; }
    }
}