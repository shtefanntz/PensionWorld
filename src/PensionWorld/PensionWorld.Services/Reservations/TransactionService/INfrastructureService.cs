namespace PensionWorld.Services.Reservations.TransactionService
{
    using System.Transactions;

    using PensionWorld.Domain.MasterData;
    using PensionWorld.Domain.Repositories;

    public class InfrastructureService
    {
        private readonly IInfrastructureRepository repository;

        public InfrastructureService(IInfrastructureRepository repository)
        {
            this.repository = repository;
        }

        public void CreateRoom(Room room)
        {
            using (var transactionScope = new TransactionScope())
            {
                this.ValidateRoomName(room);
                this.ValidateRoomNumberIsUnique(room);
                
                this.repository.Add(room);

                transactionScope.Complete();
            }
        }

        private void ValidateRoomNumberIsUnique(Room room)
        {
        }

        private void ValidateRoomName(Room room)
        {
        }

        private void ValidateIfRoomHasType(Room room)
        {
        }
    }
}