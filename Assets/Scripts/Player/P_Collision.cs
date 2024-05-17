using UnityEngine;


namespace Player
{
    [RequireComponent(typeof(CapsuleCollider), typeof(P_Controller))]
    public class P_Collision : MonoBehaviour
    {
        private P_Controller my_playerController;

        private void Awake()
        {
            my_playerController = GetComponent<P_Controller>();
        }

        private void OnTriggerEnter(Collider other) =>
            my_playerController.OnCollision?.Invoke(other);

        private void OnTriggerStay(Collider other) =>
            my_playerController.OnCollision?.Invoke(other);

    }
}
