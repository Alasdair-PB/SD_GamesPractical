using UnityEngine;


// Here as an example of how additional effects could be easily added- VFX, animation et al code could all look quite similar

namespace Player
{
    [RequireComponent(typeof(P_Controller), typeof(AudioSource))]
    public class P_Audio : MonoBehaviour
    {
        private P_Controller my_playerController;
        private AudioSource audioSource;
        [SerializeField] private AudioClip jumpSound, dropSound;

        private void Awake()
        {
            my_playerController = GetComponent<P_Controller>();
            audioSource = GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            my_playerController.OnJump += PlayJumpSound;
            my_playerController.SuccessfulDropEvent += PlayDropSound;
            // + any other events that could use sounds
        }

        private void OnDisable()
        {
            my_playerController.OnJump -= PlayJumpSound;
            my_playerController.SuccessfulDropEvent -= PlayDropSound;
        }

        private void PlayJumpSound() =>
            audioSource.PlayOneShot(jumpSound);

        public void PlayDropSound() =>
            audioSource.PlayOneShot(dropSound);

    }
}
