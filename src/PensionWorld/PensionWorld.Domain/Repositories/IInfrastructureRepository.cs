namespace PensionWorld.Domain.Repositories
{
    using PensionWorld.Domain.MasterData;

    public interface IInfrastructureRepository
    {
        void Add(Room room);
    }
}