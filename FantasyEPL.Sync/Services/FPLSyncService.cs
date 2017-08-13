using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Antares.Essentials.Data.Repositories;
using Antares.Essentials.Data.Entities;
using FantasyEPL.Data.Entities;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Services
{
    public class FPLSyncService : IFPLSyncService
    {
        private readonly IMapper Mapper;
        private readonly IGenericRepository<EventEntity> EventRepository;
        private readonly IGenericRepository<PlayerPositionEntity> PlayerPositionRepository;
        private readonly IGenericRepository<TeamEntity> TeamRepository;
        private readonly IGenericRepository<TeamByEventEntity> TeamByEventRepository;
        private readonly IGenericRepository<PlayerEntity> PlayerRepository;
        private readonly IGenericRepository<PlayerByEventEntity> PlayerByEventRepository;

        public FPLSyncService(IMapper mapper, 
            IGenericRepository<EventEntity> eventRepository,
            IGenericRepository<PlayerPositionEntity> playerPositionRepository,
            IGenericRepository<TeamEntity> teamRepository,
            IGenericRepository<TeamByEventEntity> teamByEventRepository,
            IGenericRepository<PlayerEntity> playerRepository,
            IGenericRepository<PlayerByEventEntity> playerByEventRepository)
        {
            Mapper = mapper;
            EventRepository = eventRepository;
            PlayerPositionRepository = playerPositionRepository;
            TeamRepository = teamRepository;
            TeamByEventRepository = teamByEventRepository;
            PlayerRepository = playerRepository;
            PlayerByEventRepository = playerByEventRepository;
        }

        public void SyncEvents(IList<Event> events)
        {
            if (events == null || !events.Any())
                throw new ArgumentException("events");

            Sync(EventRepository, Mapper.Map<IList<EventEntity>>(events));
        }

        public void SyncPlayerPositions(IList<ElementType> elementTypes)
        {
            if (elementTypes == null || !elementTypes.Any())
                throw new ArgumentException("elementTypes");

            Sync(PlayerPositionRepository, Mapper.Map<IList<PlayerPositionEntity>>(elementTypes));
        }

        public void SyncTeams(IList<Team> teams)
        {
            if (teams == null || !teams.Any())
                throw new ArgumentException("teams");

            Sync(TeamRepository, Mapper.Map<IList<TeamEntity>>(teams));
        }

        public void SyncTeamsByEvent(Event fixture, IList<Team> teams)
        {
            if (fixture == null)
                throw new ArgumentException("fixture");

            if (teams == null || !teams.Any())
                throw new ArgumentException("teams");

            foreach(var team in Mapper.Map<IList<TeamByEventEntity>>(teams))
            {
                team.EventId = fixture.Id;
                var exist = TeamByEventRepository
                                .Find(t => t.TeamId == team.TeamId && t.EventId == team.EventId)
                                .SingleOrDefault();

                if(exist == null)
                {
                    TeamByEventRepository.Add(team);
                }
                else
                {
                    team.Id = exist.Id; 
                    TeamByEventRepository.Update(team);
                }
            }
        }

        public void SyncPlayers(IList<Element> players)
        {
            if (players == null || !players.Any())
                throw new ArgumentException("players");

            Sync(PlayerRepository, Mapper.Map<IList<PlayerEntity>>(players));
        }

        public void SyncPlayersByEvent(Event fixture, IList<Element> players)
        {
            if (fixture == null)
                throw new ArgumentException("fixture");

            if (players == null || !players.Any())
                throw new ArgumentException("players");

            foreach (var player in Mapper.Map<IList<PlayerByEventEntity>>(players))
            {
                player.EventId = fixture.Id;
                var exist = PlayerByEventRepository
                                .Find(p => p.PlayerId == player.PlayerId && p.EventId == player.EventId)
                                .SingleOrDefault();

                if (exist == null)
                {
                    PlayerByEventRepository.Add(player);
                }
                else
                {
                    player.Id = exist.Id;
                    PlayerByEventRepository.Update(player);
                }
            }
        }

        private void Sync<TEntity>(IGenericRepository<TEntity> repository, IList<TEntity> entities) 
            where TEntity : class, IEntity
        {
            foreach (var entity in entities)
            {
                repository.AddOrUpdate(entity);
            }
        }
    }
}
