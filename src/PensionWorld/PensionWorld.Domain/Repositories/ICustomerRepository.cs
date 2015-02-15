namespace PensionWorld.Domain.Repositories
{
    using System;

    using PensionWorld.Domain.MasterData;

    public interface ICustomerRepository
    {
        Customer GetById(Guid customerId);
    }
}