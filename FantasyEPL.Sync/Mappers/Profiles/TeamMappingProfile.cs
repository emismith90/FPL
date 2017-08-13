using AutoMapper;
using FantasyEPL.Data.Entities;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Mappers.Profiles
{
    public class TeamMappingProfile : Profile
    {
        public TeamMappingProfile()
        {
            this.CreateMap<Team, TeamEntity>();
            this.CreateMap<Team, TeamByEventEntity>()
                .ForMember(m => m.TeamId, opt => opt.MapFrom(e => e.Id))
                .ForMember(m => m.Point, opt => opt.MapFrom(e => e.Points))
                .ForMember(m => m.GamePlayed, opt => opt.MapFrom(e => e.Played))
                .ForMember(m => m.GameWin, opt => opt.MapFrom(e => e.Win))
                .ForMember(m => m.GameLoss, opt => opt.MapFrom(e => e.Loss))
                .ForMember(m => m.GameDraw, opt => opt.MapFrom(e => e.Draw))
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(m => m.Team, opt => opt.Ignore())
                .ForMember(m => m.Event, opt => opt.Ignore());
        }
    }
}
