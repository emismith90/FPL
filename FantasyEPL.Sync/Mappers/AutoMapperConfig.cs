using AutoMapper;
using FantasyEPL.Sync.Mappers.Profiles;

namespace FantasyEPL.Sync.Mappers
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EventMappingProfile());
                cfg.AddProfile(new PlayerPositionMappingProfile());

                cfg.AddProfile(new PlayerMappingProfile());

                cfg.AddProfile(new TeamMappingProfile());
            });
        }
    }
}
