using System;
using UnityEngine;
using UnityEngine.Events;


namespace Player
{
    public class P_Controller : MonoBehaviour
    {
        [SerializeField] private LayerMask collisionMask;
        [SerializeField] private P_Properties pProps;
        private bool isGrounded, isJumping;

        /* Seperated out so players recieve immediate feedback on turning- while it would be more realistic for 
        delayed turning with velocity changes- it isn't fun for the player*/
        private Vector3 externalVelocity, walkVelocity, startPos;
        private Vector2 direction;

        public Action<Vector2> OnMove;
        public Action<bool> OnGrounded;
        public Action<Collider> OnCollision;
        public Action SuccessfulDropEvent, TryDrop, TryCollect, OnRespawn, OnJump;

        //[SerializeField] public UnityEvent DropEvent; // Alternative if events want to be serialized

        private void OnEnable()
        {
            startPos = transform.position;
            OnJump += Jump;
            OnMove += SetWalkDirection;
            OnGrounded += SetGrounded;
            OnRespawn += Respawn;
        }

        private void OnDisable()
        {
            OnJump -= Jump;
            OnMove -= SetWalkDirection;
            OnGrounded -= SetGrounded;
            OnRespawn -= Respawn;
        }



        private void SetWalkDirection(Vector2 direction) => this.direction = direction.normalized;

        private void Respawn() => transform.position = startPos;

        // Updates the walkVelocity by new player direction
        private void UpdateWalkVelocity()
        {
            Vector3 acceleration = pProps.walkSpeed * new Vector3(direction.x, 0, direction.y);
            Vector3 updatedVelocity = walkVelocity + acceleration;

            updatedVelocity *= pProps.walkFriction;
            updatedVelocity = Vector3.ClampMagnitude(updatedVelocity, pProps.walkMaxVelocity);

            walkVelocity = updatedVelocity;
        }

        // Added for scenarios where the player may be pushed back- e.g conveyor mechanics
        public void ApplyExternalForce(Vector3 direction, float strength)
        {
            externalVelocity += direction.normalized * strength;
        }

        private void Jump()
        {
            if (!isGrounded || isJumping) return;

            externalVelocity.y += pProps.jumpForce;
            isJumping = true;
        }

        private void ApplyGravity()
        {
            if (isGrounded) return;
            externalVelocity.y -= pProps.gravityForce;
        }

        // Remove all vertical force when grounded otherwise slow momentum gradually and update position
        private void ApplyForces()
        {
            if (isGrounded && !isJumping)
                externalVelocity.y = 0;

            Vector3 totalVelocity = walkVelocity + externalVelocity;

            transform.position += totalVelocity * Time.deltaTime;
            externalVelocity = Vector3.Lerp(externalVelocity, Vector3.zero, pProps.worldFriction);

        }

        private void UpdateRotation()
        {
            transform.LookAt(transform.position + new Vector3(direction.x, 0, direction.y));
        }

        private void CheckGrounded()
        {
            Vector3 rayCastOrigin = transform.position;
            rayCastOrigin.y -= (pProps.characterHeight / 2) - pProps.groundCheckDistance; 

            bool newIsGrounded;

            if (Physics.Raycast(rayCastOrigin, Vector3.down, pProps.groundCheckDistance, collisionMask))
                newIsGrounded = true;
            else
                newIsGrounded = false;

            if (isGrounded != newIsGrounded)
                OnGrounded?.Invoke(newIsGrounded);
        }

        private void SetGrounded(bool state)
        {
            isGrounded = state;

            if (isGrounded)
                isJumping = false;
        }

        // Updates on input
        private void Update()
        {
            UpdateRotation();
        }

        void FixedUpdate()
        {
            CheckGrounded();
            ApplyGravity();
            UpdateWalkVelocity();
            ApplyForces();
        }
    }
}
