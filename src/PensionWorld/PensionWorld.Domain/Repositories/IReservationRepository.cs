namespace PensionWorld.Domain.Repositories
{
    using System;
    using System.Linq;

    using PensionWorld.Domain.TransactionScripts;

    public interface IReservationRepository
    {
        void SaveChanges();

        void Add(Reservation reservation);

        IQueryable<Reservation> GetAllReservationBetween(Guid roomId, DateTime beginDate, DateTime endDate);

        Reservation GetById(Guid id);

        void Update(Reservation reservation);
    }
}