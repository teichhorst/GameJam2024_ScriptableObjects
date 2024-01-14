using System.Collections.Generic;
using _Scripts.Events;
using UnityEngine;

namespace _Scriptable_Objects.Events
{
    public class CustomEvent : ScriptableObject
    {
        private List<CustomEventListener> _listeners = new List<CustomEventListener>();
        
            
        public void Raise()
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised();
            }
        }
        
        public void RegisterListener(CustomEventListener listener)
        {
            _listeners.Add(listener);
        }
        
        public void UnregisterListener(CustomEventListener listener)
        {
            _listeners.Remove(listener);
        }
    }
}