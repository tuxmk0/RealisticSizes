#if EXILED
using System;
using System.IO;
using Exiled.API.Features;

namespace RealisticSizes
{
    public class Plugin : Plugin<Config>
    {

        public static Plugin Instance;
        public EventHandlers eventHandlers { get; set; }
        public const string PluginVersion = "1.0.2";

        public override string Name => "Realistic Sizes";
        public override string Author => "tux";
        public override Version Version => new Version(PluginVersion);
        public override Version RequiredExiledVersion => new Version(8, 7, 3);

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();

            RegisterEvents();

            base.OnEnabled();

            Log.Debug($"{Name} {Version} by {Author} loaded! Thanks for using my plugin!");
        }

        public override void OnDisabled()
        {
            Instance = null;
            eventHandlers = null;

            UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died += eventHandlers.PlayerDied;
            Exiled.Events.Handlers.Player.Spawned += eventHandlers.PlayerSpawned;
        }
        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.Died -= eventHandlers.PlayerDied;
            Exiled.Events.Handlers.Player.Spawned -= eventHandlers.PlayerSpawned;
        }
    }
}
#endif