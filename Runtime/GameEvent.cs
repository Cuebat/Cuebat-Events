using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cuebat.Events
{
    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();


        public void Raise()
        {
            foreach (GameEventListener listener in listeners)
            {
                listener.OnRaiseEvent();
            }

        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener)) listeners.Add(listener);
        }
        public void UnregisterListener(GameEventListener listener)
        {
            if (listeners.Contains(listener)) listeners.Remove(listener);

        }
    }
}
