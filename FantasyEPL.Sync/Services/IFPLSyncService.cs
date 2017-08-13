using System.Collections.Generic;
using FantasyEPL.Sync.Models;

namespace FantasyEPL.Sync.Services
{
    public interface IFPLSyncService
    {
        void SyncEvents(IList<Event> events);

        void SyncPlayerPositions(IList<ElementType> elementTypes);

        void SyncTeams(IList<Team> teams);
        void SyncTeamsByEvent(Event fixture, IList<Team> teams);

        void SyncPlayers(IList<Element> players);
        void SyncPlayersByEvent(Event fixture, IList<Element> players);
    }
}
