using AutoMapper;
using FantasyEPL.Data.Entities;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Mappers.Profiles
{
    public class PlayerPositionMappingProfile : Profile
    {
        public PlayerPositionMappingProfile()
        {
            this.CreateMap<ElementType, PlayerPositionEntity>()
                .ForMember(m => m.Name, opt => opt.MapFrom(e => e.SingularName))
                .ForMember(m => m.ShortName, opt => opt.MapFrom(e => e.SingularNameShort));
        }
    }
}
