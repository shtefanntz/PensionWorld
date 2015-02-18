using System;
using System.Collections.Generic;
using System.Linq;

namespace PensionWorld.Services
{
    using PensionWorld.Domain.MasterData;
    using PensionWorld.Domain.Repositories;

    public interface IRoomsService
    {
        List<Room> GetAllRooms();

        void CreateRoom(Room room);
    }

    public class RoomsService : IRoomsService
    {
        private readonly IRoomsRepository roomRepository;

        public RoomsService(IRoomsRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        public List<Room> GetAllRooms()
        {
            return this.roomRepository.GetAll().ToList();
        }

        public void CreateRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException("room", "New room cannot be null");
            }
            this.roomRepository.Save(room, Guid.NewGuid());
        }
    }
}
