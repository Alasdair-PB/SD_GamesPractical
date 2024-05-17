using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    // Using Unity's 'new' Input system to register bindings
    [RequireComponent(typeof(P_Controller), typeof(PlayerMapping))]
    public class P_InputManager : MonoBehaviour
    {
        private PlayerMapping inputBindings;
        private P_Controller my_playerController;

        private void Awake()
        {
            my_playerController = GetComponent<P_Controller>();
            inputBindings = new PlayerMapping();
        }

        private void OnEnable()
        {
            inputBindings.Enable();
            inputBindings.PlayerMap.Jump.performed += ctx => my_playerController.OnJump?.Invoke();
            inputBindings.PlayerMap.Drop.performed += ctx => my_playerController.TryDrop?.Invoke();
            inputBindings.PlayerMap.Collect.performed += ctx => my_playerController.TryCollect?.Invoke();
            inputBindings.PlayerMap.Respawn.performed += ctx => my_playerController.OnRespawn?.Invoke();
        }

        private void OnDisable()
        {
            inputBindings.PlayerMap.Jump.performed -= ctx => my_playerController.OnJump?.Invoke();
            inputBindings.PlayerMap.Drop.performed -= ctx => my_playerController.TryDrop?.Invoke();
            inputBindings.PlayerMap.Collect.performed -= ctx => my_playerController.TryCollect?.Invoke();
            inputBindings.PlayerMap.Respawn.performed -= ctx => my_playerController.OnRespawn?.Invoke();

            inputBindings.Disable();
        }

        private void Update()
        {
            var deltaX = inputBindings.PlayerMap.XAxis.ReadValue<float>();
            var deltaY = inputBindings.PlayerMap.YAxis.ReadValue<float>();
            my_playerController.OnMove?.Invoke(new Vector2(deltaX, deltaY));
        }
    }
}
