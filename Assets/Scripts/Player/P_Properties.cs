using UnityEngine;

/* Created as a scriptable object so data can be modified during play and maintained
 * In addition different player loadouts can be tested + the main player script is less cluttered with floats
*/

namespace Player
{
    [CreateAssetMenu(fileName = "Player_Data", menuName = "Player/Player_Data")]
    public class P_Properties : ScriptableObject
    {
        public float walkSpeed, walkFriction, worldFriction,
            jumpForce, walkMaxVelocity, walkAcceleration, characterHeight, gravityForce, groundCheckDistance;

    }
}
