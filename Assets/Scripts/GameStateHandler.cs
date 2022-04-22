using System.Collections.Generic;
using UnityEngine;
using System;

namespace TestProject
{
    public class GameStateHandler : MonoBehaviour
    {
        private static event Action StartAction;
        private static event Action FinishAction;

        private static Dictionary<GlobalGameEvent, Action> _events = new Dictionary<GlobalGameEvent, Action>()
        {
            { GlobalGameEvent.Start, StartAction },
            { GlobalGameEvent.Finish, FinishAction }
        };

        public static void Subscribe(GlobalGameEvent gameEvent, Action eventReceiver)
        {
            if (_events.ContainsKey(gameEvent))
                _events[gameEvent] += eventReceiver;
        }

        public static void UnSubscribe(GlobalGameEvent gameEvent, Action eventReceiver)
        {
            if (_events.ContainsKey(gameEvent))
                _events[gameEvent] -= eventReceiver;
        }

        public static void TriggerEvent(GlobalGameEvent gameEvent)
        {
            if (_events.ContainsKey(gameEvent))
                _events[gameEvent]?.Invoke();
        }

        private void Start()
        {
            TriggerEvent(GlobalGameEvent.Start);
        }
    }
}
