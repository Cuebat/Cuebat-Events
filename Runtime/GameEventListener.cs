using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Cuebat.Events
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent Event;
        public UnityEvent Response;
        public void OnRaiseEvent()
        {
            Response?.Invoke();
        }

        void OnEnable()
        {

            Event.RegisterListener(this);

        }
        void OnDisable()
        {

            Event.UnregisterListener(this);


        }
    }
}