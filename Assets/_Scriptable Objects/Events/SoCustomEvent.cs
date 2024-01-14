using System.Collections.Generic;
using _Scripts.Events;
using UnityEngine;

namespace _Scriptable_Objects.Events
{
    [CreateAssetMenu(fileName = "New Custom Event", menuName = "Scriptable Object/Custom Event")]
    public class SoCustomEvent : ScriptableObject
    {
        private List<SoCustomEventListener> _listeners = new List<SoCustomEventListener>();
        
        public void Raise()
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised();
            }
        }
        
        public void RegisterListener(SoCustomEventListener listener)
        {
            _listeners.Add(listener);
        }
        
        public void UnregisterListener(SoCustomEventListener listener)
        {
            _listeners.Remove(listener);
        }
    }
}