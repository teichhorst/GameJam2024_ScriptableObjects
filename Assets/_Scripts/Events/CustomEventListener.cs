using _Scriptable_Objects.Events;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Events
{
    public class CustomEventListener : MonoBehaviour
    {
        public CustomEvent customEvent;
        public UnityEvent eventResponse;
        
        private void OnEnable()
        {
            customEvent.RegisterListener(this);
        }
        
        private void OnDisable()
        {
            customEvent.UnregisterListener(this);
        }
        
        public void OnEventRaised()
        {
            eventResponse.Invoke();
        }
    }
}