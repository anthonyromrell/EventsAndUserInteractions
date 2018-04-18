using System.Collections.Generic;
using RoboRyanTron.Unite2017.Events;

namespace AR.Events
{
    public abstract class IGameEvent
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<GameEventListener> eventListeners;

        public abstract void Raise();
        public abstract void RegisterListener(GameEventListener listener);
        public abstract void UnregisterListener(GameEventListener listener);
    }
}