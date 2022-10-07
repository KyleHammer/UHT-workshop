using UnityEngine;

namespace BaseScriptableObjects
{
    [CreateAssetMenu(fileName = "NewPlatformingStats", menuName = "Stats/PlayerPlatformingStats")]
    public class PlayerPlatformingStats : ScriptableObject
    {
        public GameEvent updateStats;
        public float maxJumpHeight = 3;
        public float minJumpHeight = 1;
        public float timeToJumpApex = 0.3f;
        public float accelerationTimeAirborne = 0.2f;
        public float accelerationTimeGrounded = 0.1f;
        
        public float moveSpeed = 9f;

        public bool autoJump = false;

        private void OnValidate()
        {
            updateStats.Raise();
        }
    }
}
