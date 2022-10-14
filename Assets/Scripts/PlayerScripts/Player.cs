using System;
using BaseScriptableObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerScripts
{
    [RequireComponent(typeof (PlayerInput))]
    [RequireComponent(typeof (Controller2D))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerPlatformingStats platformingStats;
        private Vector3 velocity;
        private Vector2 movementInput;
        private bool jumpHeld = false;
        private bool jumpReleased = false;
        
        private float gravity;
        private float maxJumpVelocity;
        private float minJumpVelocity;
        private float velocityXSmoothing;
        
        private Controller2D controller;

        [SerializeField] private bool disableMovement = false;

        private void Start()
        {
            controller = GetComponent<Controller2D>();

            UpdateJumpVariables();
        }

        private void FixedUpdate()
        {
            if(!disableMovement)
                MovementLogic();
        }

        public void DisableMovement()
        {
            disableMovement = true;
        }
        
        public void EnableMovement()
        {
            disableMovement = false;
        }

        public void GetJumpInput(InputAction.CallbackContext context)
        {
            if(context.performed)
                jumpHeld = true;

            if (context.canceled)
            {
                jumpReleased = true;

                if (platformingStats.autoJump)
                    jumpHeld = false;
            }
        }

        public void GetMovementInput(InputAction.CallbackContext context)
        {
            movementInput = new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y);
        }

        private void MovementLogic()
        {
            if (controller.collisions.above || controller.collisions.below) velocity.y = 0;

            if (jumpHeld && controller.collisions.below)
            {
                velocity.y = maxJumpVelocity;
            }
            else if (jumpReleased && velocity.y > minJumpVelocity)
            {
                velocity.y = minJumpVelocity;
            }

            float targetVelocityX = movementInput.x * platformingStats.moveSpeed;
            velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, 
                (controller.collisions.below) ? platformingStats.accelerationTimeGrounded : platformingStats.accelerationTimeAirborne);
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            
            if (!platformingStats.autoJump)
                jumpHeld = false;
            
            jumpReleased = false;
        }

        public void UpdateJumpVariables()
        {
            gravity = -(2 * platformingStats.maxJumpHeight) / Mathf.Pow(platformingStats.timeToJumpApex, 2);
            maxJumpVelocity = Mathf.Abs(gravity) * platformingStats.timeToJumpApex;
            minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(gravity) * platformingStats.minJumpHeight);
            
            print("Gravity: " + gravity + " Jump Velocity: " + maxJumpVelocity);
        }
    }
}
