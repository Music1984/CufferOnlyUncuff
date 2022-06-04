namespace CufferOnlyUncuff
{
    using System;
    using Exiled.API.Features;
    using PlayerHandlers = Exiled.Events.Handlers.Player;

    /// <inheritdoc />
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc/>
        public override string Author { get; } = "Music";

        /// <inheritdoc/>
        public override string Name { get; } = "CufferOnlyUncuff";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        /// <inheritdoc/>
        public override string Prefix { get; } = "CufferOnlyUncuff";

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            PlayerHandlers.Handcuffing += eventHandlers.OnCuffing;
            PlayerHandlers.RemovingHandcuffs += eventHandlers.OnUncuffing;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            PlayerHandlers.Handcuffing -= eventHandlers.OnCuffing;
            PlayerHandlers.RemovingHandcuffs -= eventHandlers.OnUncuffing;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}