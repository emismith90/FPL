using AutoMapper;
using FantasyEPL.Data.Entities;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Mappers.Profiles
{
    public class PlayerMappingProfile : Profile
    {
        public PlayerMappingProfile()
        {
            this.CreateMap<Element, PlayerEntity>();

            this.CreateMap<Element, PlayerByEventEntity>()
                .ForMember(m => m.PlayerId, opt => opt.MapFrom(e => e.Id))
                .ForMember(m => m.TeamId, opt => opt.MapFrom(e => e.Team))
                .ForMember(m => m.PositionId, opt => opt.MapFrom(e => e.ElementType))
                .ForMember(m => m.BPS, opt => opt.MapFrom(e => e.Bps))
                .ForMember(m => m.ICTIndex, opt => opt.MapFrom(e => e.IctIndex))
                .ForMember(m => m.EAIndex, opt => opt.MapFrom(e => e.EaIndex))
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Team, opt => opt.Ignore())
                .ForMember(x => x.Position, opt => opt.Ignore())
                .ForMember(x => x.Event, opt => opt.Ignore())
                .ForMember(x => x.Player, opt => opt.Ignore());
        }
    }
}
