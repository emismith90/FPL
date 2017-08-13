using AutoMapper;
using FantasyEPL.Data.Entities;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Mappers.Profiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            this.CreateMap<Event, EventEntity>();
        }
    }
}
