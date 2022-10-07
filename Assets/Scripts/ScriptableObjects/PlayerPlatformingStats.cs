using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewPlatformingStats", menuName = "Stats/PlayerPlatformingStats")]
    public class PlayerPlatformingStats : ScriptableObject
    {
        public float jumpHeight = 3;
        public float timeToJumpApex = 0.3f;
        public float accelerationTimeAirborne = 0.2f;
        public float accelerationTimeGrounded = 0.1f;
        
        public float moveSpeed = 9f;

        public bool autoJump = false;
    }
}
