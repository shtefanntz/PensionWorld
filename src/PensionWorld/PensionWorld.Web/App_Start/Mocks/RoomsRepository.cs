using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PensionWorld.Web.App_Start.Mocks
{
    using PensionWorld.Domain.MasterData;
    using PensionWorld.Domain.Repositories;

    public class RoomsRepositoryMock : IRoomsRepository
    {
        public IQueryable<Room> GetAll()
        {
            return
                new List<Room>
                {
                    new Room
                    {
                        Id = Guid.Parse("90A37F5A-DC69-447B-8B20-EFA3FA6BE61E"),
                        Floor = 0,
                        Surface = 30f,
                        HasBalcony = true,
                        HasBathroom = true,
                        Number = 1,
                        Type = new RoomType
                               {
                                   Description = "Enterprise as hell"
                               }
                    },
                    new Room
                    {
                        Id = Guid.Parse("90A37F5A-DC69-447B-8B20-EFA3FA6BE61F"),
                        Floor = 0,
                        Surface = 30f,
                        HasBalcony = true,
                        HasBathroom = true,
                        Number = 2,
                        Type = new RoomType
                               {
                                   Description = "Enterprise as hell"
                               }
                    },
                    new Room
                    {
                        Id = Guid.Parse("90A37F5A-DC69-447B-8B20-EFA3FA6BE61D"),
                        Floor = 1,
                        Surface = 14.5f,
                        HasBalcony = false,
                        HasBathroom = false,
                        Number = 3,
                        Type = new RoomType
                               {
                                   Description = "For peasants"
                               }
                    },
                    new Room
                    {
                        Id = Guid.Parse("90A37F5A-DC69-447B-8B20-EFA3FA6BE61A"),
                        Floor = 1,
                        Surface = 10f,
                        HasBalcony = false,
                        HasBathroom = false,
                        Number = 4,
                        Type = new RoomType
                               {
                                   Description = "For students"
                               }
                    },
                }.AsQueryable();
        }

        public Room GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}