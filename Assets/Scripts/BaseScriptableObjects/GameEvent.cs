﻿using System.Collections.Generic;
using UnityEngine;

namespace BaseScriptableObjects
{
    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        // List of listeners that will be notified when the
        // event is raised
        private readonly List<GameEventListener> eventListeners = new List<GameEventListener>();
    
        public void Raise()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }
    }
}
