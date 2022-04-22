using System.Collections.Generic;
using UnityEngine;
using System;

namespace TestProject
{
    public class GameStateHandler : MonoBehaviour
    {
        private static event Action _startAction;
        private static event Action _finishAction;

        private static Dictionary<GlobalGameEvent, Action> _events = new Dictionary<GlobalGameEvent, Action>()
        {
            { GlobalGameEvent.Start, _startAction },
            { GlobalGameEvent.Finish, _finishAction }
        };

        private void Start()
        {
            TriggerEvent(GlobalGameEvent.Start);
        }

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
    }
}
