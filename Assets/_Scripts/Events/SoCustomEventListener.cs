using _Scriptable_Objects.Events;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace _Scripts.Events
{
    public class SoCustomEventListener : MonoBehaviour
    {
        public SoCustomEvent soCustomEvent;
        public UnityEvent eventResponse;
        
        private void OnEnable()
        {
            soCustomEvent.RegisterListener(this);
        }
        
        private void OnDisable()
        {
            soCustomEvent.UnregisterListener(this);
        }
        
        public void OnEventRaised()
        {
            eventResponse.Invoke();
        }
    }
}