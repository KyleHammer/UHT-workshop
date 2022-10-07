using UnityEngine;
using UnityEngine.Events;

namespace BaseScriptableObjects
{
    public class GameEventListener : MonoBehaviour
    {
        // Attach this script to an object that wants to listen out for something
    
        [Tooltip("Event to register with.")]
        public GameEvent Event;
    
        [Tooltip("Response to invoke when Event is raised")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}
