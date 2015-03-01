namespace PensionWorld.Domain.TransactionScripts
{
    using System;

    using PensionWorld.Domain.MasterData;

    public class Reservation
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime BeginDate { get; set; }

        public int Days { get; set; }

        public string CustomerName { get; set; }

        public Guid PensionId { get; set; }

        public RoomType RoomType { get; set; }

        public decimal AmountPaid { get; set; }

        public ReservationStatus Status { get; set; }

        public string ReferenceNumber { get; set; }

        public decimal BookingAmount { get; set; }
    }
}