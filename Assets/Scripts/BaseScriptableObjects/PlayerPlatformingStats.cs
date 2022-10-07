using UnityEngine;

namespace BaseScriptableObjects
{
    [CreateAssetMenu(fileName = "NewPlatformingStats", menuName = "Stats/PlayerPlatformingStats")]
    public class PlayerPlatformingStats : ScriptableObject
    {
        public GameEvent updateStats;
        public float maxJumpHeight = 3;
        public float minJumpHeight = 0.5f;
        public float timeToJumpApex = 0.3f;
        public float accelerationTimeAirborne = 0.1f;
        public float accelerationTimeGrounded = 0.075f;
        
        public float moveSpeed = 9f;

        public bool autoJump = true;

        private void OnValidate()
        {
            updateStats.Raise();
        }

        public void ResetStats()
        {
            maxJumpHeight = 3;
            minJumpHeight = 0.5f;
            timeToJumpApex = 0.3f;
            accelerationTimeAirborne = 0.1f;
            accelerationTimeGrounded = 0.075f;
        
            moveSpeed = 9f;

            autoJump = true;
        }
    }
}
