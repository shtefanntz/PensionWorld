namespace PensionWorld.Services.DTO
{
    using System;

    public class ReservationDto
    {
        public Guid CustomerId { get; set; }

        public DateTime BeginDate { get; set; }

        public int Days { get; set; }

        public string CustomerName { get; set; }

        public Guid PensionId { get; set; }

        public Guid RoomId { get; set; }

        public decimal Amount { get; set; }

        public ReservationStatus Status { get; set; }

        public string ReferenceNumber { get; set; }

        public Guid Id { get; set; }
    }
}