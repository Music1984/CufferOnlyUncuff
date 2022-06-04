using System.Collections.Generic;
using Exiled.Events.EventArgs;

namespace CufferOnlyUncuff
{
    using Exiled.API.Features;

    
    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;
        Dictionary<Player, Player> cuffedList =
            new Dictionary<Player, Player>();
        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">The <see cref="Plugin{TConfig}"/> class reference.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnCuffing(HandcuffingEventArgs ev)
        {
            cuffedList.Add(ev.Target, ev.Cuffer);
        }

        public void OnUncuffing(RemovingHandcuffsEventArgs ev)
        {
            if (cuffedList.TryGetValue(ev.Target, out Player value))
            {
                if (ev.Cuffer == value)
                {
                    return;
                }

                ev.IsAllowed = false;
            }
        }
    }
}