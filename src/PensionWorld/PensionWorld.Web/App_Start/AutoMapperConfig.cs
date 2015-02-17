namespace PensionWorld.Web.App_Start
{
    using AutoMapper;

    using PensionWorld.Domain.MasterData;
    using PensionWorld.Web.Models;

    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Room, RoomViewModel>()
                .ForMember(x => x.Type, opt => opt.MapFrom(x => x.Type.Description));
        }
    }
}