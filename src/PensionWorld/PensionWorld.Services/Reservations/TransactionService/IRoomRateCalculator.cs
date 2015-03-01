namespace PensionWorld.Services.Reservations.TransactionService
{
    using System;

    using PensionWorld.Domain.MasterData;

    public interface IRoomRateCalculator
    {
        decimal ComputePriceFor(RoomType roomType, DateTime startDate, int numberOfDays);
    }
}