using System;
using System.Collections;
using UnityEngine;
using Collectibles;

namespace Player
{

    [RequireComponent(typeof(P_Controller))]
    public class P_Collectibles : MonoBehaviour
    {

        [SerializeField] bool autoCollect = false; // Collect item when walking through
        private P_Controller my_playerController;
        private static string collectibleTag = "Collectible";
        private Coroutine collectionCoroutine;


        private Action OnCollect;
        private bool collectOpen = false;
        private int collectibleCount;

        private void Awake()
        {
            my_playerController = GetComponent<P_Controller>();
        }

        private void OnEnable()
        {
            my_playerController.OnCollision += OnCollectibleCollision;
            my_playerController.TryCollect += BeginActiveCollection;
            my_playerController.TryDrop += DropCollectible; 
            OnCollect += OnCollectible;
        }

        private void OnDisable()
        {
            my_playerController.OnCollision -= OnCollectibleCollision;
            my_playerController.TryCollect -= BeginActiveCollection;
            my_playerController.TryDrop -= DropCollectible;

            OnCollect -= OnCollectible;
        }

        // Using a coroutine to give the player time for an item to be collected if they are running past
        //  and not exactly on the object when they try to collect
        private void ClearCollectingStatus()
        {
            if (collectionCoroutine != null)
            {
                StopCoroutine(collectionCoroutine);
                collectionCoroutine = null;
            }
            collectOpen = false;
        }

        private void BeginActiveCollection()
        {
            ClearCollectingStatus();
            collectionCoroutine = StartCoroutine(CollectionWindow());
        }

        IEnumerator CollectionWindow()
        {
            collectOpen = true;
            yield return new WaitForSeconds(0.2f);
            collectOpen = false;
        }

        public void DropCollectible()
        {
            if (collectibleCount <= 0)
                return;

            var newCollectible = CollectibleSpawner.Instance.PullCollectible();
            newCollectible.transform.position = this.transform.position + (transform.forward * 3f);
            collectibleCount--;

            my_playerController.SuccessfulDropEvent?.Invoke();
        }

        private void OnCollectible()
        {
            collectibleCount++;
        }

        private void OnCollectibleCollision(Collider other)
        {
            if (collectOpen == false && !autoCollect)
                return;

            if (other.CompareTag(collectibleTag))
            {
                OnCollect?.Invoke();
                ClearCollectingStatus();
                Collectible collectibleComponent = other.GetComponent<Collectible>();
                if (collectibleComponent != null)
                    collectibleComponent.OnCollect?.Invoke();
                else
                    throw new Exception("Item with Collectible tag does not contain component 'Collectible'");
            }
        }
    }

}