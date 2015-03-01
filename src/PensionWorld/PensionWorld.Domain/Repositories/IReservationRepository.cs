namespace PensionWorld.Domain.Repositories
{
    using System;
    using System.Linq;

    using PensionWorld.Domain.MasterData;
    using PensionWorld.Domain.TransactionScripts;

    public interface IReservationRepository
    {
        void SaveChanges();

        void Add(Reservation reservation);

        IQueryable<Reservation> GetAllReservationBetween(RoomType roomType, DateTime beginDate, DateTime endDate);

        Reservation GetById(Guid id);

        void Update(Reservation reservation);
    }
}