using Antares.Essentials.Configuration;

namespace FantasyEPL.Sync.Configurations
{
    public class SyncOptions : OptionsBase
    {
        public SyncOptions(IAppSettings scope) : base(scope)
        {
        }

        private OverTheWireOptions _overTheWire;
        public OverTheWireOptions OverTheWire
        {
            get
            {
                return _overTheWire ?? (_overTheWire = new OverTheWireOptions(CurrentSection));
            }
        }

        private LocalOptions _local;
        public LocalOptions Local
        {
            get
            {
                return _local ?? (_local = new LocalOptions(CurrentSection));
            }
        }
    }
}
